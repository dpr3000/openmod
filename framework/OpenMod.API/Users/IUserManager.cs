﻿using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using OpenMod.API.Ioc;

namespace OpenMod.API.Users
{
    [Service]
    public interface IUserManager
    {
        IReadOnlyCollection<IUserProvider> UserProviders { get; }

        Task<IReadOnlyCollection<IUser>> GetUsersAsync(string type);

        Task<IUser> FindUserAsync(string type, string searchString, UserSearchMode searchMode);

        Task BroadcastAsync(string message);

        Task BroadcastAsync(string userType, string message);

        Task BroadcastAsync(string message, Color color);

        Task BroadcastAsync(string userType, string message, Color color);
    }
}