﻿using Core.DataAccess;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.DataAccess.Repositories.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        List<OperationClaim> GetOperationClaims(User user);
    }
}
