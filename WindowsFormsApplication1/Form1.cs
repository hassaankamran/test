using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("original text");
            MessageBox.Show("Dev 2 => Sample 1");
            MessageBox.Show("Dev 1 => sample 1");
			MessageBox.Show("Dev 2 => Sample 2");
            MessageBox.Show("Dev 2 => Sample 3");
            
            MessageBox.Show("Dev 1 => sample 2");
            MessageBox.Show("Dev 1 => sample 3");



            MessageBox.Show("Dev 1 => Newly added 3.1");
            MessageBox.Show("Dev 1 => Newly added 3.2");
            MessageBox.Show("Dev 1 => Newly added 3.3");
            MessageBox.Show("Dev 1 => Newly added 3.4");
            MessageBox.Show("Dev 1 => Newly added 3.5");

        }
    }
}
