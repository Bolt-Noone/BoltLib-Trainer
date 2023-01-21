
namespace remove_memory
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PID = new System.Windows.Forms.Label();
            this.PSPS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Location = new System.Drawing.Point(25, 15);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(16, 13);
            this.PID.TabIndex = 0;
            this.PID.Text = "...";
            // 
            // PSPS
            // 
            this.PSPS.AutoSize = true;
            this.PSPS.Location = new System.Drawing.Point(25, 28);
            this.PSPS.Name = "PSPS";
            this.PSPS.Size = new System.Drawing.Size(16, 13);
            this.PSPS.TabIndex = 1;
            this.PSPS.Text = "...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(102, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "AIMBOT LOBBY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(8, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "AIMBOT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(196, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "AIMNECK LOBBY";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(289, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "ANTIBAN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(13, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "ANTICHECK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(202, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "ANTIBLACKLIST";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pr
            // 
            this.pr.AutoSize = true;
            this.pr.Location = new System.Drawing.Point(10, 130);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(100, 17);
            this.pr.TabIndex = 21;
            this.pr.Text = "Pause/Resume";
            this.pr.UseVisualStyleBackColor = true;
            this.pr.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(387, 150);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PSPS);
            this.Controls.Add(this.PID);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOLTLIB TRAINER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.Label PSPS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox pr;
    }
}

