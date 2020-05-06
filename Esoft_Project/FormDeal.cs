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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
            ShowDealSet();
        }

        void ShowSupply()
        {
            //очищаем comboBox
            comboBoxSupply.Items.Clear();
            foreach (SupplySet supplySet in Program.wftDb.SupplySet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                //можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать Id, т.к как он нужен для дальнейшей работы
                string[] item = { supplySet.Id.ToString() + ". ", "Риелтор: " + supplySet.AgentsSet.LastName, "Клиент: " + supplySet.ClientsSet.LastName };
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }

        void ShowDemand()
        {
            comboBoxDemand.Items.Clear();
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                string[] item = { demandSet.Id.ToString() + ". ", "Риелтор: " + demandSet.AgentsSet.LastName, "Клиент: " + demandSet.ClientsSet.LastName };
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        void Deductions()
        {
            if (comboBoxSupply.SelectedItem != null && comboBoxDemand.SelectedItem != null)
            {
                //находим в базе предложение и потребность с выбранными номерами
                SupplySet supplySet = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                DemandSet demandSet = Program.wftDb.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]));
                //расчитываем отчисления компании для клиента-покупателя (3% от стоимости недвижимости), выводим в textCustomerCompanyDeductions
                double customerCompanyDeductions = supplySet.Price * 0.03;
                textCustomerCompanyDeductions.Text = customerCompanyDeductions.ToString("0.00");
                //расчитываем отчисления компании для клиента-покупателя (комиссия указана в таблице AgentsSet), выводим в textBoxAgentCustomerDeductions
                if (demandSet.AgentsSet.Share != null)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * Convert.ToDouble(demandSet.AgentsSet.Share) / 100.00;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
                else
                {
                    //если комиссия не указана, то автоматически берется 45%
                    double agentCustomerDeductions = customerCompanyDeductions * 0.45;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
            }
            else
            {
                textCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
            if (comboBoxSupply.SelectedItem != null)
            {
                //находим в базе предложение с выбранным номером
                SupplySet supplySet = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                //расчитываем отчисления компании для клиента-продавца
                //если продается квартира
                double sellerCompanyDeductions;
                if (supplySet.RealEstateSet.Type == 0)
                {
                    sellerCompanyDeductions = 36000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //если продается дом
                else if (supplySet.RealEstateSet.Type == 1)
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //если продается земля
                else
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.02;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //расчитываем отчисления риелтору для клиент-покупателя (комиссия указана в таблице AgentsSet)
                if (supplySet.AgentsSet.Share != null)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * Convert.ToDouble(supplySet.AgentsSet.Share) / 100.00;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
                else
                {
                    //если комиссия не указана, то автоматически берется 45%
                    double agentSellerDeductions = sellerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxSellerCompanyDeductions.Text = "";
                textBoxAgentSellerDeductions.Text = "";
                textCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
        }

        void ShowDealSet()
        {
            //
            listViewDealSet.Items.Clear();
            //
            foreach (DealSet deal in Program.wftDb.DealSet)
            {
                //
                ListViewItem item = new ListViewItem(new string[]
                {
                    //
                    //
                    deal.SupplySet.ClientsSet.LastName,
                    //
                    deal.SupplySet.AgentsSet.LastName,
                    //
                    deal.DemandSet.ClientsSet.LastName,
                    //
                    deal.DemandSet.AgentsSet.LastName,
                    //
                    "г. "+deal.SupplySet.RealEstateSet.Address_City+", ул. " + deal.SupplySet.RealEstateSet.Address_Street+", д. " +
                    deal.SupplySet.RealEstateSet.Address_House+", кв. "+deal.SupplySet.RealEstateSet.Address_Number,
                    //
                    deal.SupplySet.Price.ToString()
                });
                //
                item.Tag = deal;
                //
                listViewDealSet.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //
            if (comboBoxDemand.SelectedItem != null && comboBoxSupply.SelectedItem != null)
            {
                //
                DealSet deal = new DealSet();
                //
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                //
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                //
                Program.wftDb.DealSet.Add(deal);
                //
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                //
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                //
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                //
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
        }

        private void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                //
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                comboBoxSupply.SelectedIndex = comboBoxSupply.FindString(deal.IdSupply.ToString());
                comboBoxDemand.SelectedIndex = comboBoxDemand.FindString(deal.IdDemand.ToString());
            }
            else
            {
                //
                comboBoxDemand.SelectedItem = null;
                comboBoxSupply.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //
            try
            {
                //
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                    //
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    //
                    Program.wftDb.DealSet.Remove(deal);
                    //
                    Program.wftDb.SaveChanges();
                    //
                    ShowDealSet();
                }
                //
                comboBoxDemand.SelectedItem = null;
                comboBoxSupply.SelectedItem = null;
            }
            catch 
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
