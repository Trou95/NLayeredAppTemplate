using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;
using Entities;

namespace DataAccess.Interfaces;

internal interface IUserRepository : IRepository<User, long>, IAsyncRepository<User, long>
{
}
