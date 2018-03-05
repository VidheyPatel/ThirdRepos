using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private bool discount2;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
<<<<<<< HEAD
<<<<<<< HEAD
        const decimal mdecDiscount = 5.0m;
        const decimal mdecBackStall = 15.0m;
=======
        const decimal mdecDiscount = 10.0m;
=======
        const decimal mdecDiscount = 5.0m;
        
>>>>>>> feat1.2_discount_type
        const decimal mdecChild = 10.0m;
>>>>>>> feat1.2_discount_type

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private bool Discount2
        {
            get { return discount2; }
            set { discount2 = value; }
        }

         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice
    public TicketPrice(int section, int quantity, bool discount, bool discount2)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
            Discount2 = discount2;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
<<<<<<< HEAD
                case 4:
<<<<<<< HEAD
                    mPrice = mdecBackStall;
=======
                    mPrice = mdecChild;
>>>>>>> feat1.2_discount_type
                    break;
=======
               
>>>>>>> feat1.2_discount_type
         }
         if (discount)
         { mPrice -= mdecDiscount; }
         else if (discount2)
            {
                mPrice -= mdecChild;
            }

         AmountDue = mPrice * quantity;

     }
    }
}
