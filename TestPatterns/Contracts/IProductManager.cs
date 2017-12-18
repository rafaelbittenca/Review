using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Contracts
{
    public interface IProductManager
    {
		decimal GetBonus();
		decimal GetTax();
	}
}
