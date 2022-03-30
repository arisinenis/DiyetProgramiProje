using Model.Entities;
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
    public partial class DieticianForm : Form
    {
        DieticianRegisterInfo dieticianRegisterInfo;
        public DieticianForm(DieticianRegisterInfo _dieticianRegisterInfo)
        {
            InitializeComponent();
            dieticianRegisterInfo = _dieticianRegisterInfo;
        }

        private void DieticianForm_Load(object sender, EventArgs e)
        {

        }
    }
}
