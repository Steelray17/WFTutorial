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
    public partial class FromAgents : System.Windows.Forms.Form
    {
        public FromAgents()
        {
            InitializeComponent();
            ShowAgent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Создаём новый экземпляр класса Клиент
            AgentsSet agentSet = new AgentsSet();
            //Делаем ссылку на обьект, который хранится в textBox-ax
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.Share = textBoxShare.Text;
            //Добавляем в таблицу ClientsSet нового клиента clientSet
            Program.wftDb.AgentsSet.Add(agentSet);
            //Сохраняем изменения в модели wftDb
            Program.wftDb.SaveChanges();
            ShowAgent();
        }
        void ShowAgent()
        {
            //предварительно очищаем listView
            listViewAgent.Items.Clear();
            //проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (AgentsSet agentSet in Program.wftDb.AgentsSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    agentSet.Id.ToString(), agentSet.FirstName, agentSet.MiddleName,
                    agentSet.LastName, agentSet.Share
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = agentSet;
                //добавляем элементы в listView для отображения
                listViewAgent.Items.Add(item);
            }
            //выравниваем колонки в listView
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //условие, если в listView выбран 1 элемент
            if (listViewAgent.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                //указываем, что может быть изменено
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.Share = textBoxShare.Text;
                //Сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                //отображение в listView
                ShowAgent();
            }
        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            if (listViewAgent.SelectedItems.Count == 1)
            {
                //
                AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                //
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxLastName.Text = agentSet.LastName;
                textBoxShare.Text = agentSet.Share;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxShare.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    //ищем этот элемент, сверяем его
                    AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                    //удаляем из модели и базы данных
                    Program.wftDb.AgentsSet.Remove(agentSet);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновленный список
                    ShowAgent();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxShare.Text = "";
            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
