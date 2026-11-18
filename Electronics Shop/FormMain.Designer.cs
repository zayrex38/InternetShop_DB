namespace Electronics_Shop
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            WHY_BD = new Label();
            comboBoxTables_why_BD = new ComboBox();
            panelCustomers = new Panel();
            textBox_password = new TextBox();
            password = new Label();
            textBox_Login = new TextBox();
            login = new Label();
            textBox_Email = new TextBox();
            email = new Label();
            textBox1_address = new TextBox();
            label_Address = new Label();
            dateTimePicker_Birth_Date = new DateTimePicker();
            birth_date = new Label();
            textBox_middle_name = new TextBox();
            middle_name = new Label();
            textBox_first_name = new TextBox();
            first_name = new Label();
            textBox_last_name = new TextBox();
            last_name = new Label();
            panel_couries = new Panel();
            contact_box = new TextBox();
            label1 = new Label();
            text_box_middle_name_couriers = new TextBox();
            middle_name_couriers = new Label();
            textBox_first_name_couriers = new TextBox();
            first_name_couriers = new Label();
            textBox_last_name_couriers = new TextBox();
            last_name_couriers = new Label();
            panel_orders = new Panel();
            comboBox_customers_orders = new ComboBox();
            comboBox_courier_orders = new ComboBox();
            customers_order = new Label();
            courier_order = new Label();
            status_complete = new RadioButton();
            status_delivery = new RadioButton();
            status_confirmed = new RadioButton();
            status_create = new RadioButton();
            dateTimePicker_order_date_orders = new DateTimePicker();
            order_date_orders = new Label();
            dateTimePicker_desired_date_orders = new DateTimePicker();
            Status_order = new Label();
            desired_date_orders = new Label();
            textBox_delivery_adress_orders = new TextBox();
            delivery_adress_orders = new Label();
            panel_products = new Panel();
            richTextBox_specifications_products = new RichTextBox();
            specifications_products = new Label();
            numericUpDown_price_products = new NumericUpDown();
            price_products = new Label();
            textBox_manufacturer_products = new TextBox();
            manufactorer_products = new Label();
            comboBox_category = new ComboBox();
            Category_products = new Label();
            name_products_products = new TextBox();
            label5 = new Label();
            panel_sold_products = new Panel();
            comboBox_id_order_sold_products = new ComboBox();
            id_order_sold_products = new Label();
            comboBox_sold_products = new ComboBox();
            label2 = new Label();
            dateTimePicker_date_sold_sold_products = new DateTimePicker();
            date_sold_sold_products = new Label();
            numericUpDown_price_sold_sold_products = new NumericUpDown();
            price_sold_sold_products = new Label();
            numericUpDown1 = new NumericUpDown();
            quantity_sold_products = new Label();
            dataGridViewMain = new DataGridView();
            delete_button = new Button();
            box_text_find = new TextBox();
            button_find = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            panelCustomers.SuspendLayout();
            panel_couries.SuspendLayout();
            panel_orders.SuspendLayout();
            panel_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price_products).BeginInit();
            panel_sold_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price_sold_sold_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1088, 480);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(176, 22);
            button1.TabIndex = 0;
            button1.Text = "Сохранить изменения";
            button1.UseVisualStyleBackColor = true;
            button1.Click += save_click;
            // 
            // button2
            // 
            button2.Location = new Point(906, 480);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(176, 22);
            button2.TabIndex = 1;
            button2.Text = "Отменить изменения";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cancel_click;
            // 
            // WHY_BD
            // 
            WHY_BD.AutoSize = true;
            WHY_BD.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WHY_BD.Location = new Point(10, 17);
            WHY_BD.Name = "WHY_BD";
            WHY_BD.Size = new Size(151, 20);
            WHY_BD.TabIndex = 2;
            WHY_BD.Text = "Выбор базы данных";
            // 
            // comboBoxTables_why_BD
            // 
            comboBoxTables_why_BD.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTables_why_BD.FormattingEnabled = true;
            comboBoxTables_why_BD.Items.AddRange(new object[] { "Покупатели", "Курьеры", "Заказы", "Товары", "Проданные товары" });
            comboBoxTables_why_BD.Location = new Point(167, 14);
            comboBoxTables_why_BD.Margin = new Padding(3, 2, 3, 2);
            comboBoxTables_why_BD.Name = "comboBoxTables_why_BD";
            comboBoxTables_why_BD.Size = new Size(160, 23);
            comboBoxTables_why_BD.TabIndex = 3;
            comboBoxTables_why_BD.SelectedIndexChanged += comboBoxTables_why_BD_SelectedIndexChanged;
            // 
            // panelCustomers
            // 
            panelCustomers.BorderStyle = BorderStyle.FixedSingle;
            panelCustomers.Controls.Add(textBox_password);
            panelCustomers.Controls.Add(password);
            panelCustomers.Controls.Add(textBox_Login);
            panelCustomers.Controls.Add(login);
            panelCustomers.Controls.Add(textBox_Email);
            panelCustomers.Controls.Add(email);
            panelCustomers.Controls.Add(textBox1_address);
            panelCustomers.Controls.Add(label_Address);
            panelCustomers.Controls.Add(dateTimePicker_Birth_Date);
            panelCustomers.Controls.Add(birth_date);
            panelCustomers.Controls.Add(textBox_middle_name);
            panelCustomers.Controls.Add(middle_name);
            panelCustomers.Controls.Add(textBox_first_name);
            panelCustomers.Controls.Add(first_name);
            panelCustomers.Controls.Add(textBox_last_name);
            panelCustomers.Controls.Add(last_name);
            panelCustomers.Location = new Point(10, 40);
            panelCustomers.Margin = new Padding(3, 2, 3, 2);
            panelCustomers.Name = "panelCustomers";
            panelCustomers.Size = new Size(320, 256);
            panelCustomers.TabIndex = 4;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(79, 187);
            textBox_password.Margin = new Padding(3, 2, 3, 2);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(211, 23);
            textBox_password.TabIndex = 15;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(10, 189);
            password.Name = "password";
            password.Size = new Size(49, 15);
            password.TabIndex = 14;
            password.Text = "Пароль";
            // 
            // textBox_Login
            // 
            textBox_Login.Location = new Point(79, 162);
            textBox_Login.Margin = new Padding(3, 2, 3, 2);
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(211, 23);
            textBox_Login.TabIndex = 13;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(10, 164);
            login.Name = "login";
            login.Size = new Size(41, 15);
            login.TabIndex = 12;
            login.Text = "Логин";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(79, 137);
            textBox_Email.Margin = new Padding(3, 2, 3, 2);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(211, 23);
            textBox_Email.TabIndex = 11;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(10, 140);
            email.Name = "email";
            email.Size = new Size(41, 15);
            email.TabIndex = 10;
            email.Text = "Почта";
            // 
            // textBox1_address
            // 
            textBox1_address.Location = new Point(79, 112);
            textBox1_address.Margin = new Padding(3, 2, 3, 2);
            textBox1_address.Name = "textBox1_address";
            textBox1_address.Size = new Size(211, 23);
            textBox1_address.TabIndex = 9;
            textBox1_address.TextChanged += textBox1_TextChanged;
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Location = new Point(10, 115);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(40, 15);
            label_Address.TabIndex = 8;
            label_Address.Text = "Адрес";
            // 
            // dateTimePicker_Birth_Date
            // 
            dateTimePicker_Birth_Date.Location = new Point(118, 88);
            dateTimePicker_Birth_Date.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_Birth_Date.Name = "dateTimePicker_Birth_Date";
            dateTimePicker_Birth_Date.Size = new Size(172, 23);
            dateTimePicker_Birth_Date.TabIndex = 7;
            // 
            // birth_date
            // 
            birth_date.AutoSize = true;
            birth_date.Location = new Point(10, 88);
            birth_date.Name = "birth_date";
            birth_date.Size = new Size(90, 15);
            birth_date.TabIndex = 6;
            birth_date.Text = "Дата рождения";
            // 
            // textBox_middle_name
            // 
            textBox_middle_name.Location = new Point(79, 58);
            textBox_middle_name.Margin = new Padding(3, 2, 3, 2);
            textBox_middle_name.Name = "textBox_middle_name";
            textBox_middle_name.Size = new Size(211, 23);
            textBox_middle_name.TabIndex = 5;
            // 
            // middle_name
            // 
            middle_name.AutoSize = true;
            middle_name.Location = new Point(10, 60);
            middle_name.Name = "middle_name";
            middle_name.Size = new Size(58, 15);
            middle_name.TabIndex = 4;
            middle_name.Text = "Отчество";
            // 
            // textBox_first_name
            // 
            textBox_first_name.Location = new Point(79, 33);
            textBox_first_name.Margin = new Padding(3, 2, 3, 2);
            textBox_first_name.Name = "textBox_first_name";
            textBox_first_name.Size = new Size(211, 23);
            textBox_first_name.TabIndex = 3;
            // 
            // first_name
            // 
            first_name.AutoSize = true;
            first_name.Location = new Point(10, 35);
            first_name.Name = "first_name";
            first_name.Size = new Size(31, 15);
            first_name.TabIndex = 2;
            first_name.Text = "Имя";
            // 
            // textBox_last_name
            // 
            textBox_last_name.Location = new Point(79, 8);
            textBox_last_name.Margin = new Padding(3, 2, 3, 2);
            textBox_last_name.Name = "textBox_last_name";
            textBox_last_name.Size = new Size(211, 23);
            textBox_last_name.TabIndex = 1;
            // 
            // last_name
            // 
            last_name.AutoSize = true;
            last_name.Location = new Point(10, 10);
            last_name.Name = "last_name";
            last_name.Size = new Size(58, 15);
            last_name.TabIndex = 0;
            last_name.Text = "Фамилия";
            last_name.Click += label2_Click;
            // 
            // panel_couries
            // 
            panel_couries.BorderStyle = BorderStyle.FixedSingle;
            panel_couries.Controls.Add(contact_box);
            panel_couries.Controls.Add(label1);
            panel_couries.Controls.Add(text_box_middle_name_couriers);
            panel_couries.Controls.Add(middle_name_couriers);
            panel_couries.Controls.Add(textBox_first_name_couriers);
            panel_couries.Controls.Add(first_name_couriers);
            panel_couries.Controls.Add(textBox_last_name_couriers);
            panel_couries.Controls.Add(last_name_couriers);
            panel_couries.Location = new Point(10, 40);
            panel_couries.Margin = new Padding(3, 2, 3, 2);
            panel_couries.Name = "panel_couries";
            panel_couries.Size = new Size(320, 256);
            panel_couries.TabIndex = 5;
            // 
            // contact_box
            // 
            contact_box.Location = new Point(79, 82);
            contact_box.Margin = new Padding(3, 2, 3, 2);
            contact_box.Name = "contact_box";
            contact_box.Size = new Size(211, 23);
            contact_box.TabIndex = 7;
            contact_box.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 85);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 6;
            label1.Text = "Контакт";
            // 
            // text_box_middle_name_couriers
            // 
            text_box_middle_name_couriers.Location = new Point(79, 58);
            text_box_middle_name_couriers.Margin = new Padding(3, 2, 3, 2);
            text_box_middle_name_couriers.Name = "text_box_middle_name_couriers";
            text_box_middle_name_couriers.Size = new Size(211, 23);
            text_box_middle_name_couriers.TabIndex = 5;
            // 
            // middle_name_couriers
            // 
            middle_name_couriers.AutoSize = true;
            middle_name_couriers.Location = new Point(10, 60);
            middle_name_couriers.Name = "middle_name_couriers";
            middle_name_couriers.Size = new Size(58, 15);
            middle_name_couriers.TabIndex = 4;
            middle_name_couriers.Text = "Отчество";
            // 
            // textBox_first_name_couriers
            // 
            textBox_first_name_couriers.Location = new Point(79, 33);
            textBox_first_name_couriers.Margin = new Padding(3, 2, 3, 2);
            textBox_first_name_couriers.Name = "textBox_first_name_couriers";
            textBox_first_name_couriers.Size = new Size(211, 23);
            textBox_first_name_couriers.TabIndex = 3;
            // 
            // first_name_couriers
            // 
            first_name_couriers.AutoSize = true;
            first_name_couriers.Location = new Point(10, 35);
            first_name_couriers.Name = "first_name_couriers";
            first_name_couriers.Size = new Size(31, 15);
            first_name_couriers.TabIndex = 2;
            first_name_couriers.Text = "Имя";
            // 
            // textBox_last_name_couriers
            // 
            textBox_last_name_couriers.Location = new Point(79, 8);
            textBox_last_name_couriers.Margin = new Padding(3, 2, 3, 2);
            textBox_last_name_couriers.Name = "textBox_last_name_couriers";
            textBox_last_name_couriers.Size = new Size(211, 23);
            textBox_last_name_couriers.TabIndex = 1;
            // 
            // last_name_couriers
            // 
            last_name_couriers.AutoSize = true;
            last_name_couriers.Location = new Point(10, 10);
            last_name_couriers.Name = "last_name_couriers";
            last_name_couriers.Size = new Size(58, 15);
            last_name_couriers.TabIndex = 0;
            last_name_couriers.Text = "Фамилия";
            // 
            // panel_orders
            // 
            panel_orders.BorderStyle = BorderStyle.FixedSingle;
            panel_orders.Controls.Add(comboBox_customers_orders);
            panel_orders.Controls.Add(comboBox_courier_orders);
            panel_orders.Controls.Add(customers_order);
            panel_orders.Controls.Add(courier_order);
            panel_orders.Controls.Add(status_complete);
            panel_orders.Controls.Add(status_delivery);
            panel_orders.Controls.Add(status_confirmed);
            panel_orders.Controls.Add(status_create);
            panel_orders.Controls.Add(dateTimePicker_order_date_orders);
            panel_orders.Controls.Add(order_date_orders);
            panel_orders.Controls.Add(dateTimePicker_desired_date_orders);
            panel_orders.Controls.Add(Status_order);
            panel_orders.Controls.Add(desired_date_orders);
            panel_orders.Controls.Add(textBox_delivery_adress_orders);
            panel_orders.Controls.Add(delivery_adress_orders);
            panel_orders.Location = new Point(10, 40);
            panel_orders.Margin = new Padding(3, 2, 3, 2);
            panel_orders.Name = "panel_orders";
            panel_orders.Size = new Size(320, 256);
            panel_orders.TabIndex = 6;
            // 
            // comboBox_customers_orders
            // 
            comboBox_customers_orders.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_customers_orders.FormattingEnabled = true;
            comboBox_customers_orders.Location = new Point(79, 209);
            comboBox_customers_orders.Name = "comboBox_customers_orders";
            comboBox_customers_orders.Size = new Size(121, 23);
            comboBox_customers_orders.TabIndex = 18;
            comboBox_customers_orders.SelectedIndexChanged += comboBox_customers_orders_SelectedIndexChanged;
            // 
            // comboBox_courier_orders
            // 
            comboBox_courier_orders.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_courier_orders.FormattingEnabled = true;
            comboBox_courier_orders.Location = new Point(79, 180);
            comboBox_courier_orders.Name = "comboBox_courier_orders";
            comboBox_courier_orders.Size = new Size(121, 23);
            comboBox_courier_orders.TabIndex = 17;
            comboBox_courier_orders.SelectedIndexChanged += comboBox_courier_orders_SelectedIndexChanged;
            // 
            // customers_order
            // 
            customers_order.AutoSize = true;
            customers_order.Location = new Point(7, 212);
            customers_order.Name = "customers_order";
            customers_order.Size = new Size(72, 15);
            customers_order.TabIndex = 16;
            customers_order.Text = "Покупатель";
            // 
            // courier_order
            // 
            courier_order.AutoSize = true;
            courier_order.Location = new Point(11, 181);
            courier_order.Name = "courier_order";
            courier_order.Size = new Size(46, 15);
            courier_order.TabIndex = 15;
            courier_order.Text = "Курьер";
            // 
            // status_complete
            // 
            status_complete.AutoSize = true;
            status_complete.Location = new Point(82, 150);
            status_complete.Margin = new Padding(3, 2, 3, 2);
            status_complete.Name = "status_complete";
            status_complete.Size = new Size(82, 19);
            status_complete.TabIndex = 14;
            status_complete.TabStop = true;
            status_complete.Text = "Выполнен";
            status_complete.UseVisualStyleBackColor = true;
            // 
            // status_delivery
            // 
            status_delivery.AutoSize = true;
            status_delivery.Location = new Point(82, 128);
            status_delivery.Margin = new Padding(3, 2, 3, 2);
            status_delivery.Name = "status_delivery";
            status_delivery.Size = new Size(91, 19);
            status_delivery.TabIndex = 13;
            status_delivery.TabStop = true;
            status_delivery.Text = "На доставке";
            status_delivery.UseVisualStyleBackColor = true;
            // 
            // status_confirmed
            // 
            status_confirmed.AutoSize = true;
            status_confirmed.Location = new Point(82, 105);
            status_confirmed.Margin = new Padding(3, 2, 3, 2);
            status_confirmed.Name = "status_confirmed";
            status_confirmed.Size = new Size(99, 19);
            status_confirmed.TabIndex = 12;
            status_confirmed.TabStop = true;
            status_confirmed.Text = "Подтвержден";
            status_confirmed.UseVisualStyleBackColor = true;
            // 
            // status_create
            // 
            status_create.AutoSize = true;
            status_create.Location = new Point(82, 86);
            status_create.Margin = new Padding(3, 2, 3, 2);
            status_create.Name = "status_create";
            status_create.Size = new Size(64, 19);
            status_create.TabIndex = 11;
            status_create.TabStop = true;
            status_create.Text = "Создан";
            status_create.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_order_date_orders
            // 
            dateTimePicker_order_date_orders.Location = new Point(116, 56);
            dateTimePicker_order_date_orders.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_order_date_orders.Name = "dateTimePicker_order_date_orders";
            dateTimePicker_order_date_orders.Size = new Size(176, 23);
            dateTimePicker_order_date_orders.TabIndex = 10;
            dateTimePicker_order_date_orders.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // order_date_orders
            // 
            order_date_orders.AutoSize = true;
            order_date_orders.Location = new Point(10, 58);
            order_date_orders.Name = "order_date_orders";
            order_date_orders.Size = new Size(84, 15);
            order_date_orders.TabIndex = 9;
            order_date_orders.Text = "Дата доставки";
            // 
            // dateTimePicker_desired_date_orders
            // 
            dateTimePicker_desired_date_orders.Location = new Point(116, 33);
            dateTimePicker_desired_date_orders.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_desired_date_orders.Name = "dateTimePicker_desired_date_orders";
            dateTimePicker_desired_date_orders.Size = new Size(176, 23);
            dateTimePicker_desired_date_orders.TabIndex = 8;
            // 
            // Status_order
            // 
            Status_order.AutoSize = true;
            Status_order.Location = new Point(10, 85);
            Status_order.Name = "Status_order";
            Status_order.Size = new Size(43, 15);
            Status_order.TabIndex = 6;
            Status_order.Text = "Статус";
            Status_order.Click += Status_order_Click;
            // 
            // desired_date_orders
            // 
            desired_date_orders.AutoSize = true;
            desired_date_orders.Location = new Point(10, 35);
            desired_date_orders.Name = "desired_date_orders";
            desired_date_orders.Size = new Size(90, 15);
            desired_date_orders.TabIndex = 2;
            desired_date_orders.Text = "Желаемая дата";
            // 
            // textBox_delivery_adress_orders
            // 
            textBox_delivery_adress_orders.Location = new Point(79, 8);
            textBox_delivery_adress_orders.Margin = new Padding(3, 2, 3, 2);
            textBox_delivery_adress_orders.Name = "textBox_delivery_adress_orders";
            textBox_delivery_adress_orders.Size = new Size(211, 23);
            textBox_delivery_adress_orders.TabIndex = 1;
            // 
            // delivery_adress_orders
            // 
            delivery_adress_orders.AutoSize = true;
            delivery_adress_orders.Location = new Point(10, 10);
            delivery_adress_orders.Name = "delivery_adress_orders";
            delivery_adress_orders.Size = new Size(40, 15);
            delivery_adress_orders.TabIndex = 0;
            delivery_adress_orders.Text = "Адрес";
            // 
            // panel_products
            // 
            panel_products.BorderStyle = BorderStyle.FixedSingle;
            panel_products.Controls.Add(richTextBox_specifications_products);
            panel_products.Controls.Add(specifications_products);
            panel_products.Controls.Add(numericUpDown_price_products);
            panel_products.Controls.Add(price_products);
            panel_products.Controls.Add(textBox_manufacturer_products);
            panel_products.Controls.Add(manufactorer_products);
            panel_products.Controls.Add(comboBox_category);
            panel_products.Controls.Add(Category_products);
            panel_products.Controls.Add(name_products_products);
            panel_products.Controls.Add(label5);
            panel_products.Location = new Point(10, 40);
            panel_products.Margin = new Padding(3, 2, 3, 2);
            panel_products.Name = "panel_products";
            panel_products.Size = new Size(320, 256);
            panel_products.TabIndex = 7;
            // 
            // richTextBox_specifications_products
            // 
            richTextBox_specifications_products.Location = new Point(116, 112);
            richTextBox_specifications_products.Margin = new Padding(3, 2, 3, 2);
            richTextBox_specifications_products.Name = "richTextBox_specifications_products";
            richTextBox_specifications_products.Size = new Size(190, 140);
            richTextBox_specifications_products.TabIndex = 9;
            richTextBox_specifications_products.Text = "";
            richTextBox_specifications_products.TextChanged += richTextBox_specifications_products_TextChanged;
            // 
            // specifications_products
            // 
            specifications_products.AutoSize = true;
            specifications_products.Location = new Point(7, 110);
            specifications_products.Name = "specifications_products";
            specifications_products.Size = new Size(95, 15);
            specifications_products.TabIndex = 8;
            specifications_products.Text = "Характеристики";
            // 
            // numericUpDown_price_products
            // 
            numericUpDown_price_products.DecimalPlaces = 2;
            numericUpDown_price_products.Location = new Point(60, 88);
            numericUpDown_price_products.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_price_products.Maximum = new decimal(new int[] { -159383553, 46653770, 5421, 0 });
            numericUpDown_price_products.Name = "numericUpDown_price_products";
            numericUpDown_price_products.Size = new Size(131, 23);
            numericUpDown_price_products.TabIndex = 7;
            numericUpDown_price_products.ThousandsSeparator = true;
            // 
            // price_products
            // 
            price_products.AutoSize = true;
            price_products.Location = new Point(10, 88);
            price_products.Name = "price_products";
            price_products.Size = new Size(35, 15);
            price_products.TabIndex = 6;
            price_products.Text = "Цена";
            // 
            // textBox_manufacturer_products
            // 
            textBox_manufacturer_products.Location = new Point(116, 60);
            textBox_manufacturer_products.Margin = new Padding(3, 2, 3, 2);
            textBox_manufacturer_products.Name = "textBox_manufacturer_products";
            textBox_manufacturer_products.Size = new Size(179, 23);
            textBox_manufacturer_products.TabIndex = 5;
            // 
            // manufactorer_products
            // 
            manufactorer_products.AutoSize = true;
            manufactorer_products.Location = new Point(10, 62);
            manufactorer_products.Name = "manufactorer_products";
            manufactorer_products.Size = new Size(92, 15);
            manufactorer_products.TabIndex = 4;
            manufactorer_products.Text = "Производитель";
            // 
            // comboBox_category
            // 
            comboBox_category.FormattingEnabled = true;
            comboBox_category.Items.AddRange(new object[] { "Видеокарта", "Процессор" });
            comboBox_category.Location = new Point(83, 34);
            comboBox_category.Margin = new Padding(3, 2, 3, 2);
            comboBox_category.Name = "comboBox_category";
            comboBox_category.Size = new Size(133, 23);
            comboBox_category.TabIndex = 3;
            // 
            // Category_products
            // 
            Category_products.AutoSize = true;
            Category_products.Location = new Point(7, 37);
            Category_products.Name = "Category_products";
            Category_products.Size = new Size(63, 15);
            Category_products.TabIndex = 2;
            Category_products.Text = "Категория";
            // 
            // name_products_products
            // 
            name_products_products.Location = new Point(82, 8);
            name_products_products.Margin = new Padding(3, 2, 3, 2);
            name_products_products.Name = "name_products_products";
            name_products_products.Size = new Size(211, 23);
            name_products_products.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 10);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Название";
            // 
            // panel_sold_products
            // 
            panel_sold_products.BorderStyle = BorderStyle.FixedSingle;
            panel_sold_products.Controls.Add(comboBox_id_order_sold_products);
            panel_sold_products.Controls.Add(id_order_sold_products);
            panel_sold_products.Controls.Add(comboBox_sold_products);
            panel_sold_products.Controls.Add(label2);
            panel_sold_products.Controls.Add(dateTimePicker_date_sold_sold_products);
            panel_sold_products.Controls.Add(date_sold_sold_products);
            panel_sold_products.Controls.Add(numericUpDown_price_sold_sold_products);
            panel_sold_products.Controls.Add(price_sold_sold_products);
            panel_sold_products.Controls.Add(numericUpDown1);
            panel_sold_products.Controls.Add(quantity_sold_products);
            panel_sold_products.Location = new Point(10, 40);
            panel_sold_products.Margin = new Padding(3, 2, 3, 2);
            panel_sold_products.Name = "panel_sold_products";
            panel_sold_products.Size = new Size(320, 256);
            panel_sold_products.TabIndex = 8;
            // 
            // comboBox_id_order_sold_products
            // 
            comboBox_id_order_sold_products.FormattingEnabled = true;
            comboBox_id_order_sold_products.Location = new Point(115, 151);
            comboBox_id_order_sold_products.Name = "comboBox_id_order_sold_products";
            comboBox_id_order_sold_products.Size = new Size(121, 23);
            comboBox_id_order_sold_products.TabIndex = 9;
            comboBox_id_order_sold_products.SelectedIndexChanged += comboBox_id_order_sold_products_SelectedIndexChanged;
            // 
            // id_order_sold_products
            // 
            id_order_sold_products.AutoSize = true;
            id_order_sold_products.Location = new Point(10, 152);
            id_order_sold_products.Name = "id_order_sold_products";
            id_order_sold_products.Size = new Size(72, 15);
            id_order_sold_products.TabIndex = 8;
            id_order_sold_products.Text = "Айди заказа";
            // 
            // comboBox_sold_products
            // 
            comboBox_sold_products.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_sold_products.ForeColor = SystemColors.WindowFrame;
            comboBox_sold_products.FormattingEnabled = true;
            comboBox_sold_products.Location = new Point(125, 20);
            comboBox_sold_products.Margin = new Padding(3, 2, 3, 2);
            comboBox_sold_products.Name = "comboBox_sold_products";
            comboBox_sold_products.Size = new Size(181, 23);
            comboBox_sold_products.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 22);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 6;
            label2.Text = "Название товара";
            // 
            // dateTimePicker_date_sold_sold_products
            // 
            dateTimePicker_date_sold_sold_products.Location = new Point(116, 115);
            dateTimePicker_date_sold_sold_products.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_date_sold_sold_products.Name = "dateTimePicker_date_sold_sold_products";
            dateTimePicker_date_sold_sold_products.Size = new Size(195, 23);
            dateTimePicker_date_sold_sold_products.TabIndex = 5;
            dateTimePicker_date_sold_sold_products.ValueChanged += dateTimePicker_date_sold_sold_products_ValueChanged;
            // 
            // date_sold_sold_products
            // 
            date_sold_sold_products.AutoSize = true;
            date_sold_sold_products.Location = new Point(10, 120);
            date_sold_sold_products.Name = "date_sold_sold_products";
            date_sold_sold_products.Size = new Size(84, 15);
            date_sold_sold_products.TabIndex = 4;
            date_sold_sold_products.Text = "Дата продажи";
            date_sold_sold_products.Click += date_sold_sold_products_Click;
            // 
            // numericUpDown_price_sold_sold_products
            // 
            numericUpDown_price_sold_sold_products.Location = new Point(115, 80);
            numericUpDown_price_sold_sold_products.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_price_sold_sold_products.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericUpDown_price_sold_sold_products.Name = "numericUpDown_price_sold_sold_products";
            numericUpDown_price_sold_sold_products.Size = new Size(87, 23);
            numericUpDown_price_sold_sold_products.TabIndex = 3;
            // 
            // price_sold_sold_products
            // 
            price_sold_sold_products.AutoSize = true;
            price_sold_sold_products.Location = new Point(11, 82);
            price_sold_sold_products.Name = "price_sold_sold_products";
            price_sold_sold_products.Size = new Size(87, 15);
            price_sold_sold_products.TabIndex = 2;
            price_sold_sold_products.Text = "Цена продажи";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(219, 55);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(87, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // quantity_sold_products
            // 
            quantity_sold_products.AutoSize = true;
            quantity_sold_products.Location = new Point(11, 58);
            quantity_sold_products.Name = "quantity_sold_products";
            quantity_sold_products.Size = new Size(183, 15);
            quantity_sold_products.TabIndex = 0;
            quantity_sold_products.Text = "Количество проданных товаров";
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(354, 40);
            dataGridViewMain.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowHeadersWidth = 51;
            dataGridViewMain.Size = new Size(910, 301);
            dataGridViewMain.TabIndex = 9;
            dataGridViewMain.CellContentClick += dataGridViewMain_CellContentClick;
            // 
            // delete_button
            // 
            delete_button.AccessibleRole = AccessibleRole.TitleBar;
            delete_button.Location = new Point(47, 311);
            delete_button.Margin = new Padding(3, 2, 3, 2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(220, 22);
            delete_button.TabIndex = 10;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // box_text_find
            // 
            box_text_find.Location = new Point(482, 354);
            box_text_find.Margin = new Padding(3, 2, 3, 2);
            box_text_find.Name = "box_text_find";
            box_text_find.Size = new Size(265, 23);
            box_text_find.TabIndex = 11;
            // 
            // button_find
            // 
            button_find.Location = new Point(354, 354);
            button_find.Margin = new Padding(3, 2, 3, 2);
            button_find.Name = "button_find";
            button_find.Size = new Size(123, 22);
            button_find.TabIndex = 12;
            button_find.Text = "Найти";
            button_find.UseVisualStyleBackColor = true;
            button_find.Click += x_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1276, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(108, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 518);
            Controls.Add(panel_sold_products);
            Controls.Add(panel_orders);
            Controls.Add(button_find);
            Controls.Add(box_text_find);
            Controls.Add(delete_button);
            Controls.Add(dataGridViewMain);
            Controls.Add(panel_products);
            Controls.Add(panel_couries);
            Controls.Add(panelCustomers);
            Controls.Add(comboBoxTables_why_BD);
            Controls.Add(WHY_BD);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "InternetShop_DB";
            panelCustomers.ResumeLayout(false);
            panelCustomers.PerformLayout();
            panel_couries.ResumeLayout(false);
            panel_couries.PerformLayout();
            panel_orders.ResumeLayout(false);
            panel_orders.PerformLayout();
            panel_products.ResumeLayout(false);
            panel_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price_products).EndInit();
            panel_sold_products.ResumeLayout(false);
            panel_sold_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price_sold_sold_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label WHY_BD;
        private ComboBox comboBoxTables_why_BD;
        private Panel panelCustomers;
        private Label last_name;
        private TextBox textBox_first_name;
        private Label first_name;
        private TextBox textBox_last_name;
        private Label birth_date;
        private TextBox textBox_middle_name;
        private Label middle_name;
        private TextBox textBox1_address;
        private Label label_Address;
        private DateTimePicker dateTimePicker_Birth_Date;
        private TextBox textBox_password;
        private Label password;
        private TextBox textBox_Login;
        private Label login;
        private TextBox textBox_Email;
        private Label email;
        private Panel panel_couries;
        private TextBox text_box_middle_name_couriers;
        private Label middle_name_couriers;
        private TextBox textBox_first_name_couriers;
        private Label first_name_couriers;
        private TextBox textBox_last_name_couriers;
        private Label last_name_couriers;
        private TextBox contact_box;
        private Label label1;
        private Panel panel_orders;
        private DateTimePicker dateTimePicker_order_date_orders;
        private Label order_date_orders;
        private DateTimePicker dateTimePicker_desired_date_orders;
        private Label Status_order;
        private Label desired_date_orders;
        private TextBox textBox_delivery_adress_orders;
        private Label delivery_adress_orders;
        private Panel panel_products;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox name_products_products;
        private Label label5;
        private RadioButton status_complete;
        private RadioButton status_delivery;
        private RadioButton status_confirmed;
        private RadioButton status_create;
        private Label price_products;
        private TextBox textBox_manufacturer_products;
        private Label manufactorer_products;
        private ComboBox comboBox_courier_orders;
        private Label Category_products;
        private RichTextBox richTextBox_specifications_products;
        private Label specifications_products;
        private NumericUpDown numericUpDown_price_products;
        private Panel panel_sold_products;
        private Label date_sold_sold_products;
        private NumericUpDown numericUpDown_price_sold_sold_products;
        private Label price_sold_sold_products;
        private NumericUpDown numericUpDown1;
        private Label quantity_sold_products;
        private DateTimePicker dateTimePicker_date_sold_sold_products;
        private ComboBox comboBox_sold_products;
        private Label label2;
        private DataGridView dataGridViewMain;
        private Button delete_button;
        private TextBox box_text_find;
        private Button button_find;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ComboBox comboBox_category;
        private ComboBox comboBox_customers_orders;
        private Label customers_order;
        private Label courier_order;
        private ComboBox comboBox_id_order_sold_products;
        private Label id_order_sold_products;
    }
}
