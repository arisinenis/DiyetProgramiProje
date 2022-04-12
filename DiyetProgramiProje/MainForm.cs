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
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
           
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelMain.BackColor = ColorTranslator.FromHtml("#98c1d9");
            panelSide.BackColor = ColorTranslator.FromHtml("#3d5a80");
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btnAdminMain_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms["ReportForm"];
            if (openForms != null)
            {
                openForms.Close();
                var formOpen = Application.OpenForms["AdminForm"];
                panelMain.Controls.Add(formOpen);
            }
            
        }

        private void btnAdminReports_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms["ReportForm"];
            if (openForms == null)
            {
                LoadForm(new ReportForm());
            }
            
        }

        private void btnDieticianMain_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms["DieticianMessagesForm"];
            if (openForms != null)
            {
                openForms.Hide();
                var formOpen = Application.OpenForms["DieticianForm"];
                panelMain.Controls.Add(formOpen);
            }
        }

        private void btnDieticianMessages_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms["DieticianForm"];
            if (openForms != null)
            {
                openForms.Hide();
                var formOpen = Application.OpenForms["DieticianMessagesForm"];
                panelMain.Controls.Add(formOpen);

            }
        }
    }
}
