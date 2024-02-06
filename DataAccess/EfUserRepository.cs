using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;
using DataAccess.Config;
using DataAccess.Interfaces;
using Entities;

namespace DataAccess;

public class EfUserRepository : EfRepositoryBase<User, long, DefaultContext>, IUserRepository
{
    public EfUserRepository(DefaultContext context) : base(context)
    {
    }
}
