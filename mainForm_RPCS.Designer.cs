using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace RPCS
{
    partial class mainForm_RPCS
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mod = new System.Windows.Forms.Panel();
            this.lblOperationHours = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tgMod = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.connection_status = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.turntable_section = new System.Windows.Forms.Panel();
            this.lblTurnTableAngle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.robot_state = new System.Windows.Forms.Panel();
            this.tbRobotPosition = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Panel();
            this.label_Speed = new System.Windows.Forms.Label();
            this.LBL_M2 = new System.Windows.Forms.Label();
            this.LBL_M1 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label77 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.target_position = new System.Windows.Forms.Panel();
            this.btn_editMacro = new System.Windows.Forms.Button();
            this.btn_goto = new System.Windows.Forms.Button();
            this.btn_macro4 = new System.Windows.Forms.Button();
            this.btn_macro3 = new System.Windows.Forms.Button();
            this.btn_macro2 = new System.Windows.Forms.Button();
            this.tb_setR = new System.Windows.Forms.TextBox();
            this.tb_setP = new System.Windows.Forms.TextBox();
            this.tb_setW = new System.Windows.Forms.TextBox();
            this.tb_setZ = new System.Windows.Forms.TextBox();
            this.tb_setY = new System.Windows.Forms.TextBox();
            this.tb_setX = new System.Windows.Forms.TextBox();
            this.btn_macro1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tb_r = new System.Windows.Forms.Label();
            this.tb_p = new System.Windows.Forms.Label();
            this.tb_w = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tb_zpos = new System.Windows.Forms.Label();
            this.tb_xpos = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_ypos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user_position = new System.Windows.Forms.Panel();
            this.tb_rUF = new System.Windows.Forms.TextBox();
            this.tb_pUF = new System.Windows.Forms.TextBox();
            this.tb_wUF = new System.Windows.Forms.TextBox();
            this.tb_zposUF = new System.Windows.Forms.TextBox();
            this.tb_yposUF = new System.Windows.Forms.TextBox();
            this.tb_xposUF = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_initOrigin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_setOrigin = new System.Windows.Forms.Button();
            this.batch = new System.Windows.Forms.Panel();
            this.lv_pos = new System.Windows.Forms.DataGridView();
            this.column_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.R4VAL = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.R3VAL = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.fixedSpeed = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdRun = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.batch_log = new System.Windows.Forms.TextBox();
            this.movement_log = new System.Windows.Forms.TextBox();
            this.btn_emergencyStop = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label36 = new System.Windows.Forms.Label();
            this.mod.SuspendLayout();
            this.connection_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.turntable_section.SuspendLayout();
            this.robot_state.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.state.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.target_position.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.user_position.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.batch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.White;
            this.mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mod.Controls.Add(this.lblOperationHours);
            this.mod.Controls.Add(this.label30);
            this.mod.Controls.Add(this.tgMod);
            this.mod.Controls.Add(this.label9);
            this.mod.Location = new System.Drawing.Point(80, 72);
            this.mod.Margin = new System.Windows.Forms.Padding(2);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(422, 136);
            this.mod.TabIndex = 0;
            // 
            // lblOperationHours
            // 
            this.lblOperationHours.AutoSize = true;
            this.lblOperationHours.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOperationHours.Location = new System.Drawing.Point(197, 91);
            this.lblOperationHours.Name = "lblOperationHours";
            this.lblOperationHours.Size = new System.Drawing.Size(128, 25);
            this.lblOperationHours.TabIndex = 13;
            this.lblOperationHours.Text = "00 : 00 : 00";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.Location = new System.Drawing.Point(12, 91);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(175, 25);
            this.label30.TabIndex = 12;
            this.label30.Text = "Operation Hours";
            // 
            // tgMod
            // 
            this.tgMod.BackgroundImage = global::RPCS.Properties.Resources.button_mod2;
            this.tgMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tgMod.Cursor = System.Windows.Forms.Cursors.Default;
            this.tgMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tgMod.Location = new System.Drawing.Point(47, 40);
            this.tgMod.Name = "tgMod";
            this.tgMod.Size = new System.Drawing.Size(328, 40);
            this.tgMod.TabIndex = 11;
            this.tgMod.UseVisualStyleBackColor = true;
            this.tgMod.Click += new System.EventHandler(this.tgMod_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Operation Mode";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 16;
            this.updateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // connection_status
            // 
            this.connection_status.BackColor = System.Drawing.Color.White;
            this.connection_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connection_status.Controls.Add(this.pictureBox10);
            this.connection_status.Controls.Add(this.pictureBox11);
            this.connection_status.Controls.Add(this.label60);
            this.connection_status.Controls.Add(this.label59);
            this.connection_status.Controls.Add(this.label34);
            this.connection_status.Controls.Add(this.btn_settings);
            this.connection_status.Controls.Add(this.button14);
            this.connection_status.Controls.Add(this.button13);
            this.connection_status.Controls.Add(this.label17);
            this.connection_status.Controls.Add(this.label16);
            this.connection_status.Controls.Add(this.label8);
            this.connection_status.Location = new System.Drawing.Point(527, 72);
            this.connection_status.Margin = new System.Windows.Forms.Padding(2);
            this.connection_status.Name = "connection_status";
            this.connection_status.Size = new System.Drawing.Size(421, 136);
            this.connection_status.TabIndex = 1;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::RPCS.Properties.Resources.red_dot;
            this.pictureBox10.Location = new System.Drawing.Point(83, 96);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(8, 8);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::RPCS.Properties.Resources.green_dot;
            this.pictureBox11.Location = new System.Drawing.Point(83, 53);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(8, 8);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 22;
            this.pictureBox11.TabStop = false;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(48)))));
            this.label60.Location = new System.Drawing.Point(93, 90);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(107, 20);
            this.label60.TabIndex = 21;
            this.label60.Text = "Disconnected";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label59.Location = new System.Drawing.Point(98, 46);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(87, 20);
            this.label59.TabIndex = 20;
            this.label59.Text = "Connected";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(210, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(145, 25);
            this.label34.TabIndex = 15;
            this.label34.Text = "Control Panel";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_settings.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(215, 102);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(202, 30);
            this.btn_settings.TabIndex = 14;
            this.btn_settings.Text = "PMAC, ROBOT SETTINGS";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.button14.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(215, 68);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(202, 30);
            this.button14.TabIndex = 13;
            this.button14.Text = "CONNECTION TEST";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.button13.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(215, 34);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(202, 30);
            this.button13.TabIndex = 12;
            this.button13.Text = "ROBOT CONNECT";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(10, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 23);
            this.label17.TabIndex = 11;
            this.label17.Text = "ROBOT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(10, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 23);
            this.label16.TabIndex = 10;
            this.label16.Text = "PMAC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Connection Status";
            // 
            // turntable_section
            // 
            this.turntable_section.BackColor = System.Drawing.Color.White;
            this.turntable_section.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turntable_section.Controls.Add(this.lblTurnTableAngle);
            this.turntable_section.Controls.Add(this.label10);
            this.turntable_section.Location = new System.Drawing.Point(80, 234);
            this.turntable_section.Margin = new System.Windows.Forms.Padding(2);
            this.turntable_section.Name = "turntable_section";
            this.turntable_section.Size = new System.Drawing.Size(422, 456);
            this.turntable_section.TabIndex = 2;
            // 
            // lblTurnTableAngle
            // 
            this.lblTurnTableAngle.AutoSize = true;
            this.lblTurnTableAngle.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTurnTableAngle.Location = new System.Drawing.Point(197, 398);
            this.lblTurnTableAngle.Name = "lblTurnTableAngle";
            this.lblTurnTableAngle.Size = new System.Drawing.Size(25, 25);
            this.lblTurnTableAngle.TabIndex = 13;
            this.lblTurnTableAngle.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "1 .TurnTable Angle";
            // 
            // robot_state
            // 
            this.robot_state.BackColor = System.Drawing.Color.White;
            this.robot_state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.robot_state.Controls.Add(this.tbRobotPosition);
            this.robot_state.Controls.Add(this.pictureBox2);
            this.robot_state.Controls.Add(this.label11);
            this.robot_state.Location = new System.Drawing.Point(526, 234);
            this.robot_state.Margin = new System.Windows.Forms.Padding(2);
            this.robot_state.Name = "robot_state";
            this.robot_state.Size = new System.Drawing.Size(422, 456);
            this.robot_state.TabIndex = 3;
            // 
            // tbRobotPosition
            // 
            this.tbRobotPosition.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRobotPosition.Location = new System.Drawing.Point(60, 397);
            this.tbRobotPosition.Name = "tbRobotPosition";
            this.tbRobotPosition.ReadOnly = true;
            this.tbRobotPosition.Size = new System.Drawing.Size(300, 33);
            this.tbRobotPosition.TabIndex = 13;
            this.tbRobotPosition.Text = "X : 0 | Y : 0 | Z : 0";
            this.tbRobotPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RPCS.Properties.Resources.robot_v3;
            this.pictureBox2.Location = new System.Drawing.Point(60, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "2. Robot Position";
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.White;
            this.state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.state.Controls.Add(this.label_Speed);
            this.state.Controls.Add(this.LBL_M2);
            this.state.Controls.Add(this.LBL_M1);
            this.state.Controls.Add(this.label53);
            this.state.Controls.Add(this.label54);
            this.state.Controls.Add(this.label55);
            this.state.Controls.Add(this.pictureBox9);
            this.state.Controls.Add(this.label77);
            this.state.Controls.Add(this.pictureBox8);
            this.state.Controls.Add(this.label74);
            this.state.Controls.Add(this.label75);
            this.state.Controls.Add(this.label76);
            this.state.Controls.Add(this.label6);
            this.state.Location = new System.Drawing.Point(80, 712);
            this.state.Margin = new System.Windows.Forms.Padding(2);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(422, 133);
            this.state.TabIndex = 4;
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Speed.Location = new System.Drawing.Point(379, 44);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(38, 25);
            this.label_Speed.TabIndex = 45;
            this.label_Speed.Text = "00";
            // 
            // LBL_M2
            // 
            this.LBL_M2.AutoSize = true;
            this.LBL_M2.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBL_M2.Location = new System.Drawing.Point(205, 44);
            this.LBL_M2.Name = "LBL_M2";
            this.LBL_M2.Size = new System.Drawing.Size(38, 25);
            this.LBL_M2.TabIndex = 44;
            this.LBL_M2.Text = "00";
            // 
            // LBL_M1
            // 
            this.LBL_M1.AutoSize = true;
            this.LBL_M1.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBL_M1.Location = new System.Drawing.Point(88, 44);
            this.LBL_M1.Name = "LBL_M1";
            this.LBL_M1.Size = new System.Drawing.Size(38, 25);
            this.LBL_M1.TabIndex = 43;
            this.LBL_M1.Text = "00";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label53.Location = new System.Drawing.Point(237, 44);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(146, 25);
            this.label53.TabIndex = 42;
            this.label53.Text = "ROBOT Speed";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label54.Location = new System.Drawing.Point(120, 44);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(91, 25);
            this.label54.TabIndex = 41;
            this.label54.Text = "M2 RPM";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label55.Location = new System.Drawing.Point(2, 44);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(88, 25);
            this.label55.TabIndex = 40;
            this.label55.Text = "M1 RPM";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::RPCS.Properties.Resources.yellow;
            this.pictureBox9.Location = new System.Drawing.Point(329, 102);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(8, 8);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 38;
            this.pictureBox9.TabStop = false;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label77.Location = new System.Drawing.Point(335, 94);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(72, 24);
            this.label77.TabIndex = 39;
            this.label77.Text = "Waiting";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::RPCS.Properties.Resources.green_dot;
            this.pictureBox8.Location = new System.Drawing.Point(125, 102);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(8, 8);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 36;
            this.pictureBox8.TabStop = false;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label74.Location = new System.Drawing.Point(12, 94);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(113, 24);
            this.label74.TabIndex = 34;
            this.label74.Text = "1.TurnTable";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label75.Location = new System.Drawing.Point(228, 94);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(92, 24);
            this.label75.TabIndex = 35;
            this.label75.Text = "2.ROBOT";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label76.Location = new System.Drawing.Point(134, 94);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(82, 24);
            this.label76.TabIndex = 37;
            this.label76.Text = "Running";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current State";
            // 
            // target_position
            // 
            this.target_position.BackColor = System.Drawing.Color.White;
            this.target_position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.target_position.Controls.Add(this.btn_editMacro);
            this.target_position.Controls.Add(this.btn_goto);
            this.target_position.Controls.Add(this.btn_macro4);
            this.target_position.Controls.Add(this.btn_macro3);
            this.target_position.Controls.Add(this.btn_macro2);
            this.target_position.Controls.Add(this.tb_setR);
            this.target_position.Controls.Add(this.tb_setP);
            this.target_position.Controls.Add(this.tb_setW);
            this.target_position.Controls.Add(this.tb_setZ);
            this.target_position.Controls.Add(this.tb_setY);
            this.target_position.Controls.Add(this.tb_setX);
            this.target_position.Controls.Add(this.btn_macro1);
            this.target_position.Controls.Add(this.pictureBox4);
            this.target_position.Controls.Add(this.label18);
            this.target_position.Controls.Add(this.label19);
            this.target_position.Controls.Add(this.label20);
            this.target_position.Controls.Add(this.label21);
            this.target_position.Controls.Add(this.label22);
            this.target_position.Controls.Add(this.label23);
            this.target_position.Controls.Add(this.label3);
            this.target_position.Location = new System.Drawing.Point(526, 712);
            this.target_position.Margin = new System.Windows.Forms.Padding(2);
            this.target_position.Name = "target_position";
            this.target_position.Size = new System.Drawing.Size(422, 133);
            this.target_position.TabIndex = 5;
            // 
            // btn_editMacro
            // 
            this.btn_editMacro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_editMacro.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editMacro.ForeColor = System.Drawing.Color.White;
            this.btn_editMacro.Location = new System.Drawing.Point(297, 8);
            this.btn_editMacro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editMacro.Name = "btn_editMacro";
            this.btn_editMacro.Size = new System.Drawing.Size(118, 35);
            this.btn_editMacro.TabIndex = 33;
            this.btn_editMacro.Text = "Edit Macro";
            this.btn_editMacro.UseVisualStyleBackColor = false;
            this.btn_editMacro.Click += new System.EventHandler(this.btn_editMacro_Click);
            // 
            // btn_goto
            // 
            this.btn_goto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_goto.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_goto.ForeColor = System.Drawing.Color.White;
            this.btn_goto.Location = new System.Drawing.Point(354, 94);
            this.btn_goto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_goto.Name = "btn_goto";
            this.btn_goto.Size = new System.Drawing.Size(64, 35);
            this.btn_goto.TabIndex = 31;
            this.btn_goto.Text = "Goto";
            this.btn_goto.UseVisualStyleBackColor = false;
            // 
            // btn_macro4
            // 
            this.btn_macro4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_macro4.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_macro4.ForeColor = System.Drawing.Color.White;
            this.btn_macro4.Location = new System.Drawing.Point(262, 94);
            this.btn_macro4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_macro4.Name = "btn_macro4";
            this.btn_macro4.Size = new System.Drawing.Size(92, 35);
            this.btn_macro4.TabIndex = 30;
            this.btn_macro4.Text = "Macro 4";
            this.btn_macro4.UseVisualStyleBackColor = false;
            // 
            // btn_macro3
            // 
            this.btn_macro3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_macro3.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_macro3.ForeColor = System.Drawing.Color.White;
            this.btn_macro3.Location = new System.Drawing.Point(174, 94);
            this.btn_macro3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_macro3.Name = "btn_macro3";
            this.btn_macro3.Size = new System.Drawing.Size(89, 35);
            this.btn_macro3.TabIndex = 29;
            this.btn_macro3.Text = "Macro 3";
            this.btn_macro3.UseVisualStyleBackColor = false;
            // 
            // btn_macro2
            // 
            this.btn_macro2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_macro2.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_macro2.ForeColor = System.Drawing.Color.White;
            this.btn_macro2.Location = new System.Drawing.Point(84, 94);
            this.btn_macro2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_macro2.Name = "btn_macro2";
            this.btn_macro2.Size = new System.Drawing.Size(91, 35);
            this.btn_macro2.TabIndex = 28;
            this.btn_macro2.Text = "Macro 2";
            this.btn_macro2.UseVisualStyleBackColor = false;
            // 
            // tb_setR
            // 
            this.tb_setR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_setR.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_setR.Location = new System.Drawing.Point(385, 51);
            this.tb_setR.Name = "tb_setR";
            this.tb_setR.Size = new System.Drawing.Size(30, 33);
            this.tb_setR.TabIndex = 27;
            // 
            // tb_setP
            // 
            this.tb_setP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_setP.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_setP.Location = new System.Drawing.Point(319, 51);
            this.tb_setP.Name = "tb_setP";
            this.tb_setP.Size = new System.Drawing.Size(30, 33);
            this.tb_setP.TabIndex = 26;
            // 
            // tb_setW
            // 
            this.tb_setW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_setW.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_setW.Location = new System.Drawing.Point(257, 51);
            this.tb_setW.Name = "tb_setW";
            this.tb_setW.Size = new System.Drawing.Size(30, 33);
            this.tb_setW.TabIndex = 25;
            // 
            // tb_setZ
            // 
            this.tb_setZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_setZ.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_setZ.Location = new System.Drawing.Point(166, 51);
            this.tb_setZ.Name = "tb_setZ";
            this.tb_setZ.Size = new System.Drawing.Size(30, 33);
            this.tb_setZ.TabIndex = 24;
            // 
            // tb_setY
            // 
            this.tb_setY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_setY.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_setY.Location = new System.Drawing.Point(101, 51);
            this.tb_setY.Name = "tb_setY";
            this.tb_setY.Size = new System.Drawing.Size(30, 33);
            this.tb_setY.TabIndex = 23;
            // 
            // tb_setX
            // 
            this.tb_setX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_setX.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_setX.Location = new System.Drawing.Point(41, 51);
            this.tb_setX.Name = "tb_setX";
            this.tb_setX.Size = new System.Drawing.Size(30, 33);
            this.tb_setX.TabIndex = 22;
            // 
            // btn_macro1
            // 
            this.btn_macro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_macro1.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_macro1.ForeColor = System.Drawing.Color.White;
            this.btn_macro1.Location = new System.Drawing.Point(0, 94);
            this.btn_macro1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_macro1.Name = "btn_macro1";
            this.btn_macro1.Size = new System.Drawing.Size(85, 35);
            this.btn_macro1.TabIndex = 21;
            this.btn_macro1.Text = "Macro 1";
            this.btn_macro1.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RPCS.Properties.Resources.Line;
            this.pictureBox4.Location = new System.Drawing.Point(204, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(3, 31);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(291, 51);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 32);
            this.label18.TabIndex = 19;
            this.label18.Text = "P";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(357, 51);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 32);
            this.label19.TabIndex = 18;
            this.label19.Text = "R";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label20.Location = new System.Drawing.Point(221, 51);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 32);
            this.label20.TabIndex = 17;
            this.label20.Text = "W";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label21.Location = new System.Drawing.Point(136, 51);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 32);
            this.label21.TabIndex = 16;
            this.label21.Text = "Z";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label22.Location = new System.Drawing.Point(74, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 32);
            this.label22.TabIndex = 15;
            this.label22.Text = "Y";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label23.Location = new System.Drawing.Point(12, 51);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 32);
            this.label23.TabIndex = 14;
            this.label23.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Target Position";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label71);
            this.panel1.Controls.Add(this.label70);
            this.panel1.Controls.Add(this.label69);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label68);
            this.panel1.Controls.Add(this.label67);
            this.panel1.Controls.Add(this.label46);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.tb_r);
            this.panel1.Controls.Add(this.tb_p);
            this.panel1.Controls.Add(this.tb_w);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.tb_zpos);
            this.panel1.Controls.Add(this.tb_xpos);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.tb_ypos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(80, 872);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 133);
            this.panel1.TabIndex = 6;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label71.Location = new System.Drawing.Point(382, 100);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(29, 19);
            this.label71.TabIndex = 61;
            this.label71.Text = "00";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label70.Location = new System.Drawing.Point(343, 101);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(29, 19);
            this.label70.TabIndex = 60;
            this.label70.Text = "00";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label69.Location = new System.Drawing.Point(304, 101);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(29, 19);
            this.label69.TabIndex = 59;
            this.label69.Text = "00";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(279, 101);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 20);
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label68.Location = new System.Drawing.Point(248, 101);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(29, 19);
            this.label68.TabIndex = 58;
            this.label68.Text = "00";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label67.Location = new System.Drawing.Point(208, 101);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(29, 19);
            this.label67.TabIndex = 57;
            this.label67.Text = "00";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label46.Location = new System.Drawing.Point(152, 101);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(19, 19);
            this.label46.TabIndex = 49;
            this.label46.Text = "X";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label66.Location = new System.Drawing.Point(168, 101);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(29, 19);
            this.label66.TabIndex = 56;
            this.label66.Text = "00";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label41.Location = new System.Drawing.Point(329, 100);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(19, 19);
            this.label41.TabIndex = 54;
            this.label41.Text = "P";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label42.Location = new System.Drawing.Point(368, 100);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(19, 19);
            this.label42.TabIndex = 53;
            this.label42.Text = "R";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label43.Location = new System.Drawing.Point(286, 101);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(24, 19);
            this.label43.TabIndex = 52;
            this.label43.Text = "W";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label44.Location = new System.Drawing.Point(232, 101);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(19, 19);
            this.label44.TabIndex = 51;
            this.label44.Text = "Z";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label45.Location = new System.Drawing.Point(192, 101);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(19, 19);
            this.label45.TabIndex = 50;
            this.label45.Text = "Y";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.Location = new System.Drawing.Point(5, 97);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(136, 23);
            this.label40.TabIndex = 48;
            this.label40.Text = "Current Origin";
            // 
            // tb_r
            // 
            this.tb_r.AutoSize = true;
            this.tb_r.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_r.Location = new System.Drawing.Point(364, 51);
            this.tb_r.Name = "tb_r";
            this.tb_r.Size = new System.Drawing.Size(41, 29);
            this.tb_r.TabIndex = 47;
            this.tb_r.Text = "00";
            // 
            // tb_p
            // 
            this.tb_p.AutoSize = true;
            this.tb_p.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_p.Location = new System.Drawing.Point(302, 51);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(41, 29);
            this.tb_p.TabIndex = 46;
            this.tb_p.Text = "00";
            // 
            // tb_w
            // 
            this.tb_w.AutoSize = true;
            this.tb_w.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_w.Location = new System.Drawing.Point(246, 51);
            this.tb_w.Name = "tb_w";
            this.tb_w.Size = new System.Drawing.Size(41, 29);
            this.tb_w.TabIndex = 45;
            this.tb_w.Text = "00";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(205, 50);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(3, 31);
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // tb_zpos
            // 
            this.tb_zpos.AutoSize = true;
            this.tb_zpos.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_zpos.Location = new System.Drawing.Point(166, 51);
            this.tb_zpos.Name = "tb_zpos";
            this.tb_zpos.Size = new System.Drawing.Size(41, 29);
            this.tb_zpos.TabIndex = 44;
            this.tb_zpos.Text = "00";
            // 
            // tb_xpos
            // 
            this.tb_xpos.AutoSize = true;
            this.tb_xpos.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_xpos.Location = new System.Drawing.Point(41, 51);
            this.tb_xpos.Name = "tb_xpos";
            this.tb_xpos.Size = new System.Drawing.Size(41, 29);
            this.tb_xpos.TabIndex = 42;
            this.tb_xpos.Text = "00";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label24.Location = new System.Drawing.Point(279, 50);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 31);
            this.label24.TabIndex = 40;
            this.label24.Text = "P";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label26.Location = new System.Drawing.Point(337, 50);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 31);
            this.label26.TabIndex = 39;
            this.label26.Text = "R";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label27.Location = new System.Drawing.Point(213, 50);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 31);
            this.label27.TabIndex = 38;
            this.label27.Text = "W";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(140, 50);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 31);
            this.label29.TabIndex = 37;
            this.label29.Text = "Z";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label25.Location = new System.Drawing.Point(78, 50);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 31);
            this.label25.TabIndex = 36;
            this.label25.Text = "Y";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label28.Location = new System.Drawing.Point(16, 50);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 31);
            this.label28.TabIndex = 35;
            this.label28.Text = "X";
            // 
            // tb_ypos
            // 
            this.tb_ypos.AutoSize = true;
            this.tb_ypos.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ypos.Location = new System.Drawing.Point(104, 51);
            this.tb_ypos.Name = "tb_ypos";
            this.tb_ypos.Size = new System.Drawing.Size(41, 29);
            this.tb_ypos.TabIndex = 43;
            this.tb_ypos.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "World Position";
            // 
            // user_position
            // 
            this.user_position.BackColor = System.Drawing.Color.White;
            this.user_position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_position.Controls.Add(this.tb_rUF);
            this.user_position.Controls.Add(this.tb_pUF);
            this.user_position.Controls.Add(this.tb_wUF);
            this.user_position.Controls.Add(this.tb_zposUF);
            this.user_position.Controls.Add(this.tb_yposUF);
            this.user_position.Controls.Add(this.tb_xposUF);
            this.user_position.Controls.Add(this.pictureBox3);
            this.user_position.Controls.Add(this.label15);
            this.user_position.Controls.Add(this.label14);
            this.user_position.Controls.Add(this.label13);
            this.user_position.Controls.Add(this.label12);
            this.user_position.Controls.Add(this.btn_initOrigin);
            this.user_position.Controls.Add(this.label4);
            this.user_position.Controls.Add(this.label2);
            this.user_position.Controls.Add(this.label1);
            this.user_position.Controls.Add(this.btn_setOrigin);
            this.user_position.Location = new System.Drawing.Point(526, 872);
            this.user_position.Margin = new System.Windows.Forms.Padding(2);
            this.user_position.Name = "user_position";
            this.user_position.Size = new System.Drawing.Size(422, 133);
            this.user_position.TabIndex = 7;
            // 
            // tb_rUF
            // 
            this.tb_rUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_rUF.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_rUF.Location = new System.Drawing.Point(385, 51);
            this.tb_rUF.Name = "tb_rUF";
            this.tb_rUF.Size = new System.Drawing.Size(30, 33);
            this.tb_rUF.TabIndex = 33;
            // 
            // tb_pUF
            // 
            this.tb_pUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_pUF.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_pUF.Location = new System.Drawing.Point(319, 51);
            this.tb_pUF.Name = "tb_pUF";
            this.tb_pUF.Size = new System.Drawing.Size(30, 33);
            this.tb_pUF.TabIndex = 32;
            // 
            // tb_wUF
            // 
            this.tb_wUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_wUF.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_wUF.Location = new System.Drawing.Point(257, 51);
            this.tb_wUF.Name = "tb_wUF";
            this.tb_wUF.Size = new System.Drawing.Size(30, 33);
            this.tb_wUF.TabIndex = 31;
            // 
            // tb_zposUF
            // 
            this.tb_zposUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_zposUF.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_zposUF.Location = new System.Drawing.Point(166, 51);
            this.tb_zposUF.Name = "tb_zposUF";
            this.tb_zposUF.Size = new System.Drawing.Size(30, 33);
            this.tb_zposUF.TabIndex = 30;
            // 
            // tb_yposUF
            // 
            this.tb_yposUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_yposUF.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_yposUF.Location = new System.Drawing.Point(101, 51);
            this.tb_yposUF.Name = "tb_yposUF";
            this.tb_yposUF.Size = new System.Drawing.Size(30, 33);
            this.tb_yposUF.TabIndex = 29;
            // 
            // tb_xposUF
            // 
            this.tb_xposUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tb_xposUF.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_xposUF.Location = new System.Drawing.Point(41, 51);
            this.tb_xposUF.Name = "tb_xposUF";
            this.tb_xposUF.Size = new System.Drawing.Size(30, 33);
            this.tb_xposUF.TabIndex = 28;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RPCS.Properties.Resources.Line;
            this.pictureBox3.Location = new System.Drawing.Point(204, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(3, 31);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(291, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 32);
            this.label15.TabIndex = 12;
            this.label15.Text = "P";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(357, 51);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 32);
            this.label14.TabIndex = 11;
            this.label14.Text = "R";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(221, 51);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 32);
            this.label13.TabIndex = 10;
            this.label13.Text = "W";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(136, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 32);
            this.label12.TabIndex = 9;
            this.label12.Text = "Z";
            // 
            // btn_initOrigin
            // 
            this.btn_initOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_initOrigin.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_initOrigin.ForeColor = System.Drawing.Color.White;
            this.btn_initOrigin.Location = new System.Drawing.Point(313, 93);
            this.btn_initOrigin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_initOrigin.Name = "btn_initOrigin";
            this.btn_initOrigin.Size = new System.Drawing.Size(105, 35);
            this.btn_initOrigin.TabIndex = 8;
            this.btn_initOrigin.Text = "Init Origin";
            this.btn_initOrigin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(74, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // btn_setOrigin
            // 
            this.btn_setOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_setOrigin.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_setOrigin.ForeColor = System.Drawing.Color.White;
            this.btn_setOrigin.Location = new System.Drawing.Point(204, 93);
            this.btn_setOrigin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_setOrigin.Name = "btn_setOrigin";
            this.btn_setOrigin.Size = new System.Drawing.Size(105, 35);
            this.btn_setOrigin.TabIndex = 3;
            this.btn_setOrigin.Text = "Set Origin";
            this.btn_setOrigin.UseVisualStyleBackColor = false;
            // 
            // batch
            // 
            this.batch.BackColor = System.Drawing.Color.White;
            this.batch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batch.Controls.Add(this.lv_pos);
            this.batch.Controls.Add(this.progressBar1);
            this.batch.Controls.Add(this.label65);
            this.batch.Controls.Add(this.label64);
            this.batch.Controls.Add(this.label63);
            this.batch.Controls.Add(this.pictureBox7);
            this.batch.Controls.Add(this.label62);
            this.batch.Controls.Add(this.label61);
            this.batch.Controls.Add(this.panel2);
            this.batch.Controls.Add(this.label7);
            this.batch.Location = new System.Drawing.Point(972, 72);
            this.batch.Margin = new System.Windows.Forms.Padding(2);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(868, 614);
            this.batch.TabIndex = 8;
            // 
            // lv_pos
            // 
            this.lv_pos.AllowUserToAddRows = false;
            this.lv_pos.AllowUserToDeleteRows = false;
            this.lv_pos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lv_pos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lv_pos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lv_pos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_state,
            this.column_f,
            this.column_t,
            this.column_x,
            this.column_y,
            this.column_z,
            this.column_w,
            this.column_p,
            this.column_r,
            this.column_m,
            this.column_n});
            this.lv_pos.EnableHeadersVisualStyles = false;
            this.lv_pos.Location = new System.Drawing.Point(17, 46);
            this.lv_pos.Name = "lv_pos";
            this.lv_pos.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Pretendard SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv_pos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.lv_pos.RowTemplate.Height = 23;
            this.lv_pos.Size = new System.Drawing.Size(830, 375);
            this.lv_pos.TabIndex = 43;
            // 
            // column_state
            // 
            this.column_state.HeaderText = "State";
            this.column_state.MinimumWidth = 4;
            this.column_state.Name = "column_state";
            this.column_state.ReadOnly = true;
            // 
            // column_f
            // 
            this.column_f.HeaderText = "F";
            this.column_f.Name = "column_f";
            this.column_f.ReadOnly = true;
            // 
            // column_t
            // 
            this.column_t.HeaderText = "T";
            this.column_t.Name = "column_t";
            this.column_t.ReadOnly = true;
            // 
            // column_x
            // 
            this.column_x.HeaderText = "X";
            this.column_x.Name = "column_x";
            this.column_x.ReadOnly = true;
            // 
            // column_y
            // 
            this.column_y.HeaderText = "Y";
            this.column_y.Name = "column_y";
            this.column_y.ReadOnly = true;
            // 
            // column_z
            // 
            this.column_z.HeaderText = "Z";
            this.column_z.Name = "column_z";
            this.column_z.ReadOnly = true;
            // 
            // column_w
            // 
            this.column_w.HeaderText = "W";
            this.column_w.Name = "column_w";
            this.column_w.ReadOnly = true;
            // 
            // column_p
            // 
            this.column_p.HeaderText = "P";
            this.column_p.Name = "column_p";
            this.column_p.ReadOnly = true;
            // 
            // column_r
            // 
            this.column_r.HeaderText = "R";
            this.column_r.Name = "column_r";
            this.column_r.ReadOnly = true;
            // 
            // column_m
            // 
            this.column_m.HeaderText = "M";
            this.column_m.Name = "column_m";
            this.column_m.ReadOnly = true;
            // 
            // column_n
            // 
            this.column_n.HeaderText = "N";
            this.column_n.Name = "column_n";
            this.column_n.ReadOnly = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(242, 441);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 30);
            this.progressBar1.TabIndex = 42;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label65.Location = new System.Drawing.Point(739, 440);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(30, 32);
            this.label65.TabIndex = 41;
            this.label65.Text = "0";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label64.Location = new System.Drawing.Point(765, 440);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(74, 32);
            this.label64.TabIndex = 40;
            this.label64.Text = "/ 100";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label63.Location = new System.Drawing.Point(520, 440);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(219, 32);
            this.label63.TabIndex = 39;
            this.label63.Text = "Line in Progress :";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(507, 440);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 31);
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label62.Location = new System.Drawing.Point(446, 440);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(60, 32);
            this.label62.TabIndex = 37;
            this.label62.Text = "0 %";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label61.Location = new System.Drawing.Point(26, 440);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(210, 32);
            this.label61.TabIndex = 36;
            this.label61.Text = "Overall Progress";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.R4VAL);
            this.panel2.Controls.Add(this.label73);
            this.panel2.Controls.Add(this.R3VAL);
            this.panel2.Controls.Add(this.label72);
            this.panel2.Controls.Add(this.tb1);
            this.panel2.Controls.Add(this.fixedSpeed);
            this.panel2.Controls.Add(this.label56);
            this.panel2.Controls.Add(this.cmdStop);
            this.panel2.Controls.Add(this.cmdRun);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.btn_load);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Location = new System.Drawing.Point(12, 492);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 109);
            this.panel2.TabIndex = 9;
            // 
            // R4VAL
            // 
            this.R4VAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.R4VAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.R4VAL.Location = new System.Drawing.Point(591, 64);
            this.R4VAL.Name = "R4VAL";
            this.R4VAL.Size = new System.Drawing.Size(43, 31);
            this.R4VAL.TabIndex = 41;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label73.Location = new System.Drawing.Point(552, 67);
            this.label73.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(38, 25);
            this.label73.TabIndex = 40;
            this.label73.Text = "R4";
            // 
            // R3VAL
            // 
            this.R3VAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.R3VAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.R3VAL.Location = new System.Drawing.Point(484, 64);
            this.R3VAL.Name = "R3VAL";
            this.R3VAL.Size = new System.Drawing.Size(43, 31);
            this.R3VAL.TabIndex = 39;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label72.Location = new System.Drawing.Point(445, 67);
            this.label72.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(38, 25);
            this.label72.TabIndex = 38;
            this.label72.Text = "R3";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb1.Location = new System.Drawing.Point(97, 67);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(148, 33);
            this.tb1.TabIndex = 37;
            this.tb1.Text = "FileName...";
            // 
            // fixedSpeed
            // 
            this.fixedSpeed.AutoSize = true;
            this.fixedSpeed.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fixedSpeed.Location = new System.Drawing.Point(552, 14);
            this.fixedSpeed.Name = "fixedSpeed";
            this.fixedSpeed.Size = new System.Drawing.Size(38, 25);
            this.fixedSpeed.TabIndex = 36;
            this.fixedSpeed.Text = "00";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label56.Location = new System.Drawing.Point(714, 14);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(120, 25);
            this.label56.TabIndex = 35;
            this.label56.Text = "00 : 00 : 00";
            // 
            // cmdStop
            // 
            this.cmdStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.cmdStop.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdStop.ForeColor = System.Drawing.Color.White;
            this.cmdStop.Location = new System.Drawing.Point(763, 65);
            this.cmdStop.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(77, 35);
            this.cmdStop.TabIndex = 21;
            this.cmdStop.Text = "STOP";
            this.cmdStop.UseVisualStyleBackColor = false;
            // 
            // cmdRun
            // 
            this.cmdRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.cmdRun.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdRun.ForeColor = System.Drawing.Color.White;
            this.cmdRun.Location = new System.Drawing.Point(671, 65);
            this.cmdRun.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(86, 35);
            this.cmdRun.TabIndex = 20;
            this.cmdRun.Text = "START";
            this.cmdRun.UseVisualStyleBackColor = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label33.Location = new System.Drawing.Point(608, 12);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(101, 25);
            this.label33.TabIndex = 19;
            this.label33.Text = "Runtime :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.label32.Location = new System.Drawing.Point(378, 12);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(169, 25);
            this.label32.TabIndex = 18;
            this.label32.Text = "Feed(mm / sec) :";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btn_load.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(10, 65);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(72, 35);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 12);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(152, 25);
            this.label31.TabIndex = 5;
            this.label31.Text = "Task Manager";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Batch Processing";
            // 
            // batch_log
            // 
            this.batch_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.batch_log.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.batch_log.Location = new System.Drawing.Point(10, 41);
            this.batch_log.Margin = new System.Windows.Forms.Padding(2);
            this.batch_log.Multiline = true;
            this.batch_log.Name = "batch_log";
            this.batch_log.ReadOnly = true;
            this.batch_log.Size = new System.Drawing.Size(400, 250);
            this.batch_log.TabIndex = 10;
            this.batch_log.Text = "Initialization completed.";
            // 
            // movement_log
            // 
            this.movement_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.movement_log.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movement_log.Location = new System.Drawing.Point(10, 41);
            this.movement_log.Margin = new System.Windows.Forms.Padding(2);
            this.movement_log.Multiline = true;
            this.movement_log.Name = "movement_log";
            this.movement_log.ReadOnly = true;
            this.movement_log.Size = new System.Drawing.Size(400, 250);
            this.movement_log.TabIndex = 11;
            this.movement_log.Text = "Initialization completed.";
            // 
            // btn_emergencyStop
            // 
            this.btn_emergencyStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(48)))));
            this.btn_emergencyStop.Font = new System.Drawing.Font("Pretendard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emergencyStop.ForeColor = System.Drawing.Color.White;
            this.btn_emergencyStop.Location = new System.Drawing.Point(1564, 19);
            this.btn_emergencyStop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_emergencyStop.Name = "btn_emergencyStop";
            this.btn_emergencyStop.Size = new System.Drawing.Size(276, 43);
            this.btn_emergencyStop.TabIndex = 12;
            this.btn_emergencyStop.Text = "EMERGENCY STOP";
            this.btn_emergencyStop.UseVisualStyleBackColor = false;
            this.btn_emergencyStop.Click += new System.EventHandler(this.btn_emergencyStop_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_exit.Font = new System.Drawing.Font("Pretendard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(80, 19);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(252, 43);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "PROGRAM EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.movement_log);
            this.panel3.Location = new System.Drawing.Point(972, 712);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 296);
            this.panel3.TabIndex = 14;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(12, 12);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(222, 25);
            this.label35.TabIndex = 5;
            this.label35.Text = "Robot Movement Log";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label36);
            this.panel4.Controls.Add(this.batch_log);
            this.panel4.Location = new System.Drawing.Point(1418, 712);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 296);
            this.panel4.TabIndex = 15;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Pretendard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(12, 12);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(229, 25);
            this.label36.TabIndex = 5;
            this.label36.Text = "Batch Completion Log";
            // 
            // mainForm_RPCS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_emergencyStop);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.user_position);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.target_position);
            this.Controls.Add(this.state);
            this.Controls.Add(this.robot_state);
            this.Controls.Add(this.connection_status);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.turntable_section);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm_RPCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "반사경 가공 로봇 제어 SW v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mod.ResumeLayout(false);
            this.mod.PerformLayout();
            this.connection_status.ResumeLayout(false);
            this.connection_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.turntable_section.ResumeLayout(false);
            this.turntable_section.PerformLayout();
            this.robot_state.ResumeLayout(false);
            this.robot_state.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.state.ResumeLayout(false);
            this.state.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.target_position.ResumeLayout(false);
            this.target_position.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.user_position.ResumeLayout(false);
            this.user_position.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.batch.ResumeLayout(false);
            this.batch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mod;
        private System.Windows.Forms.Panel connection_status;
        private System.Windows.Forms.Panel turntable_section;
        private System.Windows.Forms.Panel robot_state;
        private System.Windows.Forms.Panel state;
        private System.Windows.Forms.Panel target_position;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel user_position;
        private System.Windows.Forms.Panel batch;
        private System.Windows.Forms.TextBox batch_log;
        private System.Windows.Forms.TextBox movement_log;
        private System.Windows.Forms.Button btn_setOrigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_initOrigin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button tgMod;
        private System.Windows.Forms.Button btn_emergencyStop;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_macro1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.TextBox tb_setX;
        private System.Windows.Forms.TextBox tb_setR;
        private System.Windows.Forms.TextBox tb_setP;
        private System.Windows.Forms.TextBox tb_setW;
        private System.Windows.Forms.TextBox tb_setZ;
        private System.Windows.Forms.TextBox tb_setY;
        private System.Windows.Forms.TextBox tb_rUF;
        private System.Windows.Forms.TextBox tb_pUF;
        private System.Windows.Forms.TextBox tb_wUF;
        private System.Windows.Forms.TextBox tb_zposUF;
        private System.Windows.Forms.TextBox tb_yposUF;
        private System.Windows.Forms.TextBox tb_xposUF;
        private System.Windows.Forms.Button btn_goto;
        private System.Windows.Forms.Button btn_macro4;
        private System.Windows.Forms.Button btn_macro3;
        private System.Windows.Forms.Button btn_macro2;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label tb_r;
        private System.Windows.Forms.Label tb_p;
        private System.Windows.Forms.Label tb_w;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label tb_zpos;
        private System.Windows.Forms.Label tb_xpos;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label tb_ypos;
        private System.Windows.Forms.Button btn_editMacro;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox R4VAL;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox R3VAL;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label fixedSpeed;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Label LBL_M2;
        private System.Windows.Forms.Label LBL_M1;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox tbRobotPosition;
        private System.Windows.Forms.DataGridView lv_pos;
        private System.Windows.Forms.Label lblOperationHours;
        private System.Windows.Forms.Timer updateTimer;
        private Label lblTurnTableAngle;
        private DataGridViewTextBoxColumn column_state;
        private DataGridViewTextBoxColumn column_f;
        private DataGridViewTextBoxColumn column_t;
        private DataGridViewTextBoxColumn column_x;
        private DataGridViewTextBoxColumn column_y;
        private DataGridViewTextBoxColumn column_z;
        private DataGridViewTextBoxColumn column_w;
        private DataGridViewTextBoxColumn column_p;
        private DataGridViewTextBoxColumn column_r;
        private DataGridViewTextBoxColumn column_m;
        private DataGridViewTextBoxColumn column_n;
    }
}

