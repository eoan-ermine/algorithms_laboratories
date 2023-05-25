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
    public partial class TitleForm : Form
    {
        public TitleForm()
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
            Laboratory1TitleForm nextForm = new Laboratory1TitleForm();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory2TitleForm nextForm = new Laboratory2TitleForm();
            nextForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory3TitleForm nextForm = new Laboratory3TitleForm();
            nextForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory4TitleForm nextForm = new Laboratory4TitleForm();
            nextForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory5TitleForm nextForm = new Laboratory5TitleForm();
            nextForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory6TitleForm nextForn = new Laboratory6TitleForm();
            nextForn.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory7TitleForm nextForm = new Laboratory7TitleForm();
            nextForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory8TitleForm nextForm = new Laboratory8TitleForm();
            nextForm.Show();

        }
    }
}
