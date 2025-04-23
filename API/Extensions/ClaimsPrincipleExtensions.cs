using System;
using System.Security.Authentication;
using System.Security.Claims;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ClaimsPrincipleExtensions
{
    public static async Task<AppUser> GetUserByEmail(this UserManager<AppUser> userManager, ClaimsPrincipal user){
        var returnedUser = await userManager.Users.FirstOrDefaultAsync(x=> x.Email == user.GetEmail());
        if(returnedUser == null) throw new AuthenticationException("User is not found");
        return returnedUser;
    }

    public static string GetEmail(this ClaimsPrincipal user){
        var email = user.FindFirstValue(ClaimTypes.Email) 
            ?? throw new AuthenticationException("Email claim not found");
        return email;
    }

    public static async Task<AppUser> GetUserByEmailWithAddress(this UserManager<AppUser> userManager, ClaimsPrincipal user){
        var returnedUser = await userManager.Users
        .Include(x=> x.Address)
        .FirstOrDefaultAsync(x=> x.Email == user.GetEmail());
        if(returnedUser == null) throw new AuthenticationException("User is not found");
        return returnedUser;
    }

}
