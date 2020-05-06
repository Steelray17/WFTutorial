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
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowAgents();
            ShowClients();
            ShowDemandSet();
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
            listViewDemandSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDemandSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDemandSet__House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Изменения формы, если выбрана строчка "Квартира" (её индекс 0)
            if (comboBoxType.SelectedIndex == 0)
            {
                //Делаем видимые нужные элементы
                listViewDemandSet_Apartment.Visible = true;
                labelClient.Visible = true;
                comboBoxClients.Visible = true;
                labelAgent.Visible = true;
                comboBoxAgents.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMinFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                labelMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMaxArea.Visible = true;
                labelMinArea.Visible = true;

                //скрываем ненужные элементы
                listViewDemandSet_Land.Visible = false;
                listViewDemandSet__House.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;


                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }

            //изменения формы если выбрана строчка "Земля" (её индекс 2)
            else if (comboBoxType.SelectedIndex == 2)
            {
                //Делаем видимые нужные элементы
                listViewDemandSet_Land.Visible = true;
                comboBoxClients.Visible = true;
                labelAgent.Visible = true;
                comboBoxAgents.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMaxArea.Visible = true;
                labelMinArea.Visible = true;

                //скрываем ненужные элементы
                listViewDemandSet__House.Visible = false;
                listViewDemandSet_Apartment.Visible = false;
                textBoxMinRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;


                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }

            //изменение формы, если выбрана строчка "Дом" (её индекс 1)
            else if (comboBoxType.SelectedIndex == 1)
            {
                //Делаем видимые нужные элементы
                listViewDemandSet__House.Visible = true;
                comboBoxClients.Visible = true;
                labelAgent.Visible = true;
                comboBoxAgents.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMaxArea.Visible = true;
                labelMinArea.Visible = true;

                //скрываем ненужные элементы
                listViewDemandSet_Land.Visible = false;
                listViewDemandSet_Apartment.Visible = false;
                textBoxMinRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;

                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр класса Объект недвижимости
            DemandSet demandSet = new DemandSet();
            //Делаем ссылку на объект, который храниться в textBox-ах (сначала общие поля)
            demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
            demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
            demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
            demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
            demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
            demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);

            //Дополнительные поля для типа "Квартира"
            if (comboBoxType.SelectedIndex == 0)
            {
                demandSet.Type = 0;
                demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
            }
            //Дополнительные поля для типа "Дом"
            else if (comboBoxType.SelectedIndex == 1)
            {
                demandSet.Type = 1;
                demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
            }
            //Дополнительные поля для типа "Земля"
            else
            {
                demandSet.Type = 2;
            }
            //Добавляем в таблицу DemandSet новый объект недвижимости demandSet
            Program.wftDb.DemandSet.Add(demandSet);
            //Сохраняем изменения в модели wftDb
            Program.wftDb.SaveChanges();
        }
        void ShowDemandSet()
        {
            //Предварительно очищаем все ListView
            listViewDemandSet_Apartment.Items.Clear();
            listViewDemandSet__House.Items.Clear();
            listViewDemandSet_Land.Items.Clear();
            //Проходим по коллекции клиентов, которые находятся в базе
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                //отображение квартир в listViewDemandSet_Apartment
                if (demandSet.Type == 0)
                {
                    //создадим новый элемент в listViewDemandSet_Apartment с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                        demandSet.AgentsSet.LastName+" "+demandSet.AgentsSet.FirstName+" "+demandSet.AgentsSet.MiddleName,
                        demandSet.MinArea.ToString(),
                        demandSet.MaxArea.ToString(),
                        demandSet.MinRooms.ToString(),
                        demandSet.MaxRooms.ToString(),
                        demandSet.MinFloor.ToString(),
                        demandSet.MaxFloor.ToString(),
                        demandSet.MinPrice.ToString(), 
                        demandSet.MaxPrice.ToString()
                    });
                    //указываем по какому тегу выбраны
                    item.Tag = demandSet;
                    //добавляем элементы в listViewDemandSet__Apartment для отображения
                    listViewDemandSet_Apartment.Items.Add(item);
                }
                //отображение домов в listViewDemandSet__House
                else if (demandSet.Type == 1)
                {
                    //создадим новый элемент в listViewDemandSet__House с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                        demandSet.AgentsSet.LastName+" "+demandSet.AgentsSet.FirstName+" "+demandSet.AgentsSet.MiddleName,
                        demandSet.MinArea.ToString(),
                        demandSet.MaxArea.ToString(),
                        demandSet.MinFloors.ToString(),
                        demandSet.MaxFloors.ToString(),
                        demandSet.MinPrice.ToString(),
                        demandSet.MaxPrice.ToString()
                    });
                    //указываем пок акому тегу выбраны элементы
                    item.Tag = demandSet;
                    //добавляем элементы в listViewDemandSet__House для отображения
                    listViewDemandSet__House.Items.Add(item);
                }
                else
                {
                    //создадим новый элемент в listViewDemandSet__Land с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                        demandSet.AgentsSet.LastName+" "+demandSet.AgentsSet.FirstName+" "+demandSet.AgentsSet.MiddleName,
                        demandSet.MinArea.ToString(),
                        demandSet.MaxArea.ToString(),
                        demandSet.MinPrice.ToString(),
                        demandSet.MaxPrice.ToString()
                    });
                    //указываем по какому тегу выбраны элементы
                    item.Tag = demandSet;
                    //добавляем элементы в listViewDemandSet__Land для отображения
                    listViewDemandSet_Land.Items.Add(item);
                }
            }
            //выравниваем столбцы во всех listView
            listViewDemandSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDemandSet__House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDemandSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewDemandSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                DemandSet demandSet = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                //указываем, что может быть изменено
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirstName + " " + demandSet.ClientsSet.MiddleName.ToString();
                comboBoxAgents.Text = demandSet.AgentsSet.LastName + " " + demandSet.AgentsSet.FirstName + " " + demandSet.AgentsSet.MiddleName.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinRooms.Text = demandSet.MinRooms.ToString();
                textBoxMaxRooms.Text = demandSet.MaxRooms.ToString();
                textBoxMinFloor.Text = demandSet.MinFloor.ToString();
                textBoxMaxFloor.Text = demandSet.MaxFloor.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
            }
            else
            {
                //если  не выбран ни один элемент, задаем пустые поля
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void listViewDemandSet__House_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewDemandSet__House.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                DemandSet demandSet = listViewDemandSet__House.SelectedItems[0].Tag as DemandSet;
                //указываем, что может быть изменено
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinFloors.Text = demandSet.MinFloors.ToString();
                textBoxMaxFloors.Text = demandSet.MaxFloors.ToString();
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirstName + " " + demandSet.ClientsSet.MiddleName.ToString();
                comboBoxAgents.Text = demandSet.AgentsSet.LastName + " " + demandSet.AgentsSet.FirstName + " " + demandSet.AgentsSet.MiddleName.ToString();
            }
            else
            {
                //если  не выбран ни один элемент, задаем пустые поля
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void listViewDemandSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewDemandSet_Land.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                DemandSet demandSet = listViewDemandSet_Land.SelectedItems[0].Tag as DemandSet;
                //указываем, что может быть изменено
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirstName + " " + demandSet.ClientsSet.MiddleName.ToString();
                comboBoxAgents.Text = demandSet.AgentsSet.LastName + " " + demandSet.AgentsSet.FirstName + " " + demandSet.AgentsSet.MiddleName.ToString();
            }
            else
            {
                //если  не выбран ни один элемент, задаем пустые поля
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //выбран тип "Квартира", работа с listViewDemandSet_Apartment
            if (comboBoxType.SelectedIndex == 0)
            {
                //если в listView выбран элемент
                if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
                {
                    //Ищем элемент из таблицы по тегу
                    DemandSet demandSet = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                    //указываем, что может быть изменено
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    //сохраняем изменения в модели wftDb
                    Program.wftDb.SaveChanges();
                    //отображаем в listViewDemandSet_Apartment
                    ShowDemandSet();
                }
            }
            //выбран тип "Дом", работа с listViewDemandSet_House
            else if (comboBoxType.SelectedIndex == 1)
            {
                //если в listView выбран элемент
                if (listViewDemandSet__House.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    DemandSet demandSet = listViewDemandSet__House.SelectedItems[0].Tag as DemandSet;
                    //указываем, что может быть изменено
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    //сохраняем изменения в модели wftDb
                    Program.wftDb.SaveChanges();
                    //отображаем в listViewDemandSet_House
                    ShowDemandSet();
                }
            }
            //выбран тип "Земли", работа с listViewDemandSet_Land
            else
            {
                //если в listView выбран элемент
                if (listViewDemandSet_Land.SelectedItems.Count == 1)
                {
                    //Ищем элемент из таблицы по тегу 
                    DemandSet demandSet = listViewDemandSet_Land.SelectedItems[0].Tag as DemandSet;
                    //Указываем, что может быть изменено
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    //сохраняем изменения в модели wftDb
                    Program.wftDb.SaveChanges();
                    //отображаем в listViewDemandSet_Land
                    ShowDemandSet();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //выбран тип "Квартира", работа с listViewDemandSet_Apartment
                if (comboBoxType.SelectedIndex == 0)
                {
                    //если в listView выбран элемент
                    if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
                    {
                        //ищем этот элемент в базе по тегу
                        DemandSet demandSet = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                        //удаляем из модели базы данных
                        Program.wftDb.DemandSet.Remove(demandSet);
                        //сохраняем изменения
                        Program.wftDb.SaveChanges();
                        //отображаем обновленный список
                        ShowDemandSet();
                    }
                    //очищаем текстовые поля
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";
                }
                //выбран тип "Дом", работа с listViewDemandSet_House
                else if (comboBoxType.SelectedIndex == 1)
                {
                    //если в listView выбран элемент
                    if (listViewDemandSet__House.SelectedItems.Count == 1)
                    {
                        //ищем этот элемент в базе по тегу
                        DemandSet demandSet = listViewDemandSet__House.SelectedItems[0].Tag as DemandSet;
                        //удаляем из модели базы данных
                        Program.wftDb.DemandSet.Remove(demandSet);
                        //сохраняем изменения
                        Program.wftDb.SaveChanges();
                        //отображаем обновленный список
                        ShowDemandSet();
                    }
                    //очищаем текстовые поля
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";
                }
                //выбран тип "Земля", работа с listViewDemandSet_Land
                else
                {
                    //если в listView выбран элемент
                    if (listViewDemandSet_Land.SelectedItems.Count == 1)
                    {
                        //ищем этот элемент в базе по тегу
                        DemandSet demandSet = listViewDemandSet_Land.SelectedItems[0].Tag as DemandSet;
                        //удаляем из модели базы данных
                        Program.wftDb.DemandSet.Remove(demandSet);
                        //сохраняем изменения
                        Program.wftDb.SaveChanges();
                        //отображаем обновленный список
                        ShowDemandSet();
                    }
                    //очищаем текстовые поля
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";
                }
            }
            //если возникает какая-то ошибка
            catch
            {
                MessageBox.Show("Невозможно удалить, эта записать используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
