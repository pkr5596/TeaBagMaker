using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        int countTime;

        string[] tea = { "홍차", "녹차", "루이보스차", "국화차" };
        string orgstr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tea.Length; i++)
            {
                this.cbBox.Items.Add(tea[i]);
            }
            this.orgstr = lb_time.Text;
            if (cbBox.Items.Count > 0)
            {
                this.cbBox.SelectedIndex = 0;
            }
        }

        private void CbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Bt_start_Click(object sender, EventArgs e)
        {

        }

        private void Lb_time_Click(object sender, EventArgs e)
        {

        }
    }
}
