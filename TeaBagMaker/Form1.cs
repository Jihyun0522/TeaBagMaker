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

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
