using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProgramiProje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadForm(Form Form)
        {
            if(this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form frm = Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle= FormBorderStyle.None;
            this.panelMain.Controls.Add(frm);
            this.panelMain.Tag = frm;
            frm.Show();
        }         

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Close();
        }        

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadForm(new Form1());            
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            var formForClose = Application.OpenForms.OfType<Form>().ToList();
            foreach (var item in formForClose)
            {
                if (item.Name != "MainForm")
                {
                    item.Close();
                }
            }
        }
    }
}
