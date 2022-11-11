using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class DialogBox : IDialogBox
    {
        private Font _font;
        private Type _type;

        public DialogBox(Font font, Type type)
        {
            this._font = font;
            this._font.SetDialogBox(this);
            this._type = type;
            this._type.SetDialogBox(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "arial" || ev == "calibri" || ev == "times new roman")
            {
                Console.WriteLine("pick a type");
                this._type.ChangeType();

            }
        }
     }
}
