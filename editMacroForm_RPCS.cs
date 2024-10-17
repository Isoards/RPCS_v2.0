using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RPCS
{
    public partial class editMacroForm_RPCS : Form
    {
        public editMacroForm_RPCS()
        {
            InitializeComponent();
        }

        private void editMacroForm_Load(object sender, EventArgs e)
        {
            this.Text = "Macro";
            int i = 0;
            if (File.Exists("Macro.txt"))
            {
                string[] lines = File.ReadAllLines("Macro.txt");
                if (lines.Length == 0)
                {
                    MessageBox.Show("파일이 비어 있습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                foreach (string line in lines)
                {
                    string[] posArr = line.Split(' ');
                    if (posArr.Length < 7)
                    {
                        MessageBox.Show("파일 형식이 올바르지 않습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    switch (i)
                    {
                        case 0:
                            SetMacroTextBoxes(tb_macro1, tb_setX_macro1, tb_setY_macro1, tb_setZ_macro1, tb_setW_macro1, tb_setP_macro1, tb_setR_macro1, posArr);
                            break;
                        case 1:
                            SetMacroTextBoxes(tb_macro2, tb_setX_macro2, tb_setY_macro2, tb_setZ_macro2, tb_setW_macro2, tb_setP_macro2, tb_setR_macro2, posArr);
                            break;
                        case 2:
                            SetMacroTextBoxes(tb_macro3, tb_setX_macro3, tb_setY_macro3, tb_setZ_macro3, tb_setW_macro3, tb_setP_macro3, tb_setR_macro3, posArr);
                            break;
                        case 3:
                            SetMacroTextBoxes(tb_macro4, tb_setX_macro4, tb_setY_macro4, tb_setZ_macro4, tb_setW_macro4, tb_setP_macro4, tb_setR_macro4, posArr);
                            break;
                    }
                    i++;
                    if (i > 3) break;
                }
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SetMacroTextBoxes(TextBox macro, TextBox x, TextBox y, TextBox z, TextBox w, TextBox p, TextBox r, string[] values)
        {
            macro.Text = values[0];
            x.Text = values[1];
            y.Text = values[2];
            z.Text = values[3];
            w.Text = values[4];
            p.Text = values[5];
            r.Text = values[6];
        }

        public void FileWrite()
        {
            string text = BuildMacroText(tb_macro1, tb_setX_macro1, tb_setY_macro1, tb_setZ_macro1, tb_setW_macro1, tb_setP_macro1, tb_setR_macro1) + "\r\n" +
                          BuildMacroText(tb_macro2, tb_setX_macro2, tb_setY_macro2, tb_setZ_macro2, tb_setW_macro2, tb_setP_macro2, tb_setR_macro2) + "\r\n" +
                          BuildMacroText(tb_macro3, tb_setX_macro3, tb_setY_macro3, tb_setZ_macro3, tb_setW_macro3, tb_setP_macro3, tb_setR_macro3) + "\r\n" +
                          BuildMacroText(tb_macro4, tb_setX_macro4, tb_setY_macro4, tb_setZ_macro4, tb_setW_macro4, tb_setP_macro4, tb_setR_macro4);

            using (StreamWriter macro = new StreamWriter("Macro.txt", false, Encoding.Default))
            {
                macro.WriteLine(text);
            }

            MessageBox.Show("매크로 저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string BuildMacroText(TextBox macro, TextBox x, TextBox y, TextBox z, TextBox w, TextBox p, TextBox r)
        {
            return $"{macro.Text} {x.Text} {y.Text} {z.Text} {w.Text} {p.Text} {r.Text}";
        }

        // 숫자만 입력할 수 있도록 제한하는 코드인데 필요한가?....
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
        private void btn_save1_Click(object sender, EventArgs e)
        {
            mainForm_RPCS mainForm = new mainForm_RPCS();
            FileWrite();
            mainForm.Macro_setting();
        }

        private void btn_save2_Click(object sender, EventArgs e)
        {
            mainForm_RPCS mainForm = new mainForm_RPCS();
            FileWrite();
            mainForm.Macro_setting();
        }

        private void btn_save3_Click(object sender, EventArgs e)
        {
            mainForm_RPCS mainForm = new mainForm_RPCS();
            FileWrite();
            mainForm.Macro_setting();
        }

        private void btn_save4_Click(object sender, EventArgs e)
        {
            mainForm_RPCS mainForm = new mainForm_RPCS();
            FileWrite();
            mainForm.Macro_setting();
        }
        // EXIT 버튼 클릭 시 창 닫기
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
