using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse
{
    public partial class LessonForm : Form
    {
        private Form learningForm;
        private Form receptionForm;
        private Form transmissionForm;

        public LessonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            learningForm = new Learning1();
            learningForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receptionForm = new ReceptionForm();
            receptionForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transmissionForm = new TransmissionForm();
            transmissionForm.Show();
        }
    }
}
