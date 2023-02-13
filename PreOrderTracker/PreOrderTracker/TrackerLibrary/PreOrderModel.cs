using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class PreOrderModel
    {
        /// <summary>
        /// The name of the item that was ordered.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The price of the item.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The date that the item is scheduled to be paid.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The user-defined category that the item comes under.
        /// </summary>
        public CategoryModel Category { get; set; }

        /// <summary>
        /// The user-defined retailer that the order was made through.
        /// </summary>
        public RetailerModel MyProperty { get; set; }


        private int importance;

        /// <summary>
        /// <para>A value between 1-5 (inclusive), representing the importance of the item, with 1 being the lowest and 5 being the highest.</para>
        /// </summary>
        public int Importance
        {
            get { return importance; }
            set {
                if (value <= 1) importance = 1;
                else if (value >= 5) importance = 5;
                else importance = value; 
            }
        }

        /// <summary>
        /// The URL for the order, to allow easy cancellation or adjustment of the order.
        /// </summary>
        public string OrderURL { get; set; }

        /// <summary>
        /// Whether or not the order has been paid and received.
        /// </summary>
        public bool IsFulfilled { get; set; }
    }
}
