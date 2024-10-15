using System;
using System.Windows.Forms;

namespace RPCS
{
    public partial class editMacroForm_RPCS : Form
    {
        public editMacroForm_RPCS()
        {
            InitializeComponent();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tb_setX_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                // Store cursor position
                int cursorPosition = tb.SelectionStart;

                // Remove any non-digit characters except for a leading minus sign
                string newText = System.Text.RegularExpressions.Regex.Replace(tb.Text, @"[^-\d]", "");

                // Ensure only one leading minus sign
                if (newText.StartsWith("--"))
                {
                    newText = newText.Substring(1);
                }
                else if (newText.Contains("-") && !newText.StartsWith("-"))
                {
                    newText = newText.Replace("-", "");
                }

                int maxLength = newText.StartsWith("-") ? 4 : 3;
                if (newText.Length > maxLength)
                {
                    newText = newText.Substring(0, maxLength);
                }

                // Ensure the value is within -999 to 999
                if (int.TryParse(newText, out int value))
                {
                    if (value < -999)
                        newText = "-999";
                    else if (value > 999)
                        newText = "999";
                }

                // Update text if it has changed
                if (tb.Text != newText)
                {
                    tb.Text = newText;

                    // Adjust cursor position
                    cursorPosition = Math.Max(0, Math.Min(cursorPosition, tb.Text.Length));
                    tb.SelectionStart = cursorPosition;
                }

            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_macro1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
