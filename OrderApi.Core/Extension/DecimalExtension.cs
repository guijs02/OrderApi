using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApi.Core.Extension
{
    public static class DecimalExtension
    {
        public static decimal RoundToTwoDecimalPlaces(this decimal value)
            => Math.Round(value, 2);
    }
}
