using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAEFCore22.AppCode.Interface.Repos
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
