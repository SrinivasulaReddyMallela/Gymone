using Gymone.API.Context;
using Gymone.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Gymone.API.Repository
{
    public class UserRepository : IUserRepository<ApplicationWebUser>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        public UserRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }


        #region IUserRepository

        public Task<IdentityResult> CreateAsync(ApplicationWebUser user,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = _contextFactory.GetContext())
            {
                context.Users.Add(new ApplicationWebUser
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    NormalizedUserName = user.NormalizedUserName,
                    PasswordHash = user.PasswordHash
                });
                context.SaveChanges();
            }

            return Task.FromResult(IdentityResult.Success);
        }

        public IQueryable<ApplicationWebUser> GetAllUsers()
        {
            using (var context = _contextFactory.GetContext())
            {
                return context.Users.AsQueryable();
            }
        }

        public async Task<List<ApplicationWebUser>> GetUsersByFilter(Expression<Func<ApplicationWebUser, bool>> exp)
        {
            using (var context = _contextFactory.GetContext())
            {
                return await context.Users.Where(exp).ToListAsync();
            }
        }

        public async Task<List<ApplicationWebUser>> GetUsersByMatch(string term)
        {
            using (var context = _contextFactory.GetContext())
            {
                return await context.Users.Where(a => string.IsNullOrEmpty(term) ||
                                                      a.FirstName.Contains(term,
                                                          StringComparison.CurrentCultureIgnoreCase) ||
                                                      a.LastName.Contains(term,
                                                          StringComparison.CurrentCultureIgnoreCase) || a.Email.Contains(term, StringComparison.CurrentCultureIgnoreCase)).ToListAsync();
            }
        }

        public Task<IdentityResult> DeleteAsync(ApplicationWebUser user,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = _contextFactory.GetContext())
            {
                var appUser = context.Users.FirstOrDefault(u => u.Id == user.Id);

                if (appUser != null) context.Users.Remove(appUser);
                context.SaveChanges();
            }

            return Task.FromResult(IdentityResult.Success);
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        public Task<ApplicationWebUser> FindByIdAsync(string userId,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = _contextFactory.GetContext())
            {
                return Task.FromResult(context.Users.FirstOrDefault(u => u.Id == userId));
            }
        }

        public Task<ApplicationWebUser> FindByNameAsync(string normalizedUserName,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = _contextFactory.GetContext())
            {
                return Task.FromResult(context.Users.FirstOrDefault(u => u.NormalizedUserName == normalizedUserName));
            }
        }

        public Task<string> GetNormalizedUserNameAsync(ApplicationWebUser user,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(user.NormalizedUserName);
        }

        public Task<string> GetUserIdAsync(ApplicationWebUser user,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(user.Id);
        }

        public Task<string> GetUserNameAsync(ApplicationWebUser user,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(user.UserName);
        }

        public Task SetNormalizedUserNameAsync(ApplicationWebUser user, string normalizedName,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            user.NormalizedUserName = normalizedName;
            return Task.CompletedTask;
        }

        public Task SetUserNameAsync(ApplicationWebUser user, string userName,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            user.UserName = userName;
            return Task.CompletedTask;
        }

        public Task<IdentityResult> UpdateAsync(ApplicationWebUser user,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = _contextFactory.GetContext())
            {
                var appUser = context.Users.FirstOrDefault(u => u.Id == user.Id);

                if (appUser != null)
                {
                    appUser.NormalizedUserName = user.NormalizedUserName;
                    appUser.UserName = user.UserName;
                    appUser.Email = user.Email;
                    appUser.PasswordHash = user.PasswordHash;
                }
            }

            return Task.FromResult(IdentityResult.Success);
        }

        #endregion

        #region IUserPasswordStore

        public Task<bool> HasPasswordAsync(ApplicationWebUser user,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(user.PasswordHash != null);
        }

        public Task<string> GetPasswordHashAsync(ApplicationWebUser user,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task SetPasswordHashAsync(ApplicationWebUser user, string passwordHash,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            user.PasswordHash = passwordHash;
            return Task.CompletedTask;
        }

        #endregion
    }
}
