using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWorksGUI
{
    public partial class Laboratory8TitleForm : Form
    {
        public Laboratory8TitleForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitleForm nextForm = new TitleForm();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory8Form nextForm = new Laboratory8Form();
            nextForm.Show();
        }
    }
}
