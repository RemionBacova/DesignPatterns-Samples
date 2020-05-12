using Abstract_Factory_Drinks.Interfaces;
using Abstract_Factory_Drinks.Models.Drinks;
using Abstract_Factory_Drinks.Models.Drinks.Abstract;
using System;
using System.Collections.Generic;

namespace Abstract_Factory_Drinks
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IDrinks> pijet = new List<IDrinks>();
            for(int i = 0; i < 100; i++)
            {
                if(i %2 == 0)
                {
                    AlcoholicDrinks a = new AlcoholicDrinks();
                    a.Name = i.ToString();
                    for(int j = 0; j < 5; j++)
                    a.SetComponent(j.ToString());

                    pijet.Add(a);

                }
                else
                {
                    NonAlcoholicDrinks a = new NonAlcoholicDrinks();
                    a.Name = i.ToString();
                    for (int j = 0; j < 5; j++)
                        a.SetComponent(j.ToString());

                    pijet.Add(a);
                }
            }

            /// kemi bere menu
            /// 


            foreach(DrinksAbstract drinks in pijet)
            {
                Console.WriteLine("_______________________" + drinks.Name + "___________________");
                foreach(string s in drinks.GetComponenets())
                {
                    Console.WriteLine("------" + s + "-------");
                }
                Console.WriteLine("_______________________perfundoi receptura e " + drinks.Name + "___________________");
            }
        }
    }
}
