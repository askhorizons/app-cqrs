using Core.Entities;
using Core.Repositories;
using Core.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AspnetRunContextSeed
    {
        private readonly AspnetRunContext _aspnetRunContext;
        private readonly UserManager<AspnetRunUser> _userManager;

        public AspnetRunContextSeed(
            AspnetRunContext aspnetRunContext,
            UserManager<AspnetRunUser> userManager)
        {
            _aspnetRunContext = aspnetRunContext;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            // TODO: Only run this if using a real database
            // _aspnetRunContext.Database.Migrate();
            // _aspnetRunContext.Database.EnsureCreated();

            // users
            await SeedUsersAsync();
        }

        private async Task SeedUsersAsync()
        {
            var user = await _userManager.FindByEmailAsync("aspnetrun@outlook.com");
            if (user == null)
            {
                user = new AspnetRunUser
                {
                    FirstName = "Aspnet",
                    LastName = "Run",
                    Email = "aspnetrun@outlook.com",
                    UserName = "aspnetrun"
                };

                var result = await _userManager.CreateAsync(user, "P@ssw0rd!");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create user in Seeding");
                }

                _aspnetRunContext.Entry(user).State = EntityState.Unchanged;
            }
        }
    }
}
