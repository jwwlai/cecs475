using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    // Fig. 12.11: IPayable.cs
    // IPayable interface declaration.
    public interface IPayable
    {
        decimal GetPaymentAmount(); // calculate payment; no implementation; default sealed and virtual
    } // end interface IPayable
}
