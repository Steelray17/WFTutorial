using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class Menu : System.Windows.Forms.Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formDemand = new FormDemand();
            formDemand.Show();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Клиент и открываем её
            System.Windows.Forms.Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form fromAgents = new FromAgents();
            fromAgents.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }
    }
}
