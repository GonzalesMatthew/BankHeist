using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHeist.Model
{
    class Bank
    {
        public int Difficulty { get; set; } = 400 + new Random().Next(-10, 10);
    }
}
