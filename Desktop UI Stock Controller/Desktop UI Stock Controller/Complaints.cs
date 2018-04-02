using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_UI_Stock_Controller
{
    public partial class Complaints : Form
    {
        public Complaints()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //to return back to the main form
            mainMenu mainForm = new mainMenu();
            mainForm.Show();
            //to hide it
            this.Hide();
        }
    }
}
