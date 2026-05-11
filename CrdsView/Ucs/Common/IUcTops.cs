using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrdsView.Ucs.Common
{
    public interface IUcTops
    {
        void SetTops(List<Control> controls);
    }

    public interface IUcTop
    {
        void SetTop(Control control);
    }
}
