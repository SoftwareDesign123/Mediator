using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Type : BaseWidget
    {
        public void ChangeType()
        {

            Console.WriteLine("Bold");
            Console.WriteLine("Emphazised");
            Console.WriteLine("Italic");

            Console.WriteLine("Type the font type\n");

            string f = Console.ReadLine();

            if (f == "bold")
            {
                this._dialogBox.Notify(this, "bold");
                Console.WriteLine("You have chosen bold \n");
            }

            else if (f == "emphazised")
            {
                this._dialogBox.Notify(this, "emphazised");
                Console.WriteLine("You have chosen emphazised\n");
            }

            else if (f ==  "italic")
            {
                this._dialogBox.Notify(this, "italic");
                Console.WriteLine("You have chosen italic\n");
            }

            else
            {
                Console.WriteLine("Not an available font type, close application and try again");
            }

        }
        
    }
}
