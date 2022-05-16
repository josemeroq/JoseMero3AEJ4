using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ4
{
    public class Numeros
    {
        private int num { set; get; }

        public Numeros(int num)
        {
            this.num = num;
        }

        public void numerohasta()
        {
           /* do
            {

                Console.WriteLine(--num);

            } while (num != 0); */

            if (num < 1)
            {
                do
                {

                    Console.WriteLine(++num);

                } while (num != 0);
            }
            else
            {
                do
                {

                    Console.WriteLine(--num);

                } while (num != 0);
            }
            Console.ReadKey();
        }
    }
}
