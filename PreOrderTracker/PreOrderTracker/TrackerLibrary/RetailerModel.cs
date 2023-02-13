using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class RetailerModel
    {
        /// <summary>
        /// <para>The name of the retailer.</para>
        /// <para><em>e.g. Amazon.com</em></para>
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// <para>The user-defined currency, which the orders for this website will be paid in.</para>
        /// <para><em>e.g. USD ($)</em></para>
        /// </summary>
        public CurrencyModel Currency { get; set; }
        /// <summary>
        /// <para>The URL for the etailer's home page.</para>
        /// <para><em>e.g. https://www.amazon.com</em></para>
        /// </summary>
        public string URL { get; set; }
    }
}
