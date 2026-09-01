using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_7_KeyedService;

public class IndiaTaxCalculator : ITaxCalculator
{
    public int Calculate()
    {
        return 30;
    }
}
