using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class program
    {
        static void Main(string[] args)
        {
            Font font = new Font();
            Type type = new Type();
            DialogBox dialogBox = new DialogBox(font, type);

            Console.WriteLine("Available font type: ");
            font.ChangeFont();

            
        }
    }
}
