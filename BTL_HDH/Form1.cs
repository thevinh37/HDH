using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace BTL_HDH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        Process[] process;
        private void GetProcess()
        {
            process = Process.GetProcesses();
            if(Convert.ToInt32(label2.Text) != process.Length)
            {
                listBox1.Items.Clear();
                for(int i=0; i<process.Length; i++)
                {
                    listBox1.Items.Add(process[i].ProcessName);
                }
                label2.Text = process.Length.ToString();
            }    
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetProcess();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetProcess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process[listBox1.SelectedIndex].Kill();
        }

        private void dừngTiếnTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process[listBox1.SelectedIndex].Kill();
        }
    }
}
