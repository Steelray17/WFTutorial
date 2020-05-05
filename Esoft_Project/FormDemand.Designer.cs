﻿namespace Esoft_Project
{
    partial class FormDemand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemand));
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.listViewDemandSet_Land = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDemandSet__House = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDemandSet_Apartment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxMinArea = new System.Windows.Forms.TextBox();
            this.textBoxMaxArea = new System.Windows.Forms.TextBox();
            this.textBoxMinRooms = new System.Windows.Forms.TextBox();
            this.textBoxMinFloor = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloor = new System.Windows.Forms.TextBox();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.textBoxMaxRooms = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.Location = new System.Drawing.Point(12, 28);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClients.TabIndex = 0;
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.Location = new System.Drawing.Point(12, 68);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgents.TabIndex = 1;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 108);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 2;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(180, 28);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinPrice.TabIndex = 3;
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(180, 68);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxPrice.TabIndex = 4;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 12);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 5;
            this.labelClient.Text = "Клиент";
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(12, 52);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(49, 13);
            this.labelAgent.TabIndex = 6;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(9, 92);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Тип";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(180, 10);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(105, 13);
            this.labelMinPrice.TabIndex = 8;
            this.labelMinPrice.Text = "Минимальная цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(180, 50);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(111, 13);
            this.labelMaxPrice.TabIndex = 9;
            this.labelMaxPrice.Text = "Максимальная цена";
            // 
            // listViewDemandSet_Land
            // 
            this.listViewDemandSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader23,
            this.columnHeader24});
            this.listViewDemandSet_Land.FullRowSelect = true;
            this.listViewDemandSet_Land.GridLines = true;
            this.listViewDemandSet_Land.HideSelection = false;
            this.listViewDemandSet_Land.Location = new System.Drawing.Point(180, 95);
            this.listViewDemandSet_Land.MultiSelect = false;
            this.listViewDemandSet_Land.Name = "listViewDemandSet_Land";
            this.listViewDemandSet_Land.Size = new System.Drawing.Size(811, 110);
            this.listViewDemandSet_Land.TabIndex = 10;
            this.listViewDemandSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewDemandSet_Land.Visible = false;
            this.listViewDemandSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewDemandSet_Land_SelectedIndexChanged);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "ФИО Клиента";
            this.columnHeader15.Width = 90;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ФИО Риелтора";
            this.columnHeader16.Width = 90;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Минимальная площадь";
            this.columnHeader17.Width = 135;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Максимальная площадь";
            this.columnHeader18.Width = 140;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Минимальная цена";
            this.columnHeader23.Width = 110;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Максимальная цена";
            this.columnHeader24.Width = 120;
            // 
            // listViewDemandSet__House
            // 
            this.listViewDemandSet__House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader21,
            this.columnHeader22});
            this.listViewDemandSet__House.FullRowSelect = true;
            this.listViewDemandSet__House.GridLines = true;
            this.listViewDemandSet__House.HideSelection = false;
            this.listViewDemandSet__House.Location = new System.Drawing.Point(180, 95);
            this.listViewDemandSet__House.MultiSelect = false;
            this.listViewDemandSet__House.Name = "listViewDemandSet__House";
            this.listViewDemandSet__House.Size = new System.Drawing.Size(811, 110);
            this.listViewDemandSet__House.TabIndex = 11;
            this.listViewDemandSet__House.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSet__House.View = System.Windows.Forms.View.Details;
            this.listViewDemandSet__House.Visible = false;
            this.listViewDemandSet__House.SelectedIndexChanged += new System.EventHandler(this.listViewDemandSet__House_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ФИО Клиента";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ФИО Риелтора";
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Минимальная площадь";
            this.columnHeader11.Width = 135;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Максимальная площадь";
            this.columnHeader12.Width = 140;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Минимальный этаж";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Максимальный этаж";
            this.columnHeader14.Width = 120;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Минимальная цена";
            this.columnHeader21.Width = 120;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Максимальная цена";
            this.columnHeader22.Width = 120;
            // 
            // listViewDemandSet_Apartment
            // 
            this.listViewDemandSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader19,
            this.columnHeader20});
            this.listViewDemandSet_Apartment.FullRowSelect = true;
            this.listViewDemandSet_Apartment.GridLines = true;
            this.listViewDemandSet_Apartment.HideSelection = false;
            this.listViewDemandSet_Apartment.Location = new System.Drawing.Point(180, 95);
            this.listViewDemandSet_Apartment.MultiSelect = false;
            this.listViewDemandSet_Apartment.Name = "listViewDemandSet_Apartment";
            this.listViewDemandSet_Apartment.Size = new System.Drawing.Size(811, 110);
            this.listViewDemandSet_Apartment.TabIndex = 12;
            this.listViewDemandSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSet_Apartment.View = System.Windows.Forms.View.Details;
            this.listViewDemandSet_Apartment.SelectedIndexChanged += new System.EventHandler(this.listViewDemandSet_Apartment_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО Клиента";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО Риелтора";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Минимальная площадь";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Максимальная площадь";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Минимальное кол-во комнат";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Максимальное кол-во комнат";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Минимальный этаж";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Максимальный этаж";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Минимальная цена";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Максимальная цена";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(916, 211);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(833, 211);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(752, 211);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.Location = new System.Drawing.Point(310, 28);
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinArea.TabIndex = 29;
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.Location = new System.Drawing.Point(310, 68);
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxArea.TabIndex = 30;
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.Location = new System.Drawing.Point(570, 29);
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinRooms.TabIndex = 31;
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.Location = new System.Drawing.Point(440, 29);
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinFloor.TabIndex = 32;
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.Location = new System.Drawing.Point(440, 69);
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxFloor.TabIndex = 33;
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Location = new System.Drawing.Point(440, 13);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(108, 13);
            this.labelMinFloor.TabIndex = 34;
            this.labelMinFloor.Text = "Минимальный этаж";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(310, 12);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(126, 13);
            this.labelMinArea.TabIndex = 35;
            this.labelMinArea.Text = "Минимальная площадь";
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Location = new System.Drawing.Point(570, 13);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(154, 13);
            this.labelMinRooms.TabIndex = 36;
            this.labelMinRooms.Text = "Минимальное кол-во комнат";
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Location = new System.Drawing.Point(440, 52);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(114, 13);
            this.labelMaxFloor.TabIndex = 37;
            this.labelMaxFloor.Text = "Максимальный этаж";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Location = new System.Drawing.Point(570, 54);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(160, 13);
            this.labelMaxRooms.TabIndex = 38;
            this.labelMaxRooms.Text = "Максимальное кол-во комнат";
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Location = new System.Drawing.Point(310, 52);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(132, 13);
            this.labelMaxArea.TabIndex = 39;
            this.labelMaxArea.Text = "Максимальная площадь";
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.Location = new System.Drawing.Point(570, 69);
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxRooms.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 237);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.textBoxMinFloor);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.textBoxMaxArea);
            this.Controls.Add(this.textBoxMinArea);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDemandSet_Apartment);
            this.Controls.Add(this.listViewDemandSet__House);
            this.Controls.Add(this.listViewDemandSet_Land);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.comboBoxClients);
            this.Name = "FormDemand";
            this.Text = " Потребности";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.ListView listViewDemandSet_Land;
        private System.Windows.Forms.ListView listViewDemandSet__House;
        private System.Windows.Forms.ListView listViewDemandSet_Apartment;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.TextBox textBoxMinArea;
        private System.Windows.Forms.TextBox textBoxMaxArea;
        private System.Windows.Forms.TextBox textBoxMinRooms;
        private System.Windows.Forms.TextBox textBoxMinFloor;
        private System.Windows.Forms.TextBox textBoxMaxFloor;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.TextBox textBoxMaxRooms;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}