using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys
{
    public class Product : Entity<Guid>
    {
        public decimal DefaultPrice { get; private set; }
        public IReadOnlyList<Trait> Traits { get; private set; }
    }
}
