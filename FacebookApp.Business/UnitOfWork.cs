using FacebookApp.Business.Contracts;
using FacebookApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Business
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FacebookAppDbContext _DbContext;
        public UserRepository UserRepository { get ; set; }

        public UnitOfWork(FacebookAppDbContext context)
        {
            this._DbContext = context;
            this.UserRepository = new UserRepository(this._DbContext);
        }


        //public IMusicRepository Musics => _musicRepository = _musicRepository ?? new MusicRepository(_context);
        //public IArtistRepository Artists => _artistRepository = _artistRepository ?? new ArtistRepository(_context);

        public async Task Commit()
        {
            await this._DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._DbContext.Dispose();
        }
    }
}
