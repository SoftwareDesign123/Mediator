using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class BaseWidget
    {
        protected IDialogBox _dialogBox;
        public BaseWidget(IDialogBox dialogBox = null)
        {
            this._dialogBox = dialogBox;
        }

        public void SetDialogBox(IDialogBox dialogBox)
        {
            this._dialogBox = dialogBox;
        }
    }
}
