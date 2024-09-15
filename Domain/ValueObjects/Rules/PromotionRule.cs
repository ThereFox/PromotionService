using CSharpFunctionalExtensions;
using Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public abstract class PromotionRuleBase
    {
        public abstract Result IsAvaliable(Product product);
    }
}
