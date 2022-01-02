using Gymone.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Gymone.API.Repository
{
    public interface IUserRepository<TUser> : IDisposable where TUser : class
    {
        /// <summary>
        /// Get All users as Queryable collection
        /// </summary>
        /// <returns></returns>
        IQueryable<ApplicationWebUser> GetAllUsers();

        /// <summary>
        /// Get users by filter criteria
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        Task<List<ApplicationWebUser>> GetUsersByFilter(Expression<Func<ApplicationWebUser, bool>> exp);

        Task<List<ApplicationWebUser>> GetUsersByMatch(string term);

        /// <summary>
        ///     Gets the user identifier for the specified user/>.
        /// </summary>
        Task<string> GetUserIdAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Gets the user name for the specified user/>.
        /// </summary>
        Task<string> GetUserNameAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Sets the given <paramref name="userName" /> for the specified user/>.
        /// </summary>
        Task SetUserNameAsync(TUser user, string userName,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Gets the normalized user name for the specified user/>.
        /// </summary>
        Task<string> GetNormalizedUserNameAsync(TUser user,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Sets the given normalized name for the specified user/>.
        /// </summary>
        Task SetNormalizedUserNameAsync(TUser user, string normalizedName,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Creates the specified user/> in the user store.
        /// </summary>
        Task<IdentityResult> CreateAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Updates the specified user/> in the user store.
        /// </summary>
        Task<IdentityResult> UpdateAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Deletes the specified user/> from the user store.
        /// </summary>
        Task<IdentityResult> DeleteAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Finds and returns a user, if any, who has the specified userId/>.
        /// </summary>
        Task<TUser> FindByIdAsync(string userId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Finds and returns a user, if any, who has the specified normalized user name.
        /// </summary>
        Task<TUser> FindByNameAsync(string normalizedUserName,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}
