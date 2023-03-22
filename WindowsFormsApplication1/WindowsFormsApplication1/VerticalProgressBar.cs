using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class VerticalProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams 
        {
            get
            {
                System.Windows.Forms.CreateParams cp = base.CreateParams;
                cp.Style = cp.Style ^ 0x04;
                return cp;
            }
        }
    }
}
