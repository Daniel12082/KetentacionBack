using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Aplication.Repository
{
    public class ItemRepository : GenericRepository<Item>, IItem
    {
        private readonly KetentacionBackendContext _context;

        public ItemRepository(KetentacionBackendContext context) : base(context)
        {
            _context = context;
        }
    }
}