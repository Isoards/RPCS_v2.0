using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public Turntable turntable { get; private set; }
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
            //turntable.GetTurnTableAngle();
            //lblTurnTableAngle.Text = $"{turntable.Angle:F2}°";
            lblTurnTableAngle.InvokeIfNeeded(() => lblTurnTableAngle.Text = $"{turntable.Angle:F0}°");
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

            // mod1 폼 열기
            //mod1Form newMod1Form = new mod1Form();
            //newMod1Form.Show();
        }
        // PROGRAM EXIT 버튼 클릭 이벤트
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "프로그램을 종료하시겠습니까?",  
                "종료 확인",                     
                MessageBoxButtons.YesNo,         
                MessageBoxIcon.Question          
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                settingForm = new settingForm_RPCS(this);
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
        // 매크로 설정 관련 이벤트
        public void Macro_setting()
        {
            int i = 0;
            if (File.Exists("Macro.txt"))
            {
                StreamReader macro = new StreamReader("Macro.txt");
                String line;
                while ((line = macro.ReadLine()) != null)
                {
                    string[] posArr = line.Split(' ');
                    if (i == 0)
                    {
                        btn_macro1.Text = posArr[0];
                    }
                    else if (i == 1)
                    {
                        btn_macro2.Text = posArr[0];
                    }
                    else if (i == 2)
                    {
                        btn_macro3.Text = posArr[0];
                    }
                    else if (i == 3)
                    {
                        btn_macro4.Text = posArr[0];
                    }
                    i++;
                }
                macro.Close();
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Macro(int number)
        {
            if (!File.Exists("Macro.txt"))
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines("Macro.txt");

            if (lines.Length <= number)
            {
                MessageBox.Show($"매크로 {number + 1}에 대한 데이터가 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] posArr = lines[number].Split(' ');

            if (posArr.Length < 7)
            {
                MessageBox.Show($"매크로 {number + 1}의 데이터 형식이 올바르지 않습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Array sngArray = new float[6];
                Array intConfig = new short[7];

                for (int i = 0; i < 6; i++)
                {
                    sngArray.SetValue(float.Parse(posArr[i + 1]), i);
                }

                short[] configValues = { 1, 0, 1, 1, 0, 0, 0 };
                for (int i = 0; i < 7; i++)
                {
                    intConfig.SetValue(configValues[i], i);
                }

                // mobjPosRegXyzwpr.SetValueXyzwpr(4, ref sngArray, ref intConfig);
                // mobjPosRegXyzwpr.Update();

                movement_log.AppendText($"\r\n{posArr[0]} Robot Moved || X:{posArr[1]}, Y:{posArr[2]}, Z:{posArr[3]} " +
                    $"|| W:{posArr[4]}, P:{posArr[5]}, R:{posArr[6]}");
            }
            catch (FormatException)
            {
                MessageBox.Show($"매크로 {number + 1}의 데이터 형식이 올바르지 않습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 기존 코드
        //private void Macro(int number)
        //{
        //    int i = 0;
        //    if (File.Exists("Macro.txt"))
        //    {
        //        StreamReader macro = new StreamReader("Macro.txt");
        //        String line;
        //        while ((line = macro.ReadLine()) != null)
        //        {
        //            string[] posArr = line.Split(' ');
        //            if (i == number)
        //            {
        //                Array sngArray = new float[6];
        //                Array intConfig = new short[7];
        //                //sngArray.SetValue(float.Parse(posArr[1]) + originPos[0], 0);//RoboGuide에서 할때
        //                sngArray.SetValue(float.Parse(posArr[1]), 0);
        //                sngArray.SetValue(float.Parse(posArr[2]), 1);
        //                sngArray.SetValue(float.Parse(posArr[3]), 2);
        //                sngArray.SetValue(float.Parse(posArr[4]), 3);
        //                sngArray.SetValue(float.Parse(posArr[5]), 4);
        //                sngArray.SetValue(float.Parse(posArr[6]), 5);

        //                intConfig.SetValue((short)1, 0);
        //                intConfig.SetValue((short)0, 1);
        //                intConfig.SetValue((short)1, 2);
        //                intConfig.SetValue((short)1, 3);
        //                intConfig.SetValue((short)0, 4);
        //                intConfig.SetValue((short)0, 5);
        //                intConfig.SetValue((short)0, 6);

        //                //mobjPosReg.SetValueXyzwpr(4, ref sngArray, ref intConfig, 1, 1);
        //                //mobjPosRegXyzwpr.SetValueXyzwpr(4, ref sngArray, ref intConfig);
        //                //mobjPosRegXyzwpr.Update();

        //                int intVal = 0;
        //                string strVal;
        //                string str_filename = "GOTO";

        //                //strVal = "";
        //                //mobjSysVarCustName.SetValue(strVal); //$CUST_START = "" : blank, no program
        //                //mobjSysVarRMT_MASTER.SetValue(intVal); // $RMT_MASTER=0 : for remote control
        //                //mobjSysVarCustStart.SetValue(intVal); // $CUST_START = 0 : for stop program

        //                //strVal = str_filename;
        //                //mobjSysVarCustName.SetValue(strVal);
        //                //intVal = 0;
        //                //mobjSysVarRMT_MASTER.SetValue(intVal);
        //                //intVal = 1;
        //                //mobjSysVarCustStart.SetValue(intVal);
        //                movement_log.AppendText("\r\n" + posArr[0] + " Robot Moved || X:" + posArr[1] + ", Y: " + posArr[2] + ", Z: " + posArr[3] +
        //                    " || W:" + posArr[4] + ", P: " + posArr[5] + ", R: " + posArr[6]);
        //            }
        //            i++;
        //        }
        //        macro.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void btn_macro1_Click(object sender, EventArgs e)
        {
            Macro(0);
        }

        private void btn_macro2_Click(object sender, EventArgs e)
        {
            Macro(1);
        }

        private void btn_macro3_Click(object sender, EventArgs e)
        {
            Macro(2);
        }

        private void btn_macro4_Click(object sender, EventArgs e)
        {
            Macro(3);
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
                else if (cellValue.Equals("Success", StringComparison.OrdinalIgnoreCase))
                {
                    lv_pos.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightGreen;

                }
            }
        }

        private void btn_goto_Click(object sender, EventArgs e)
        {
            Array sngArray = new float[6];
            Array intConfig = new short[7];

            /* (index, value), set R[2] = 0
             * if R[2] == 1, GOTO Complete*/
            //if (mobjNumReg.SetValue(2, 0) == false)
            //{
            //    MessageBox.Show("SetNumReg Int Error");
            //}
            //sngArray.SetValue(float.Parse(tb_setX.Text) + originPos[0], 0);
            //sngArray.SetValue(float.Parse(tb_setY.Text) + originPos[1], 1);
            //sngArray.SetValue(float.Parse(tb_setZ.Text) + originPos[2], 2);
            //sngArray.SetValue(float.Parse(tb_setW.Text) + originPos[3], 3);
            //sngArray.SetValue(float.Parse(tb_setP.Text) + originPos[4], 4);
            //sngArray.SetValue(float.Parse(tb_setR.Text) + originPos[5], 5);

            //intConfig.SetValue((short)1, 0);
            //intConfig.SetValue((short)0, 1);
            //intConfig.SetValue((short)1, 2);
            //intConfig.SetValue((short)1, 3);
            //intConfig.SetValue((short)0, 4);
            //intConfig.SetValue((short)0, 5);
            //intConfig.SetValue((short)0, 6);

            //mobjPosReg.SetValueXyzwpr(4, ref sngArray, ref intConfig, 1, 1);

            //mobjPosRegXyzwpr.SetValueXyzwpr(4, ref sngArray, ref intConfig);
            //mobjPosRegXyzwpr.Update();

            //int intVal = 0;
            //string strVal;
            //string str_filename = "GOTO";

            //strVal = "";
            //mobjSysVarCustName.SetValue(strVal); //$CUST_START = "" : blank, no program
            //mobjSysVarRMT_MASTER.SetValue(intVal); // $RMT_MASTER=0 : for remote control
            //mobjSysVarCustStart.SetValue(intVal); // $CUST_START = 0 : for stop program

            //strVal = str_filename;
            //mobjSysVarCustName.SetValue(strVal);
            //intVal = 0;
            //mobjSysVarRMT_MASTER.SetValue(intVal);
            //intVal = 1;
            //mobjSysVarCustStart.SetValue(intVal);

            movement_log.Clear();
            movement_log.AppendText("Goto : " + Environment.NewLine);
            movement_log.AppendText("X : " + tb_setX.Text + Environment.NewLine);
            movement_log.AppendText("Y : " + tb_setY.Text + Environment.NewLine);
            movement_log.AppendText("Z : " + tb_setZ.Text + Environment.NewLine);
            movement_log.AppendText("W : " + tb_setW.Text + Environment.NewLine);
            movement_log.AppendText("P : " + tb_setP.Text + Environment.NewLine);
            movement_log.AppendText("R : " + tb_setR.Text + Environment.NewLine);
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