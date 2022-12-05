using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_and_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] items = new string[0];
            double[] prices = new double[0];
            float[] quantities = new float[0];
            bool receipt = true;
            int choice = 0, quantity = 0;
            double subTotal = 0, overAllTotal = 0;
            string moreItems;

            Console.WriteLine("                     Welcome to Zhaniel's Cyber City                 ");
            Console.WriteLine("           Please Inpute Your Full Name, Contact Number             ");
            Console.WriteLine("                 And Address To Access Our Shop                 ");
        //The User will input their information here.
       
            
                Console.Write("\nName: ");
                string UserName = Console.ReadLine();
            here:
            try
            {
                Console.Write("\nNumber: ");
                long UserNumber = Convert.ToInt64(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Invalid Input");
                    goto here;
            }
          
                Console.Write("\nAddress: ");
                string UserAddress = Console.ReadLine();

            Console.Clear();

            //Below is the Main Menu
            do
            {
                Console.WriteLine("                                                Welcome To The Main Menu               ");
                Console.WriteLine("                                                Please Pick Your Choices               ");
                Console.WriteLine("      CONSOLES                      PRICE                   CONTROLLERS                     PRICE                                ");
                Console.WriteLine("1.PS1 CONSOLE                       PHP 20,000.00      8.PS1 CONTROLLERS                    PHP 1,500.00 PER PAIR                ");
                Console.WriteLine("2.PS2 CONSOLE                       PHP 25,000.00      9.PS2 CONTROLLERS                    PHP 1,500.00 PER PAIR                ");
                Console.WriteLine("3.PS3 CONSOLE                       PHP 35,000.00      10.PS3 CONTROLLERS                   PHP 1,500.00 PER PAIR                ");
                Console.WriteLine("4.PS4 CONSOLE                       PHP 56,000.00      11.PS4 CONTROLLERS                   PHP 2,000.00 PER PAIR                ");
                Console.WriteLine("5.PS5 CONSOLE                       PHP 95,000.00      12.PS5 CONTROLLERS                   PHP 3,000.00 PER PAIR                ");
                Console.WriteLine("6.XBOX 360 CONSOLE                  PHP 39,000.00      13.XBOX CONTROLLERS                  PHP 1,600.00 PER PAIR                ");
                Console.WriteLine("7.NINTENDO SWITCH CONSOLE           PHP 28,000.00      14.NINTENDO SWITCH CONTROLLERS       PHP 1,200.00 PER PAIR                ");
                Console.WriteLine("\n");
                Console.WriteLine(" PS1 GAMES                 PRICE             PS2 GAMES              PRICE               PS3 GAMES                     PRICE           PS4 GAMES                PRICE                  ");
                Console.WriteLine("15.RESIDENT EVIL           PHP 1000.00       20.GOD OF WAR          PHP 1000.00         25.RED DEAD REDEPMTION        PHP 1000.00     30.GTA V                 PHP 1000.00            ");
                Console.WriteLine("16.METAL GEAR SOLID        PHP 1000.00       21.NFS: MOST WANTED    PHP 1000.00         26.FALLOUT 3                  PHP 1000.00     31.FIFA 22               PHP 1000.00            ");
                Console.WriteLine("17.CRASH TEAM RACING       PHP 1000.00       22.GTA III             PHP 1000.00         27.SKATE III                  PHP 1000.00     32.DAYS GONE             PHP 1000.00            ");
                Console.WriteLine("18.TOMB RAIDER             PHP 1000.00       23.THE SIMS 2          PHP 1000.00         28.COD: MW3                   PHP 1000.00     33.DYING LIGHT           PHP 1000.00            ");
                Console.WriteLine("19.DRAGON QUEST            PHP 1000.00       24.TEKKEN 5            PHP 1000.00         29.RESIDENT EVIL 6            PHP 1000.00     34.GHOST OF TSUSHIMA     PHP 1000.00            ");
                Console.WriteLine("\n");
                Console.WriteLine("PS5 GAMES                     PRICE             XBOX 360 GAMES           PRICE                 NINTENDO SWITCH GAMES           PRICE                                      ");
                Console.WriteLine("35.RESIDENT EVIL VILLAGE      PHP 1000.00       40.HALO: REACH           PHP 1000.00           45.SPLATOON 3                  PHP 1000.00                                ");
                Console.WriteLine("36.BATTLEFIELD 2042           PHP 1000.00       41.GEARS OF WAR          PHP 1000.00           46.MARIO PARTY SUPERSTARS      PHP 1000.00                                ");
                Console.WriteLine("37.MARVEL'S AVENGER           PHP 1000.00       42.BATTLEFIELD 3         PHP 1000.00           47.MARIO KART DELUXE 8         PHP 1000.00                                ");
                Console.WriteLine("38.STRAY                      PHP 1000.00       43.BORDERLANDS 2         PHP 1000.00           48.BAYONETTA                   PHP 1000.00                                ");
                Console.WriteLine("39.CYBERPUNK 2077             PHP 1000.00       44.DEAD ISLAND           PHP 1000.00           49.RING FIR ADVENTURE          PHP 1000.00                                ");
                //Here, the user will input their product and quantity
                Console.Write("PLEASE PICK A CHOICE: ");
                here2:
                try
                {
                    choice = Convert.ToInt16(Console.ReadLine());
                    if (choice >= 50)
                    {
                        Console.WriteLine("PLEASE INPUTE NUMBERS FROM 1-49 ONLY!");
                        goto here2;
                    }
                    else if (choice <= 0)
                    {
                        Console.WriteLine("PLEASE INPUTE NUMBERS FROM 1-49 ONLY!");
                        goto here2;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Please Use Numbers To Input");
                    goto here2;
                }
                Console.WriteLine("HOW MANY WOULD YOU LIKE TO BUY");
                here3:
                try
                {
                    quantity = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Use Numbers To Input");
                    goto here3;
                }

                String[] newItems = new string[0];
                double[] newPrices = new double[0];
                float[] newQuantities = new float[0];

                switch (choice)
                {
                    case 1:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS1 CONSOLE";
                        newPrices[prices.Length] = 20000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 2:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS2 CONSOLE";
                        newPrices[prices.Length] = 25000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 3:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS3 CONSOLE";
                        newPrices[prices.Length] = 35000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 4:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS4 CONSOLE";
                        newPrices[prices.Length] = 56000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 5:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS5 CONSOLE";
                        newPrices[prices.Length] = 95000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 6:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "XBOX 360 CONSOLE";
                        newPrices[prices.Length] = 39000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 7:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "NINTENDO SWITCH CONSOLE";
                        newPrices[prices.Length] = 28000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 8:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS1 CONTROLLER";
                        newPrices[prices.Length] = 1500.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 9:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS2 CONTROLLER";
                        newPrices[prices.Length] = 1500.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 10:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS3 CONTROLLER";
                        newPrices[prices.Length] = 1500.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 11:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS4 CONTROLLER";
                        newPrices[prices.Length] = 2000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 12:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "PS5 CONTROLLER";
                        newPrices[prices.Length] = 3000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 13:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "XBOX 350 CONTROLLER";
                        newPrices[prices.Length] = 1600.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 14:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "NINTENDO SWITCH CONTROLLER";
                        newPrices[prices.Length] = 1200.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 15:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "RESIDENT EVIL";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 16:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "METAL GEAR SOLID";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 17:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "CRASH TEAM RACING";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 18:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "TOMB RAIDER";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 19:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "DRAGON QUEST";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 20:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "GOD OF WAR";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 21:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "NFS: MOST WANTED";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 22:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "GTA III";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 23:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "THE SIMS 3";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 24:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "TEKKEN 5";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 25:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "RED DEAD REDEMPTION";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 26:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "FALLOUT 3";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 27:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "SKATE III";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 28:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "COD: MW3";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 29:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "RESIDENT EVIL 6";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 30:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "GTA V";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 31:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "FIFA 22";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 32:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "DAYS GONE";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 33:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "DYING LIGHT";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 34:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "GHOST OF TSUSHIMA";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 35:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "RESIDENT EVIL VILLAGE";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 36:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "BATTLEFIELD 2042";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 37:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "MARVEL'S AVENGER";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 38:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "STRAY";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 39:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "CYBERPUNK 2077";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 40:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "HALO: REACH";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 41:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "GEARS OF WAR";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 42:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "BATTLEFIELD 3";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 43:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "BORDERLANDS 2";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 44:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "DEAD ISLAND";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 45:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "SPLATOON 3";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 46:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "MARIO KART SUPERSTARS";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 47:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "MARIO KART DELUXE 8";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 48:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "BAYONETTA";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;

                    case 49:
                        newItems = new String[items.Length + 1];
                        newPrices = new double[prices.Length + 1];
                        newQuantities = new float[quantities.Length + 1];

                        for (int i = 0; i < items.Length; i++)
                        {
                            newItems[i] = items[i];
                            newPrices[i] = prices[i];
                            newQuantities[i] = quantities[i];
                        }
                        newItems[items.Length] = "RING FIR ADVENTURE";
                        newPrices[prices.Length] = 1000.00;
                        newQuantities[quantities.Length] = quantity;
                        subTotal += newPrices[prices.Length] + newQuantities[quantities.Length];
                        items = newItems;
                        prices = newPrices;
                        quantities = newQuantities;
                        break;
                }
                Console.Clear();
                Console.WriteLine("Do You Want To Add More Items?:Y/N");

                //Here, is the receipt
                moreItems = Console.ReadLine();
                receipt = (moreItems == "n") ? false : true;
            } while (receipt);
            
            Console.WriteLine("\t\t\tName  \t\t\tPrices  \t\t\tQuantities  \t\t\tTotal");

            for (int i = 0; i < items.Length; i++)
            {
                double Total = prices[i] * quantities[i];
                overAllTotal += Total;
                Console.WriteLine((i + 1) + "\t\t\t" + items[i] + "\t\t\t" + prices[i] + "\t\t\t" + quantities[i] + "\t\t\t" + Total);

            }
            Console.WriteLine("\t\t\tOverall Total \t\t\t {0}", overAllTotal);
            Console.WriteLine("Please Press Y To Confirm Your Order");
            string confirmation = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("       THANK YOU FOR CHOOOSING ZHANIEL'S CYBER CITY         ");
            Console.WriteLine("        YOUR ORDER WILL ARRIVE WITHIN 1 TO 2 DAYS         ");
            Console.WriteLine("              THANK YOU AND HAVE A NICE DAY         ");

            Console.ReadLine();
        }
    }
}
