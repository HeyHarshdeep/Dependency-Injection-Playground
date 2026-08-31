using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_6_Conditional_DependencyInjection;

public class Purchase
{
    private readonly Func<UserLocation, ITaxCalculator> _accessor;

    public Purchase(Func<UserLocation, ITaxCalculator> accessor)
    {
        _accessor = accessor;
    }

    public int CheckOut(UserLocation location)
    {
        var tax = _accessor(location);
        var total = tax.Calculate() + 100;
        return total;
    }
}
