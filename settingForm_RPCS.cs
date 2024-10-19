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
            this.mainForm = mainForm; // mainForm_RPCS의 인스턴스를 받아옴
        }

        // 턴테이블 각도 변경
        // float로 소숫점까지 입력 가능하게 했는데, 필요한가?
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
        // 턴테이블 각도 변경 버튼 클릭 이벤트
        private void btn_turnTableAngle_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tb_turnTableAngle.Text, out float angle))
            {
                mainForm.turntable.GetTurnTableAngle(angle);
            }
            else
            {
                MessageBox.Show("올바른 각도 값을 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // EXIT 버튼 클릭 이벤트
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_speedup_Click(object sender, EventArgs e)
        {

            int speed = 0;
            object value = null;

            //if (mobjSysVarMCR_override.GetValue(ref value))
            //{
            //    speed = Convert.ToInt32(value);

            //    if (speed < 5)
            //    {
            //        mobjSysVarMCR_override.SetValue(5);
            //    }
            //    else
            //    {
            //        mobjSysVarMCR_override.SetValue(speed + 5);
            //    }
            /*
            if (speed == 1)
            {
                mobjSysVarMCR_override.SetValue(speed + 4);

            }
            else
                mobjSysVarMCR_override.SetValue(speed + 5);
            */
            mainForm.movement_log.AppendText("Speed Up\r\n");

            //txtResult.AppendText(Convert.ToString(speed));
        }

        private void btn_speeddown_Click(object sender, EventArgs e)
        {
            int speed = 0;
            object value = null;
            //if (mobjSysVarMCR_override.GetValue(ref value))
            //{
            //    speed = Convert.ToInt32(value);
            //    if (speed < 5)
            //    {
            //        mobjSysVarMCR_override.SetValue(5);
            //    }
            //    else
            //    {
            //        mobjSysVarMCR_override.SetValue(speed - 5);
            //    }
                // mobjSysVarMCR_override.SetValue(speed - 5);
              
                mainForm.movement_log.AppendText("Speed Down\r\n");

                // txtResult.AppendText(Convert.ToString(speed));
            }
        }
    }

