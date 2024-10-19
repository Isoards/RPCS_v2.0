namespace RPCS
{
    partial class mod1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tgMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tgMod
            // 
            this.tgMod.BackgroundImage = global::RPCS.Properties.Resources.button_mod1;
            this.tgMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tgMod.Cursor = System.Windows.Forms.Cursors.Default;
            this.tgMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tgMod.Location = new System.Drawing.Point(107, 74);
            this.tgMod.Name = "tgMod";
            this.tgMod.Size = new System.Drawing.Size(328, 40);
            this.tgMod.TabIndex = 12;
            this.tgMod.UseVisualStyleBackColor = true;
            this.tgMod.Click += new System.EventHandler(this.tgMod_Click);
            // 
            // mod1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tgMod);
            this.Name = "mod1Form";
            this.Text = "mod1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tgMod;
    }
}