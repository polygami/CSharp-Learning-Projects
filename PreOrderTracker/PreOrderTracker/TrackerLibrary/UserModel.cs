using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class UserModel
    {
        /// <summary>
        /// The first name(s) of the user.
        /// </summary>
        public string FirstNames { get; set; }
        /// <summary>
        /// The last name(s) of the user.
        /// </summary>
        public string LastNames { get; set; }
        /// <summary>
        /// The user's email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The user-defined currency, which all other currencies will  show the exchange rate between.
        /// </summary>
        public CurrencyModel BaseCurrency { get; set; }
        /// <summary>
        /// A list of all pre-orders.
        /// </summary>
        public List<PreOrderModel> PreOrders = new List<PreOrderModel>();
        /// <summary>
        /// All of the user-defined product categories.
        /// </summary>
        public List<CategoryModel> Categories = new List<CategoryModel>();
        /// <summary>
        /// All of the user-defined currencies.
        /// </summary>
        public List<CurrencyModel> Currencies = new List<CurrencyModel>();
        /// <summary>
        /// All of the user-defined retailers.
        /// </summary>
        public List<RetailerModel> Retailers = new List<RetailerModel>();
    }
}

