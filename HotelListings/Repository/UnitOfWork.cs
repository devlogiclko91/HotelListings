using HotelListings.Data;
using HotelListings.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListings.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseDataContext _context;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotles> _hotels;

        public UnitOfWork(DatabaseDataContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);
        public IGenericRepository<Hotles> Hotels => _hotels ??= new GenericRepository<Hotles>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
