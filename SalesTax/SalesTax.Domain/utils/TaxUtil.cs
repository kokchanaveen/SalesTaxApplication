using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.utils
{
    public class TaxUtil
    {
        private const decimal ROUND_OFF = 0.05M;

        /// <summary>
        /// Rounds off a decimal value to the nearest 0.05
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundOff(decimal value)
        {


            return (int)(value / ROUND_OFF + 0.5M) * 0.05M;
        }

        public static decimal Truncate(decimal value)
        {
            string result = value.ToString("N2"); ;
            return decimal.Parse(result);
        }

           }
}
