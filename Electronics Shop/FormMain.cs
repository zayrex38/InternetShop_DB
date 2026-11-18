using Electronics_Shop.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
namespace Electronics_Shop
{
    public partial class FormMain : Form
    {
        BindingList<products> productsList = new BindingList<products>
        {
            new products {id = 1, name = "NVIDIA GeForce RTX 5070", category = "Видеокарты",manufacturer = "NVIDIA", price = 1000}
        };
        BindingList<Customers> customersList = new BindingList<Customers>
{
    new Customers { id = 1, last_name = "Иванов", first_name = "Алексей", middle_name = "Сергеевич", birth_date = "01.10.2000", address = "г. Екатеринбург", email = "alex@mail.ru", login = "alexey", password = "123" }
};
        BindingList<couriers> couriersList = new BindingList<couriers>
{
    new couriers { courier_id = 1, last_name = "Петров", first_name = "Иван", middle_name = "Иванович", contact = "+79991112233" }
};
        BindingList<orders> ordersList = new BindingList<orders>
{
    new orders { id = 1, customer_id = 1, courier_id = 1, delivery_adrress = "ул. 8 Марта, 3", desired_date = "16.11.2026", order_date = "15.11.2026", status = "Создан" }
};
        BindingList<sold_products> soldProductsList = new BindingList<sold_products>
{
    new sold_products { id = 1, order_id = 1, product_id = 1, quantity = 1, sold_price = 65000, sale_data = "15.11.2026" }
};

        public FormMain()
        {
            InitializeComponent();

            comboBox_sold_products.DataSource = productsList;
            comboBox_sold_products.DisplayMember = "name";
            comboBox_sold_products.ValueMember = "id";
            comboBoxTables_why_BD.SelectedIndex = 0;

            comboBox_customers_orders.DataSource = customersList;
            comboBox_customers_orders.DisplayMember = "last_name";
            comboBox_customers_orders.ValueMember = "id";

            comboBox_courier_orders.DataSource = couriersList;
            comboBox_courier_orders.DisplayMember = "last_name";
            comboBox_courier_orders.ValueMember = "courier_id";

            comboBox_id_order_sold_products.DataSource = ordersList;
            comboBox_id_order_sold_products.DisplayMember = "id";
            comboBox_id_order_sold_products.ValueMember = "id";

            dataGridViewMain.AllowUserToAddRows = false;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Status_order_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_date_sold_sold_products_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTables_why_BD_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCustomers.Visible = false;
            panel_couries.Visible = false;
            panel_orders.Visible = false;
            panel_products.Visible = false;
            panel_sold_products.Visible = false;

            switch (comboBoxTables_why_BD.SelectedIndex)
            {
                case 0:
                    panelCustomers.Visible = true;
                    dataGridViewMain.DataSource = customersList;
                    break;
                case 1:
                    panel_couries.Visible = true;
                    dataGridViewMain.DataSource = couriersList;
                    break;
                case 2:
                    panel_orders.Visible = true;
                    dataGridViewMain.DataSource = ordersList;
                    break;
                case 3:
                    panel_products.Visible = true;
                    dataGridViewMain.DataSource = productsList;
                    break;
                case 4:
                    panel_sold_products.Visible = true;
                    dataGridViewMain.DataSource = soldProductsList;
                    break;


            }

        }

        private void save_click(object sender, EventArgs e)
        {
            SaveInputs();
            ClearInputs();

        }

        private void cancel_click(object sender, EventArgs e)
        {
            ClearInputs();

        }

        private void x_Click(object sender, EventArgs e)
        {
            SearchInputs();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.Show();
        }

        private void richTextBox_specifications_products_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearInputs()
        {
            //Курьеры
            textBox_last_name_couriers.Clear();
            textBox_first_name_couriers.Clear();
            text_box_middle_name_couriers.Clear();
            contact_box.Clear();

            //Заказы
            textBox_delivery_adress_orders.Clear();
            status_create.Checked = false;
            status_confirmed.Checked = false;
            status_delivery.Checked = false;
            status_complete.Checked = false;
            dateTimePicker_order_date_orders.Value = DateTime.Now;
            dateTimePicker_desired_date_orders.Value = DateTime.Now;

            //Покупатели
            textBox_password.Clear();
            textBox_Login.Clear();
            textBox_Email.Clear();
            textBox1_address.Clear();
            textBox_middle_name.Clear();
            textBox_last_name.Clear();
            textBox_first_name.Clear();
            comboBox_category.Text = "";

            //Товары
            name_products_products.Clear();
            textBox_manufacturer_products.Clear();
            richTextBox_specifications_products.Clear();
            numericUpDown_price_products.Value = 0;

            //Проданные товары
            numericUpDown1.Value = 1;
            numericUpDown_price_sold_sold_products.Value = 0;
            dateTimePicker_date_sold_sold_products.Value = DateTime.Now;

        }

