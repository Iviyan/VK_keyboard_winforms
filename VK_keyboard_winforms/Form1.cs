using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_keyboard_winforms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
