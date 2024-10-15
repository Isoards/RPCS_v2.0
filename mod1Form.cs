using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPCS
{
    public partial class mod1Form : Form
    {
        bool chk = false;
        public mod1Form()
        {
            InitializeComponent();
        }

        private void tgMod_Click(object sender, EventArgs e)
        {
            if (chk != true)
            {
                tgMod.BackgroundImage = Properties.Resources.button_mod2;
                chk = true;
            }
            else
            {
                tgMod.BackgroundImage = Properties.Resources.button_mod1;
                chk = false;
            }

            this.Close();

            // mod1 폼 열기
            mainForm_RPCS newMod2Form = new mainForm_RPCS();
            newMod2Form.Show();
        }
    }
}
