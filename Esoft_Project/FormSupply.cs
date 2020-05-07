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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }

        void ShowAgents()
        {
            //очищаем comboBox
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentSet in Program.wftDb.AgentsSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                //можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }

        void ShowClients()
        {
            //очищаем comboBox
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                //можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }

        void ShowRealEstate()
        {
            //очищаем comboBox
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.wftDb.RealEstateSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                //можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = { realEstateSet.Id.ToString()+".", realEstateSet.Address_City+",", realEstateSet.Address_Street+",",
                "д. " +  realEstateSet.Address_House + ",", "кв. "+realEstateSet.Address_Number};
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate != null && textBoxPrice.Text != "")
            {
                //
                SupplySet supply = new SupplySet();
                //
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                //
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                //
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                //
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                //
                Program.wftDb.SupplySet.Add(supply);
                //
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowSupplySet()
        {
            //Предварительно очищаем все listView
            listViewSupplySet.Items.Clear();
            //Проходим по коллекции клиентов, которые находятся в базе
            foreach (SupplySet supply in Program.wftDb.SupplySet)
            {
                //создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    //Id риелтора
                    supply.IdAgent.ToString(),
                    //ФИО риелтора
                    supply.AgentsSet.LastName+" "+supply.AgentsSet.FirstName+" "+supply.AgentsSet.MiddleName,
                    //Id клиента
                    supply.IdClient.ToString(),
                    //ФИО клиента
                    supply.ClientsSet.LastName+" "+supply.ClientsSet.FirstName+" "+supply.ClientsSet.MiddleName,
                    //Id объекта недвижимости
                    supply.IdRealEstate.ToString(),
                    //Адрес объекта недвижимости
                    "г. "+supply.RealEstateSet.Address_City+", ул. "+supply.RealEstateSet.Address_Street+", д. "+
                    supply.RealEstateSet.Address_House+", кв. "+supply.RealEstateSet.Address_Number,
                    //Цена
                    supply.Price.ToString()
                });
                //Указываем по какому тегу выбраны элементы
                item.Tag = supply;
                //Добавляем элементы в listViewSupplySet для отображения
                listViewSupplySet.Items.Add(item);
            }
            listViewSupplySet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                //
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                //
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                //
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                //
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                //
                //
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.IdAgent.ToString());
                //
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }
            else
            {
                //
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //
            try
            {
                //
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    //
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    //
                    Program.wftDb.SupplySet.Remove(supply);
                    //
                    Program.wftDb.SaveChanges();
                    //
                    ShowSupplySet();
                }
                //
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
