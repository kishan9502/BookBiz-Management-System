using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System.Validation
{
    public class Validator
    {
        public static bool IsValidID(TextBox text)
        {
            int tempID;
            if ((text.TextLength != 5) || !((Int32.TryParse(text.Text, out tempID))))   // checking 5 degits
            {
                MessageBox.Show("Invalid ID, it must be a 5 digit number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text.Clear();
                text.Focus();
                return false;
            }
            return true;

        }
        public static bool IsValidYear(TextBox text)
        {
            int tempID;
            if ((text.TextLength != 4) || !((Int32.TryParse(text.Text, out tempID))))   // checking 5 degits
            {
                MessageBox.Show("Invalid Year, it must be a Year format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text.Clear();
                text.Focus();
                return false;
            }
            return true;

        }
    }
}
