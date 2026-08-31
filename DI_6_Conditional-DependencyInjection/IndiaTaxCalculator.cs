using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_6_Conditional_DependencyInjection
{
    public class IndiaTaxCalculator : ITaxCalculator
    {
        public int Calculate()
        {
            return 30;
        }
    }
}
