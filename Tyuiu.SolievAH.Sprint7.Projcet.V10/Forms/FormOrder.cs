using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SolievAH.Sprint7.Project.V10.Lib;

namespace Tyuiu.SolievAH.Sprint7.Projcet.V10.Forms
{
    public partial class FormOrder : Form
    {
        public BindingList<Order> orderList;
        private BindingSource bindingSource;
        private SortOrder currentSortOrder = SortOrder.Ascending;
        public FormOrder()
        {
            InitializeComponent();
            orderList = new BindingList<Order>();

            bindingSource = new BindingSource(orderList, null);

            dataGridViewTable_SAH.DataSource = bindingSource;
        }

        private void checkBoxADD_SAH_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxADD_SAH.Checked == true)
            {
                textBoxProduct1_SAH.Visible = true;
                labelProduct1_SAH.Visible = true;
                labelCount2_SAH.Visible = true;
                textBoxCount2_SAH.Visible = true;
            }
            else
            {
                textBoxProduct1_SAH.Visible = false;
                labelProduct1_SAH.Visible = false;
                labelCount2_SAH.Visible = false;
                textBoxCount2_SAH.Visible = false;
            }
        }

        private void textBoxCount_SAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // тока циферки)
        }

        private void textBoxCount2_SAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // токкка циферки)
        }

        private void textBoxNumber_SAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // токкка циферки)
        }

        private void textBoxDayOfExecution_SAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }

        private void buttonAddOrder_SAH_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProduct1_SAH.Text))
            {
                textBoxProduct1_SAH.Text = "null";
            }
            if (string.IsNullOrEmpty(textBoxCount2_SAH.Text))
            {
                textBoxCount2_SAH.Text = "0";
            }
            int numOrder = Convert.ToInt32(textBoxNumOrder_SAH.Text);
            int accountNumb = Convert.ToInt32(textBoxAccountNumb_SAH.Text);
            string products = textBoxProduct_SAH.Text;
            int count = Convert.ToInt32(textBoxCount_SAH.Text);
            string products2 = textBoxProduct1_SAH.Text;
            int count2 = Convert.ToInt32(textBoxCount2_SAH.Text);
            int price = Convert.ToInt32(textBoxPrice_SAH.Text);
            string dayOfExecution = textBoxDayOfExecution_SAH.Text;

           

            // Создаем объект продукта
            Order newOrder = new Order(numOrder, products2, accountNumb, products, count, count2, price, dayOfExecution);

            // Добавляем продукт в список
            orderList.Add(newOrder);

            // Очищаем текстовые поля после добавления
            textBoxNumOrder_SAH.Clear();
            textBoxAccountNumb_SAH.Clear();
            textBoxProduct_SAH.Clear();
            textBoxCount_SAH.Clear();
            textBoxProduct1_SAH.Clear();
            textBoxCount2_SAH.Clear();
            textBoxPrice_SAH.Clear();
            textBoxDayOfExecution_SAH.Clear();



        }


        private void buttonOpenFile_SAH_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите CSV файл для открытия";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Читаем все строки из файла
                    string[] lines = File.ReadAllLines(filePath);

                    // Парсим заголовки столбцов
                    string[] headers = lines[0].Split(',');

                    // Очищаем старые данные в BindingList
                    orderList.Clear();

                    // Заполняем BindingList данными из файла
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(',');
                        orderList.Add(new Order
                        {
                            NumOrder = Convert.ToInt32(values[0]),
                            AccountNumb = Convert.ToInt32(values[1]),
                            Products = values[2],
                            Count = Convert.ToInt32(values[3]),
                            Products2 = values[4],
                            Count2 = Convert.ToInt32(values[5]),
                            Price = Convert.ToInt32(values[6]),
                            DayOfExecution = values[7]

                        });

                    }

                    MessageBox.Show("Файл успешно открыт!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSaveFile_SAH_Click_1(object sender, EventArgs e)
        {

            try
            {
                string directoryPath = $@"{Directory.GetCurrentDirectory()}";
                string fileName = "TableOfOrder.csv";
                string path = Path.Combine(directoryPath, fileName);

                string header = string.Join(",", dataGridViewTable_SAH.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));

                // Создаем строки для каждой записи данных
                List<string> lines = new List<string>();
                foreach (DataGridViewRow row in dataGridViewTable_SAH.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value.ToString()));
                        lines.Add(line);
                    }
                }

                // Соединяем заголовок и строки вместе
                string content = header + Environment.NewLine + string.Join(Environment.NewLine, lines);

                // Записываем содержимое в файл
                File.WriteAllText(path, content);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранитушкин!\nОткрыть его в блокнотушкинске?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveOrdr_SAH_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_SAH.SelectedRows.Count > 0)
            {
                // Получить выбранную строку
                DataGridViewRow selectedRow = dataGridViewTable_SAH.SelectedRows[0];

                // Получить объект продукта из выбранной строки
                Order selectedOrder = (Order)selectedRow.DataBoundItem;
                

                // Удалить продукт из списка
                orderList.Remove(selectedOrder);

            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void SortDataGridViewByColumn(string columnName)
        {
            if (currentSortOrder == SortOrder.Ascending)
            {
                bindingSource.DataSource = new BindingList<Order>(orderList.OrderBy(x => typeof(Order).GetProperty(columnName).GetValue(x)).ToList());
                currentSortOrder = SortOrder.Descending;

            }
            else
            {
                bindingSource.DataSource = new BindingList<Order>(orderList.OrderByDescending(x => typeof(Order).GetProperty(columnName).GetValue(x)).ToList());
                currentSortOrder = SortOrder.Ascending;
                
            }
        }

        private void buttonSort_SAH_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sortName = textBoxSort_SAH.Text;
                SortDataGridViewByColumn(sortName);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вводе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Order
        {
            public int NumOrder { get; set; }
            public int AccountNumb { get; set; }
            public string Products { get; set; }
            public int Count { get; set; }
            public string Products2{ get; set; }
            public int Count2 { get; set; }
            public int Price { get; set; }
            public string DayOfExecution { get; set; }

            // Конструктор по умолчанию 
            public Order()
            {

            }

            public Order(int numOrder,  string nameProduct2, int accountNumb, string nameProdct, int count, int count2, int price, string dayOfExecution)
            {
                NumOrder = numOrder;
                AccountNumb = accountNumb;
                Products = nameProdct;
                Count = count;
                Products2 = nameProduct2;
                Count2 = count2;
                Price = price;
                DayOfExecution = dayOfExecution;
            }
        }

        private void SearchInDataGridView(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Если поле поиска пусто, отобразить все данные
                dataGridViewTable_SAH.DataSource = bindingSource;
            }
            else
            {
                // Иначе выполните поиск и отобразить результаты
                var searchResults = orderList.Where(product =>
                    product.NumOrder.ToString().Contains(searchText) ||
                    product.AccountNumb.ToString().Contains(searchText) ||
                    product.Products.Contains(searchText) ||
                    product.Products2.Contains(searchText) ||
                    product.Count2.ToString().Contains(searchText) ||
                    product.Price.ToString().Contains(searchText) ||
                    product.Count.ToString().Contains(searchText) ||
                    product.DayOfExecution.ToString().Contains(searchText) 
                ).ToList();

                dataGridViewTable_SAH.DataSource = new BindingList<Order>(searchResults);
            }
        }

        private void textBoxSearch_SAH_TextChanged_1(object sender, EventArgs e)
        {
            SearchInDataGridView(textBoxSearch_SAH.Text);
        }

        private void buttonChart_SAH_Click(object sender, EventArgs e)
        {
            int[] prices = orderList.Select(product => product.Price).ToArray();

            FormStatistics charts = new FormStatistics(prices);

            charts.ShowDialog();
        }

        public int[] GetPrice(Order[] orders)
        {
            // Проверяем, есть ли хотя бы один товар в массиве
            if (orders.Any())
            {
                // Инициализируем массив для хранения стоимостей
                int[] prices = new int[orders.Length];

                // Индекс для заполнения массива
                int index = 0;

                // Проходим по всем товарам в массиве
                foreach (var product in orders)
                {
                    // Добавляем стоимость товара в массив
                    prices[index] = product.Price;

                    // Увеличиваем индекс
                    index++;
                }

                return prices;
            }
            // Если массив товаров пуст, возвращаем пустой массив стоимостей
            return new int[0];
        }
            

        private void buttonMinCost_SAH_Click(object sender, EventArgs e)
        {
            DataService findmin = new DataService();
            try
            {
                int[] prices = GetPrice(orderList.ToArray());
                int maxCost = findmin.FindMinPrice(prices);
                textBoxMinCost_SAH.Text = maxCost.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске максимальной цены: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
