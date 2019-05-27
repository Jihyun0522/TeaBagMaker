using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] teaList = new string[]{"홍차", "녹차", "루이보스차", "국화차"};
        int[] teaTime = new int[]{120, 180, 300, 120 };
        int SelectTea = 0;
        int countNum = 0;
        string orgTea = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < teaList.Length; i++)
            {
                this.teaComboList.Items.Add(teaList[i]);
            }
            
            if (teaComboList.Items.Count > 0)
            {
                this.teaComboList.SelectedIndex = 0;
            }

        }

        private void teaComboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tea = this.teaComboList.SelectedIndex;
            this.Time.Text = this.Time.Text + (teaTime[tea]/60).ToString() + "분";
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            ProcessTimer();
        }

        private void ProcessTimer()
        {
            this.countNum = Convert.ToInt32(SelectTea.ToString());
            this.timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (countNum < 1)
            {
                //this.timer.Enabled = false;
                this.Time.Text = "";
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                countNum--;
                this.txtCountDown.Text = Convert.ToString((countNum/60) + "분");
            }
        }
    }
}
