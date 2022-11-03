using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Domain.Models
{
    public abstract class EntityBase
    {
        public string Id { get; set; }
        public DateTime CreateAt { get; set; }
    }
}