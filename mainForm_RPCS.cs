using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace RPCS
{
    public partial class mainForm_RPCS : Form
    {
        bool chk;
        private editMacroForm_RPCS editMacroForm;
        private settingForm_RPCS settingForm;
        private DateTime startTime;
        private System.Windows.Forms.Timer operationTimer;
        public string HostName;
        private const string cnstApp = "Robot Host Connection"; // 팝업창 제목
        private const string cnstSection = "Settings";
        private float[] originPos = new float[6]; // UF 텍스트 박스의 문자열이 실수로 변환되어 저장되는 버퍼


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

            operationTimer = new System.Windows.Forms.Timer();
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
            //mainForm_v1 newMod1Form = new mainForm_v1();
            //newMod1Form.Show();
            //this.Close();
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
        /* worker 스레드 선언 */
        Thread Read_thread; // TPP 로 부터 데이터 수신 스레드
        Thread Run_init_thread; // Run 누르면 초기화작업하는 스레드
        Thread Run_process_thread; // 초기화 작업 후 Run 작업이 진행되는 스레드
        private void cmdRun_Click(object per, EventArgs e)
        {
            /* 지나온 경로 clear */
            //if (checkFlag(IsStopClicked))
            //{
            //    clearFlag(ref IsStopClicked);
            //}

            ///* 이미 RUN이 실행중인지 체크 */
            //if (checkFlag(IsRunProcess))
            //{
            //    MessageBox.Show("Run 이 이미 실행중입니다", "message");
            //    return;
            //}

            ///* PMAC이 연결되어 있는지 체크 */
            //if (checkFlag(IsPMAC_Connected) == false)
            //{
            //    MessageBox.Show("PMAC 이 연결되지 않았습니다", "message");
            //    return;
            //}

            ///* 해당 모션이 선택되었는지 체크 */
            //if (Motion == 0)
            //{
            //    MessageBox.Show("모션을 선택해 주세요.", "message");
            //    return;
            //}

            //setFlag(ref IsRunProcess);

            ///* 스레드 스타트 대기 상태 진입 */
            //Run_init_thread = new Thread(new ThreadStart(Run_initialize));
            //Run_process_thread = new Thread(new ThreadStart(Run_process));

            ///* 초기화 스레드 시작 */
            //Run_init_thread.Start();
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
        // Set Origin 버튼 클릭 이벤트
        private void btn_setOrigin_Click(object sender, EventArgs e)
        {


            //setFlag(ref IsSetOriginClicked);

            originPos[0] = float.Parse(tb_xposUF.Text);
            originPos[1] = float.Parse(tb_yposUF.Text);
            originPos[2] = float.Parse(tb_zposUF.Text);
            originPos[3] = float.Parse(tb_wUF.Text);
            originPos[4] = float.Parse(tb_pUF.Text);
            originPos[5] = float.Parse(tb_rUF.Text);

            lbl_xOrigin.Text = tb_xposUF.Text;
            lbl_yOrigin.Text = tb_yposUF.Text;
            lbl_zOrigin.Text = tb_zposUF.Text;
            lbl_wOrigin.Text = tb_wUF.Text;
            lbl_pOrigin.Text = tb_pUF.Text;
            lbl_rOrigin.Text = tb_rUF.Text;

            //string oriStr = "Current Origin : ";
            //oriStr += tb_xposUF.Text + ", " + tb_yposUF.Text + ", " + tb_zposUF.Text + ", " + tb_wUF.Text + ", " + tb_pUF.Text + ", " + tb_rUF.Text;
            //label_origin.Text = oriStr;

            tb_setX.Text = "0";
            tb_setY.Text = "0";
            tb_setZ.Text = "0";
            tb_setW.Text = "0";
            tb_setP.Text = "0";
            tb_setR.Text = "0";

            movement_log.AppendText("Set Origin" + Environment.NewLine);
        }
        // Init Origin 버튼 클릭 이벤트
        private void btn_initOrigin_Click(object sender, EventArgs e)
        {
            //clearFlag(ref IsSetOriginClicked);

            //originPos[0] = 0;     // x
            //originPos[1] = 0;     // y
            //originPos[2] = 0;     // z
            //originPos[3] = 0;     // w
            //originPos[4] = 0;     // p
            //originPos[5] = 0;     // r

            lbl_xOrigin.Text = "00";
            lbl_yOrigin.Text = "00";
            lbl_zOrigin.Text = "00";
            lbl_wOrigin.Text = "00";
            lbl_pOrigin.Text = "00";
            lbl_rOrigin.Text = "00";

            
            movement_log.AppendText("Init Origin" + Environment.NewLine);
        }

        //World Position을 읽어오는 코드
        //private void readPosition()
        //{
        //    while (true)
        //    {
        //        if (AllThreadStop)
        //            return;
        //        Array xyzwpr = new float[9]; // xyzwpr should have 9 elements(robot 6 axes + 3 extended axes)
        //        Array config = new short[7]; // configuration of current position
        //        Array joint = new float[9]; // joint shoud have 9 elements(robot 6 axes + 3 extended axes)
        //        double[] xyzVal = new double[6]; // xyzwpr buffer
        //        short intUF = 0; // UF:User coordinate system number
        //        short intUT = 0; // UT:Tool coordinate system number
        //        short intValidC = 0; // when current position do not have valid Cartesian values, ValidC will have 0
        //        short intValidJ = 0; // when current position do not have valid joint values, ValicJ will have 0
        //        int i; // 단지 for문의 인덱스 역할
        //        String[] StringArray = new string[3]; // 문자열 배열 선언
        //        String speed = null;
        //        object value = null;

        //        /* Read data values from robot to refresh data
        //         * Data of DataTable object are refreshed
        //         * If you want to get the latest robot data, you need to call this method*/
        //        mobjDataTable.Refresh();

        //        //------------------------------------//
        //        // Get PR[] value, X,Y,Z,W,P,R,Config //
        //        // and apply Origin Position.         //
        //        //------------------------------------//        
        //        //로봇으로 부터 유저프레임 좌표 가져오기
        //        if (mobjCurPosUF.GetValue(ref xyzwpr, ref config, ref joint, ref intUF, ref intUT, ref intValidC, ref intValidJ))
        //        {
        //            for (i = 0; i < 6; i++)
        //            {
        //                xyzVal[i] = Convert.ToDouble(xyzwpr.GetValue(i));
        //            }
        //            //---------------------------------//
        //            // Update Current Position Textbox /
        //            //---------------------------------//
        //            tb_xposUF.InvokeIfNeeded(() => tb_xposUF.Text = String.Format("{0:F3}", xyzVal[0] - originPos[0]));
        //            tb_yposUF.InvokeIfNeeded(() => tb_yposUF.Text = String.Format("{0:F3}", xyzVal[1] - originPos[1]));
        //            tb_zposUF.InvokeIfNeeded(() => tb_zposUF.Text = String.Format("{0:F3}", xyzVal[2] - originPos[2]));
        //            tb_wUF.InvokeIfNeeded(() => tb_wUF.Text = String.Format("{0:F3}", xyzVal[3] - originPos[3]));
        //            tb_pUF.InvokeIfNeeded(() => tb_pUF.Text = String.Format("{0:F3}", xyzVal[4] - originPos[4]));
        //            tb_rUF.InvokeIfNeeded(() => tb_rUF.Text = String.Format("{0:F3}", xyzVal[5] - originPos[5]));

        //            tb_xposUF.InvokeIfNeeded(() => StringArray[0] = tb_xposUF.Text);
        //            tb_yposUF.InvokeIfNeeded(() => StringArray[1] = tb_yposUF.Text);
        //            tb_zposUF.InvokeIfNeeded(() => StringArray[2] = tb_zposUF.Text);
        //        }
        //        //로봇으로 부터 월드프레임 좌표 가져오기
        //        if (mobjCurPos.GetValue(ref xyzwpr, ref config, ref joint, ref intUF, ref intUT, ref intValidC, ref intValidJ))
        //        {
        //            for (i = 0; i < 6; i++)
        //            {
        //                xyzVal[i] = Convert.ToDouble(xyzwpr.GetValue(i));
        //            }
        //            //---------------------------------//
        //            // Update Current Position Textbox //
        //            //---------------------------------//
        //            tb_xpos.InvokeIfNeeded(() => tb_xpos.Text = String.Format("{0:F3}", xyzVal[0]));
        //            tb_ypos.InvokeIfNeeded(() => tb_ypos.Text = String.Format("{0:F3}", xyzVal[1]));
        //            tb_zpos.InvokeIfNeeded(() => tb_zpos.Text = String.Format("{0:F3}", xyzVal[2]));
        //            tb_w.InvokeIfNeeded(() => tb_w.Text = String.Format("{0:F3}", xyzVal[3]));
        //            tb_p.InvokeIfNeeded(() => tb_p.Text = String.Format("{0:F3}", xyzVal[4]));
        //            tb_r.InvokeIfNeeded(() => tb_r.Text = String.Format("{0:F3}", xyzVal[5]));
        //        }
        //        if (mobjSysVarMCR_override.GetValue(ref value))
        //        {
        //            speed = Convert.ToString(value);
        //            if (Convert.ToInt32(speed) < 5)
        //            {
        //                mobjSysVarMCR_override.SetValue(5);
        //                label_Speed.InvokeIfNeeded(() => label_Speed.Text = "5");
        //            }
        //            else
        //            {
        //                label_Speed.InvokeIfNeeded(() => label_Speed.Text = speed);
        //            }
        //            /*
        //            if (speed == "1" || speed == "0")
        //                label_Speed.InvokeIfNeeded(() => label_Speed.Text = "FINE");
        //            else
        //                label_Speed.InvokeIfNeeded(() => label_Speed.Text = speed);
        //             */
        //            // txtResult.AppendText(speed);
        //        }
        //        Thread.Sleep(20);
        //    }
        //}

        // 플래그 셋, 클리어, 체크 메소드
        public void setFlag(ref bool flag)
        {
            if (flag == false)
            {
                flag = true;
            }
        }

        public void clearFlag(ref bool flag)
        {
            if (flag == true)
            {
                flag = false;
            }
        }

        public bool checkFlag(bool flag)
        {
            if (flag == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {

            //setFlag(ref IsStopClicked);

            ///* (index, value), if R[2] = 1 then TP program stop */
            //if (mobjNumReg.SetValue(2, 1) == false)
            //{
            //    MessageBox.Show("SetNumReg Int Error");
            //}

            ////강제로 Flag 클리어            
            //IsRunProcess = false;

            Thread.Sleep(1000);
            // Run 관련 thread 종료
            Run_init_thread.Abort();
            Run_process_thread.Abort();

            /* STOP PMAC */
            lbl_M1.InvokeIfNeeded(() => lbl_M1.Text = "0.0");
            lbl_M2.InvokeIfNeeded(() => lbl_M2.Text = "0.0");
            //CommandOrQuery(1);
            //CommandOrQuery(9);
            //CommandOrQuery(3);
            //CommandOrQuery(9);

            //currentline = 0;
            //txtResult.Clear();
            movement_log.AppendText(tb1.Text + " Stop\r\n");
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