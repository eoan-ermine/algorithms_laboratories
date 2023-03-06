using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWorks
{
    public partial class Laboratory2TitleForm : Form
    {
        public Laboratory2TitleForm()
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
            Laboratory2Form nextForm = new Laboratory2Form();
            nextForm.Show();
        }
    }
}
