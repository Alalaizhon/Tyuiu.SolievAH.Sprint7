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

namespace Tyuiu.SolievAH.Sprint7.Projcet.V10.Forms
{
    public partial class FormOrder : Form
    {
        public BindingList<Product> productList;
        private BindingSource bindingSource;
        public FormOrder()
        {
            InitializeComponent();
            productList = new BindingList<Product>();
            bindingSource = new BindingSource(productList, null);

            dataGridViewTable_SAH.DataSource = bindingSource;
        }

        private void checkBoxADD_SAH_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProduct1_SAH.Visible = true;
            labelProduct1_SAH.Visible = true;
            labelCount2_SAH.Visible = true;
            textBoxCount2_SAH.Visible = true;
        }

        private void textBoxPhoneNum_SAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // токкка циферки)
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

        private void buttonAddOrder_SAH_Click(object sender, EventArgs e)
        {

            try
            {
                int NumOrder = Convert.ToInt32(textBoxNumOrder_SAH.Text);
                int accountNumb = Convert.ToInt32(textBoxAccountNumb_SAH.Text);
                string products = textBoxProduct_SAH.Text;
                int count = Convert.ToInt32(textBoxCount_SAH.Text);
                string products2 = textBoxProduct1_SAH.Text;
                int count2 = Convert.ToInt32(textBoxCount2_SAH.Text);
                int price = Convert.ToInt32(textBoxPrice_SAH.Text);
                int dayOfExecution = Convert.ToInt32(textBoxDayOfExecution_SAH.Text);



                // Создаем объект продукта
                Product newProduct = new Product(NumOrder, products2, accountNumb, products, count, count2, price, dayOfExecution);

                // Добавляем продукт в список
                productList.Add(newProduct);

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
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonOpenFile_SAH_Click(object sender, EventArgs e)
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
                    productList.Clear();

                    // Заполняем BindingList данными из файла
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(',');
                        productList.Add(new Product
                        {
                            NumOrder = Convert.ToInt32(values[0]),
                            AccountNumb = Convert.ToInt32(values[1]),
                            Products = values[2],
                            Count = Convert.ToInt32(values[3]),
                            Products2 = values[4],
                            Count2 = Convert.ToInt32(values[5]),
                            Price = Convert.ToInt32(values[6]),
                            DayOfExecution = Convert.ToInt32(values[7])

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


        private void buttonSaveFile_SAH_Click(object sender, EventArgs e)
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



        }


        private void buttonSort_SAH_Click(object sender, EventArgs e)
        {



        }
        public class Product
        {
            public int NumOrder { get; set; }
            public int AccountNumb { get; set; }
            public string Products { get; set; }
            public string Products2{ get; set; }
            public int Count2 { get; set; }
            public int Price { get; set; }
            public int Count { get; set; }
            public int DayOfExecution { get; set; }

            // Конструктор по умолчанию 
            public Product()
            {

            }

            public Product(int numOrder,  string nameProduct2, int accountNumb, string nameProdct, int count, int count2, int price, int dayOfExecution)
            {
                NumOrder = numOrder;
                AccountNumb = accountNumb;
                Products = nameProdct;
                Products2 = nameProduct2;
                Count2 = count2;
                Price = price;
                Count = count;
                DayOfExecution = dayOfExecution;
            }
        }

   
    }
}
