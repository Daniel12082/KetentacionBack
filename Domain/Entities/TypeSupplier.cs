using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TypeSupplier : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}