using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Business.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit();
        public UserRepository UserRepository { get; set; }
    }
}
