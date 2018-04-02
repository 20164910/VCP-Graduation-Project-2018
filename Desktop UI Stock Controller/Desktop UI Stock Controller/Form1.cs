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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainForecastBtn_Click(object sender, EventArgs e)
        {
            //to show the new form
            Main_Forecast myNewForm = new Main_Forecast();
            myNewForm.Show();
            //to hide the main
            this.Hide();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            //to show the new form
            Orders myOrders = new Orders();
            myOrders.Show();
            //to hide the main
            this.Hide();

        }

        private void proStockBtn_Click(object sender, EventArgs e)
        {
            //to show the new form
            ProductsStocks myProStocks = new ProductsStocks();
            myProStocks.Show();
            //to hide the main
            this.Hide();

        }

        private void users_Click(object sender, EventArgs e)
        {
            //to show the new form
            Users myUsers = new Users();
            myUsers.Show();
            //to hide the main
            this.Hide();

        }

        private void marketing_Click(object sender, EventArgs e)
        {
            //to show the new form
            Marketing myMarketing = new Marketing();
            myMarketing.Show();
            //to hide the main
            this.Hide();

        }

        private void Complaints_Click(object sender, EventArgs e)
        {
            //to show the new form
            Complaints myComplaints = new Complaints();
            myComplaints.Show();
            //to hide the main
            this.Hide();

        }

        private void Messages_Click(object sender, EventArgs e)
        {
            //to show the new form
            Messages myMessages = new Messages();
            myMessages.Show();
            //to hide the main
            this.Hide();

        }
    }
}
