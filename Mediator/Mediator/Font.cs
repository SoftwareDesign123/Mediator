using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Font : BaseWidget
    {
        public void ChangeFont()
        {
            Console.WriteLine("Arial");
            Console.WriteLine("Calibri");
            Console.WriteLine("Times new roman\n");

            Console.WriteLine("Type the desired font");
            string s = Console.ReadLine();

            if (s == "calibri") 
            {
                this._dialogBox.Notify(this, "calibri");
                Console.WriteLine("You have chosen calibri\n");
            }

            else if (s  == "arial")
            {
                Console.WriteLine("You have chosen arial\n");
                this._dialogBox.Notify(this, "arial");
            }

            else if (s  == "times new roman")
            {
                this._dialogBox.Notify(this, "times new roman");
                Console.WriteLine("You have chosen times new roman\n");
            }

            else
            {
                Console.WriteLine("Not correct font type, close application and try again");
            }

        }
    }
}
