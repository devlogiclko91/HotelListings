using HotelListings.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListings.IRepository
{
   public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotles> Hotels { get; }
        Task Save();
    }
}
