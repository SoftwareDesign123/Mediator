using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Mediator
{
    public interface IDialogBox
    {
        void Notify(object sender, string ev);
    }
}
