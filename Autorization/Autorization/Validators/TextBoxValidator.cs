using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorization.Validators
{
    static class TextBoxValidator
    {
        public static bool IsTextEmpty(TextBox tb)
            {
                if (tb == null)
                    throw new ArgumentException();

                if (tb.Text.Length == 0)
                {
                    tb.BackColor = Color.LightPink;
                    return true;
                }
                else
                {
                    tb.BackColor = Color.White;
                    return false;
                }
            }
    }
}
