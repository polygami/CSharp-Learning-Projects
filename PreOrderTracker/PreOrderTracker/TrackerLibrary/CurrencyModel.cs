using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class CurrencyModel
    {
        /// <summary>
        /// <para>The <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</see> code for this currency.</para>
        /// <para><em>e.g. EUR</em></para>
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// <para>The currency's symbol.</para>
        /// <para><em>e.g. €</em></para>
        /// </summary>
        public char Symbol { get; set; }
        /// <summary>
        /// <para>Determine's whether the symbol will be displayed on the left (<em>e.g. $100</em>) or right (<em>100€</em>)</para>
        /// </summary>
        public bool IsSymbolLeftAligned { get; set; }
        /// <summary>
        /// The value of the currency relative to the base currency, defined in the user settings.
        /// </summary>
        public decimal ExchangeRate { get; set; }
    }
}
