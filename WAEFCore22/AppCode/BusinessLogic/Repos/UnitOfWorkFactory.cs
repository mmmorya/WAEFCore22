using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAEFCore22.AppCode.Connections;
using WAEFCore22.AppCode.Interface.Repos;

namespace WAEFCore22.AppCode.BusinessLogic.Repos
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private AppDbContext _AppDbContext;

        public UnitOfWorkFactory(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(_AppDbContext);
        }
    }
}