        private void SaveInputs()
        {
            switch (comboBoxTables_why_BD.Text)
            {

                case "Покупатели":
                    customersList.Add(new Customers
                    {
                        id = customersList.Count + 1,
                        last_name = textBox_last_name.Text,
                        first_name = textBox_first_name.Text,
                        middle_name = textBox_middle_name.Text,
                        birth_date = dateTimePicker_Birth_Date.Value.ToShortDateString(),
                        address = textBox1_address.Text,
                        email = textBox_Email.Text,
                        login = textBox_Login.Text,
                        password = textBox_password.Text
                    });
                    break;

                case "Курьеры":
                    couriersList.Add(new couriers
                    {
                        courier_id = couriersList.Count + 1,
                        last_name = textBox_last_name_couriers.Text,
                        first_name = textBox_first_name_couriers.Text,
                        middle_name = text_box_middle_name_couriers.Text,
                        contact = contact_box.Text
                    });
                    break;

                case "Товары":
                    productsList.Add(new products
                    {
                        id = productsList.Count + 1,
                        name = name_products_products.Text,
                        category = comboBox_category.Text,
                        manufacturer = textBox_manufacturer_products.Text,
                        price = numericUpDown_price_products.Value,
                        specifications = richTextBox_specifications_products.Text
                    });
                    break;


                case "Заказы":
                    string selectedStatus = "Создан";
                    if (status_confirmed.Checked) selectedStatus = "Подтвержден";
                    else if (status_delivery.Checked) selectedStatus = "На доставке";
                    else if (status_complete.Checked) selectedStatus = "Выполнен";

                    ordersList.Add(new orders
                    {
                        id = ordersList.Count + 1,
                        customer_id = (int)comboBox_customers_orders.SelectedValue,
                        courier_id = (int)comboBox_courier_orders.SelectedValue,
                        delivery_adrress = textBox_delivery_adress_orders.Text,
                        desired_date = dateTimePicker_desired_date_orders.Value.ToShortDateString(),
                        order_date = dateTimePicker_order_date_orders.Value.ToShortDateString(),
                        status = selectedStatus

                    });
                    break;

                case "Проданные товары":
                    soldProductsList.Add(new sold_products
                    {
                        id = soldProductsList.Count + 1,
                        order_id = (int)comboBox_sold_products.SelectedValue,
                        product_id = productsList.Count,
                        quantity = (int)numericUpDown1.Value,
                        sold_price = numericUpDown_price_sold_sold_products.Value,
                        sale_data = dateTimePicker_date_sold_sold_products.Value.ToShortDateString()


                    });
                    break;
            }

        }

        private void DeleteInputs()
        {
            if (dataGridViewMain.CurrentRow != null)
            {
                dataGridViewMain.Rows.Remove(dataGridViewMain.CurrentRow);
            }
        }

        private void SearchInputs()
        {
            string search = box_text_find.Text.ToLower();
            dataGridViewMain.CurrentCell = null;

            for (int i = 0; i < dataGridViewMain.Rows.Count; i++)
            {
                bool find_sucsessful = false;

                for (int j = 0; j < dataGridViewMain.Columns.Count; j++)
                {
                    if (dataGridViewMain.Rows[i].Cells[j].Value != null)
                    {
                        string text_from_cell = dataGridViewMain.Rows[i].Cells[j].Value.ToString().ToLower();

                        if (text_from_cell.Contains(search))
                        {
                            find_sucsessful = true;
                        }
                    }
                }

                dataGridViewMain.Rows[i].Visible = find_sucsessful;
            }

        }

        private void date_sold_sold_products_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_courier_orders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_customers_orders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_id_order_sold_products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DeleteInputs();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 