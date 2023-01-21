using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using boltlib (mandatory)
using Boltlib;

namespace remove_memory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this initiates the timer to work find for your emulator process
            boltmem.proctimer(1000);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Changemem contains 3 inputs (scan,replace,mode);
            //here scan is the scan of your aob and replace is the aob which is to be replaced
            //mode corresponds to the activate or disactiate
            //1 = activate && 0 = disactiate
            Mem.ChangeMem("5F 48 69 70 73 62", "5F 48 65 61 64 62", "1");
            PSPS.ForeColor = Color.Yellow;
            PSPS.Text = "Wait For Apply";
        }
        private void button2_Click(object sender, EventArgs e)
        {
                Mem.ChangeMem("", "","1");
                PSPS.ForeColor = Color.Yellow;
                PSPS.Text = "Wait For Apply";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mem.ChangeMem("", "","1");
            PSPS.ForeColor = Color.Yellow;
            PSPS.Text = "Wait For Apply";
        }

        private void button4_Click(object sender, EventArgs e)
        {
                Mem.ChangeMem("", "","1");
                PSPS.ForeColor = Color.Yellow;
                PSPS.Text = "Wait For Apply";
        }

        private void button5_Click(object sender, EventArgs e)
        {
                Mem.ChangeMem("", "","1");
                PSPS.ForeColor = Color.Yellow;
                PSPS.Text = "Wait For Apply";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mem.ChangeMem("", "","1");
            PSPS.ForeColor = Color.Yellow;
            PSPS.Text = "Wait For Apply";
        }
        //This is the declaration of boltmem class
        public static Mem boltmem = new Mem();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //A timer For Refreshing Text on Time to show PID and status text
            //boltmem.hook = hook pid fetch from boltmem
            //info is the index of status these numbers are fixed but you can change the text according to yourself
            //Mem.info = null; is to clear the info string time to time so that it may not show wrong index
            PID.Text = boltmem.hook;
            if (Mem.info == "0")
            {
                PSPS.ForeColor = Color.YellowGreen;
                PSPS.Text = "Wait For Apply";
                Mem.info = null;
            }
            else if (Mem.info == "1")
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "No Emulator Found";
                Mem.info = null;
            }
            else if (Mem.info == "-2")
            {
                PSPS.Text = "YOUR HACK DEACTIVE!";
                Mem.info = null;
            }
            else if (Mem.info == "2")
            {
                PSPS.Text = "YOUR HACK ACTIVE!";
                Mem.info = null;
            }
            else if (Mem.info == "3")
            {
                PSPS.Text = "Maybe Already Applied Or Nothing Found";
                Mem.info = null;
            }
            else if (Mem.info == "4")
            {
                PSPS.Text = "Wrong PID Please Refresh";
                Mem.info = null;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //initiates the timer to refresh time to time
            timer1.Start();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // pause and resume process
            if (pr.Checked == true)
            {
                //this suspends the emulators process
                boltmem.SuspendProcess();
            }
            else
            {
                //this resumes the emulators process
                boltmem.ResumeProcess();
            }
        }
    }
}
