﻿
using System;
namespace Microsoft.AspNet.SignalR.Infrastructure
{
    public class PrincipalUserIdProvider : IUserIdProvider
    {
        public string GetUserId(IRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (request.User != null && request.User.Identity != null)
            {
                return request.User.Identity.Name;
            }

            return null;
        }
    }
}
