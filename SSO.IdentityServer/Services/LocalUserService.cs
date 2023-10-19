﻿using Microsoft.EntityFrameworkCore;
using SSO.IdentityServer.DbContexts;
using SSO.IdentityServer.Entities;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;

namespace SSO.IdentityServer.Services;

public class LocalUserService : ILocalUserService
{
    private readonly IdentityDbContext _context;

    public LocalUserService(
        IdentityDbContext context)
    {
        _context = context ??
                   throw new ArgumentNullException(nameof(context));
    }

    public async Task<bool> IsUserActive(string subject)
    {
        if (string.IsNullOrWhiteSpace(subject))
        {
            return false;
        }

        var user = await GetUserBySubjectAsync(subject);

        if (user == null)
        {
            return false;
        }

        return user.Active;
    }

    public async Task<bool> ValidateCredentialsAsync(string userName,
        string password)
    {
        if (string.IsNullOrWhiteSpace(userName) ||
            string.IsNullOrWhiteSpace(password))
        {
            return false;
        }

        var user = await GetUserByUserNameAsync(userName);

        if (user == null)
        {
            return false;
        }

        if (!user.Active)
        {
            return false;
        }

        // Validate credentials
        // return (user.Password == password);
        //var verificationResult =
        //    _passwordHasher.VerifyHashedPassword(
        //        user, user.Password, password);
        //return (verificationResult == PasswordVerificationResult.Success);

        return true;
    }

    public async Task<User> GetUserByUserNameAsync(string userName)
    {
        if (string.IsNullOrWhiteSpace(userName))
        {
            throw new ArgumentNullException(nameof(userName));
        }

        return await _context.Users
            .FirstOrDefaultAsync(u => u.UserName == userName);
    }

    public async Task<IEnumerable<UserClaim>> GetUserClaimsBySubjectAsync(string subject)
    {
        if (string.IsNullOrWhiteSpace(subject))
        {
            throw new ArgumentNullException(nameof(subject));
        }

        return await _context.UserClaims.Where(u =>
            u.User.Subject == subject).ToListAsync();
    }

    public async Task<User> GetUserBySubjectAsync(string subject)
    {
        if (string.IsNullOrWhiteSpace(subject))
        {
            throw new ArgumentNullException(nameof(subject));
        }

        return await _context.Users.FirstOrDefaultAsync(u =>
            u.Subject == subject);
    }

    public void AddUser(User userToAdd, string password)
    {
        if (userToAdd == null)
        {
            throw new ArgumentNullException(nameof(userToAdd));
        }

        if (_context.Users.Any(u => u.UserName == userToAdd.UserName))
        {
            // in a real-life scenario you'll probably want to 
            // return this as a validation issue
            throw new Exception("Username must be unique");
        }

        //if (_context.Users.Any(u => u.Email == userToAdd.Email))
        //{
        //    throw new Exception("Email must be unique");
        //}

        //userToAdd.SecurityCode = Convert.ToBase64String(
        //    RandomNumberGenerator.GetBytes(128));
        //userToAdd.SecurityCodeExpirationDate = DateTime.UtcNow.AddHours(1);

        //// hash & salt the password
        //userToAdd.Password =
        //    _passwordHasher.HashPassword(userToAdd, password);

        _context.Users.Add(userToAdd);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync() > 0);
    }
}