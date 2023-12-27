using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.SolievAH.Sprint7.Projcet.V10.Forms
{
    public partial class FormCustomer : Form
    {
        public BindingList<Customer> customerList;
        private BindingSource bindingSource;
        private SortOrder currentSortOrder = SortOrder.Ascending;
        public FormCustomer()
        {
            InitializeComponent();
            customerList = new BindingList<Customer>();
            bindingSource = new BindingSource(customerList, null);

            dataGridViewCustomer_SAH.DataSource = bindingSource;
        }

        private void textBoxAccountNumb_SAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // токкка циферки)
        }

        private void textBoxPhoneNum_SAH_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // токкка циферки)
        }

        private void buttonAddCustomer_SAH_Click(object sender, EventArgs e)
        {
            try
            {
                
                int accountNumb = Convert.ToInt32(textBoxAccountNumb_SAH.Text);
                string fullName = textBoxFullName_SAH.Text;
                string adress = textBoxAdress_SAH.Text;
                string phoneNum = textBoxPhoneNum_SAH.Text;



                // Создаем объект продукта
                Customer newCustomer = new Customer(fullName, adress, accountNumb, phoneNum);

                // Добавляем продукт в список
                customerList.Add(newCustomer);

                // Очищаем текстовые поля после добавления
                textBoxAccountNumb_SAH.Clear();
                textBoxFullName_SAH.Clear();
                textBoxAdress_SAH.Clear();
                textBoxPhoneNum_SAH.Clear();

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Customer
        {
            public string FullName { get; set; }
            public string Adress { get; set; }
            public int AccountNumb { get; set; }
            public string PhoneNum { get; set; }

            public Customer()
            {

            }

            public Customer(string fullName, string adress, int accountNumb, string phoneNum)
            {
                FullName = fullName;
                Adress = adress;
                AccountNumb = accountNumb;
                PhoneNum = phoneNum;
            }
        }

        private void buttonRemoveOrdr_SAH_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer_SAH.SelectedRows.Count > 0)
            {
                // Получить выбранную строку
                DataGridViewRow selectedRow = dataGridViewCustomer_SAH.SelectedRows[0];

                // Получить объект продукта из выбранной строки
                Customer selectedCustomer = (Customer)selectedRow.DataBoundItem;

                // Удалить продукт из списка
                customerList.Remove(selectedCustomer);
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
                bindingSource.DataSource = new BindingList<Customer>(customerList.OrderBy(x => typeof(Customer).GetProperty(columnName).GetValue(x)).ToList());
                currentSortOrder = SortOrder.Descending;
            }
            else
            {
                bindingSource.DataSource = new BindingList<Customer>(customerList.OrderByDescending(x => typeof(Customer).GetProperty(columnName).GetValue(x)).ToList());
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

        private void SearchInDataGridView(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Если поле поиска пусто, отобразить все данные
                dataGridViewCustomer_SAH.DataSource = bindingSource;
            }
            else
            {
                // Иначе выполните поиск и отобразить результаты
                var searchResults = customerList.Where(product =>
                    product.FullName.ToString().Contains(searchText) ||
                    product.Adress.ToString().Contains(searchText) ||
                    product.AccountNumb.ToString().Contains(searchText) ||
                    product.PhoneNum.ToString().Contains(searchText) 
                ).ToList();

                dataGridViewCustomer_SAH.DataSource = new BindingList<Customer>(searchResults);
            }
        }

        private void textBoxSearch_SAH_TextChanged_1(object sender, EventArgs e)
        {
            SearchInDataGridView(textBoxSearch_SAH.Text);
        }

        private void buttonSaveFile_SAH_Click_1(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = $@"{Directory.GetCurrentDirectory()}";
                string fileName = "TableOfCustomer.csv";
                string path = Path.Combine(directoryPath, fileName);

                string header = string.Join(",", dataGridViewCustomer_SAH.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));

                // Создаем строки для каждой записи данных
                List<string> lines = new List<string>();
                foreach (DataGridViewRow row in dataGridViewCustomer_SAH.Rows)
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
                    customerList.Clear();

                    // Заполняем BindingList данными из файла
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(',');
                        customerList.Add(new Customer
                        {
                            FullName = values[0],
                            Adress = values[1],
                            AccountNumb = Convert.ToInt32(values[2]),
                            PhoneNum = values[3],

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
    }
}
