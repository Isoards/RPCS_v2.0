using System;
using System.Windows.Forms;

namespace RPCS
{
    public partial class settingForm_RPCS : Form
    {
        private mainForm_RPCS mainForm;
        public settingForm_RPCS(mainForm_RPCS mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tb_turnTableAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자, 백스페이스, 소수점만 허용
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // 소수점은 한 번만 입력 가능
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_turnTableAngle_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tb_turnTableAngle.Text, out float angle))
            {
                mainForm.turntable.GetTurnTableAngle(angle);
                //Turntable turntable = new Turntable();
                //turntable.GetTurnTableAngle(angle);
                //turntableDisplay.Invalidate();
                //mainForm_RPCS?.turntableDisplay?.Invalidate();
                // UpdateTimer_Tick(null, EventArgs.Empty);
                // 성공적으로 각도가 변경되었을 때의 처리
                // 예: UpdateTurntableDisplay(turntable.Angle);
            }
            else
            {
                MessageBox.Show("올바른 각도 값을 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
