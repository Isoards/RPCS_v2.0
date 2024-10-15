using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPCS
{
    public partial class mainForm_RPCS : Form
    {
        bool chk;
        private editMacroForm_RPCS editMacroForm;
        private settingForm_RPCS settingForm;
        private DateTime startTime;
        private Timer operationTimer;
        public string HostName;
        private const string cnstApp = "Robot Host Connection";
        private const string cnstSection = "Settings";

        private Turntable turntable;
        private TurntableDisplay turntableDisplay;
        public mainForm_RPCS()
        {
            InitializeComponent();
            SetupTurntable(); // TurntableAngle 설정
            SetupOperationHoursTimer(); // Operation Hours 설정
            updateTimer.Start();
        }
        // Operation Hours 설정을 위한 Timer 설정
        private void SetupOperationHoursTimer()
        {
            startTime = DateTime.Now;

            operationTimer = new Timer();
            operationTimer.Interval = 1000; // 1초마다 업데이트
            operationTimer.Tick += OperationTimer_Tick;
            operationTimer.Start();
        }
        private void OperationTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            int hours = (int)elapsedTime.TotalHours;
            int minutes = elapsedTime.Minutes;
            int seconds = elapsedTime.Seconds;

            lblOperationHours.Text = $"{hours:00} : {minutes:00} : {seconds:00}";
        }

        private void SetupTurntable()
        {
            turntable = new Turntable();
            turntableDisplay = new TurntableDisplay(turntable)
            {
                Dock = DockStyle.Fill
            };
            this.turntable_section.Controls.Add(this.turntableDisplay);

        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            turntable.GetTurnTableAngle();
            //lblTurnTableAngle.Text = $"{turntable.Angle:F2}°";
            lblTurnTableAngle.InvokeIfNeeded(() => lblTurnTableAngle.Text = $"{turntable.Angle:F0}°");
            //tbTurnTableAngle.InvokeIfNeeded(() => tbTurnTableAngle.Text = $"{turntable.Angle:F0}°");
            turntableDisplay.Invalidate();
        }

        private void msubInit()
        {
            bool blnRes = false;
            string strHost = null;
            int lngTmp = 0;


            try
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                // make FRRJIF.Core object
                //mobjCore = new FRRJIf.Core();
                // Get by get_DataTalbe method and register to DataTable object by methods
                // You need to set data table before connecting.
                //mobjDataTable = mobjCore.get_DataTable();//return DataTable object
                {
                    // (기존 DataTable 설정 코드는 그대로 유지)
                }

                // IP 주소 입력 팝업창
                if (string.IsNullOrEmpty(HostName))
                {
                    strHost = Interaction.GetSetting(cnstApp, cnstSection, "HostName", "");
                    strHost = Interaction.InputBox("Please input robot host name", cnstApp, strHost, 0, 0);
                    if (string.IsNullOrEmpty(strHost))
                    {
                        MessageBox.Show("Host name not entered, program termination.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Environment.Exit(0);
                    }
                    Interaction.SaveSetting(cnstApp, cnstSection, "HostName", strHost);
                    HostName = strHost;
                }
                else
                {
                    strHost = HostName;
                }

                // 입력된 IP 주소 확인 메시지
                MessageBox.Show($"Host name: {strHost}\nconnecting...", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //get time out value
                lngTmp = Convert.ToInt32(Interaction.GetSetting(cnstApp, cnstSection, "TimeOut", "-1"));

                /*
                // 실제 연결 부분 (주석 처리)
                if (lngTmp > 0)
                    mobjCore.set_TimeOutValue(lngTmp);
                blnRes = mobjCore.Connect(strHost);//success returns true, fails returns false

                if (blnRes == false)
                {
                    msubDisconnected();
                }
                else
                {
                    msubConnected();
                    setFlag(ref IsPaintStart);
                    // 스레드 타이머 시작 약 60Hz 
                    renderTimer = new System.Threading.Timer(ThreadingTimerCallback, null, 0, 17);
                }
                */

                // 연결 성공으로 가정
                blnRes = true;
                if (blnRes)
                {
                    MessageBox.Show("Connect success");
                }
                else
                {
                    msubDisconnected();
                }

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Environment.Exit(0);
            }
        }
        private void msubDisconnected()
        {
            MessageBox.Show("Connect error");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msubInit();
            tgMod.FlatAppearance.BorderSize = 0;
        }
        // 모드 선택 버튼 클릭 이벤트
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

            //// mod1 폼 열기
            //mod1Form newMod1Form = new mod1Form();
            //newMod1Form.Show();
        }
        // PROGRAM EXIT 버튼 클릭 이벤트
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Edit Macro 버튼 클릭 이벤트
        private void btn_editMacro_Click(object sender, EventArgs e)
        {
            if (editMacroForm == null || editMacroForm.IsDisposed) // 폼이 열려있지 않을 경우
            {
                editMacroForm = new editMacroForm_RPCS();
                editMacroForm.Owner = this;
                editMacroForm.FormClosed += (s, args) => editMacroForm = null;
                editMacroForm.StartPosition = FormStartPosition.CenterParent;
                editMacroForm.Show(this);
            }
            else
            {
                editMacroForm.Activate();
            }
        }

        // Setting 버튼 클릭 이벤트
        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (settingForm == null || settingForm.IsDisposed) // 폼이 열려있지 않을 경우
            {
                settingForm = new settingForm_RPCS();
                settingForm.Owner = this;
                settingForm.FormClosed += (s, args) => settingForm = null;
                settingForm.StartPosition = FormStartPosition.CenterParent;
                settingForm.Show(this);
            }
            else
            {
                settingForm.Activate();
            }
        }
        // LOAD 버튼 클릭 이벤트
        private void btn_load_Click(object sender, EventArgs e)
        {
            //if (checkFlag(IsStopClicked))
            //{
            //    clearFlag(ref IsStopClicked);
            //}

            //if (mobjNumReg.SetValue(2, 1) == false) // (index, value), if R[2] = 1 then TP program stop
            //{
            //    MessageBox.Show("SetNumReg Int Error");
            //}

            int i = 0;
            int progLine = 0; //Load 되어진 ListView 상의 text File 행 수
            int division = 0; // division = ((progLine / 1000) + 1)

            //currentline = 0;

            //lv_pos.FullRowSelect = true;
            lv_pos.Rows.Clear();

            // 파일을 열기 위한 팝업 생성
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    /* 자동으로 닫히는 메시지박스 생성 */
                    //_waitBox.ShowWaitForm();

                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string line = null;

                        while ((line = sr.ReadLine()) != null) //text 파일의 줄수를 먼저 센다.
                        {
                            progLine++;
                        }

                        ////프로그레스바 설정
                        //progressBar1.Minimum = 0;
                        //progressBar1.Maximum = progLine;
                        //progressBar1.Value = 0;
                        //tb_progLine.Text = progLine.ToString();

                    }
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] posArr = line.Split(' ');
                            // DataGridView에 데이터를 추가
                            lv_pos.Rows.Add(posArr);
                            //string line = null;
                            //int setline = 0;
                            //i = 0;

                            //division = ((progLine / 1000) + 1); //progline을 1000개 단위로 자른다
                            //while ((line = sr.ReadLine()) != null)
                            //{
                            //    string[] posArr = line.Split(' ');
                            //    // ListView에 데이터를 추가
                            //    //lv_pos.Items.Add(new System.Windows.Forms.ListViewItem(new string[] { posArr[0], posArr[1], posArr[2], posArr[3], posArr[4], posArr[5], posArr[6], posArr[7], posArr[8], posArr[9] }));

                            //}
                        }
                    }
                    ///* ToolPath 객체 초기화 */
                    //toolpath = new ToolPath(ofd.FileName);
                    //toolpath.fillToolPathBuffer();

                    ///* Load 클릭 플래그 셋 */
                    //setFlag(ref IsLoadClicked);

                    ///* 자동으로 닫히는 메시지박스 파괴 */
                    //_waitBox.CloseForm();
                }
            }
        }

        // EMERGENCY STOP 버튼 클릭 이벤트
        private void btn_emergencyStop_Click(object sender, EventArgs e)
        {
            //mobjSysVarimstp.SetValue(1);   //Immediately Stop From UOP
        }

        private void DataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && lv_pos.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string cellValue = lv_pos.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (cellValue.Equals("Progress", StringComparison.OrdinalIgnoreCase))
                {
                    lv_pos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
    }
    public static class ControlExtensions
    {
        /*다른 스레드에서 UI 구성요소 접근 시 필요하다면 Invoke 그렇지 않다면 그냥 실행*/
        public static void InvokeIfNeeded(this System.Windows.Forms.Control control, Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }
    }
}