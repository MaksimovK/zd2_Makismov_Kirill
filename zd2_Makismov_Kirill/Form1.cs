using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_Makismov_Kirill
{
    public partial class Form1 : Form
    {
        private Contact _contact = new Contact();
        private PhoneBook _phoneBook = new PhoneBook();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadPhoneBook(@"contacts - contacts.csv");
        }

        private void LoadPhoneBook(string fileName)
        {
            dt_PhoneBook.Columns.Add("Имя контакта", "Имя контакта");
            dt_PhoneBook.Columns.Add("Номер телефона", "Номер телефона");

            if (!File.Exists(fileName))
            {
                MessageBox.Show("Файл не найден!");
            }
            else
            {
                string[] lines = File.ReadAllLines(fileName);

                if (lines.Length == 0)
                {
                    MessageBox.Show("Файл пуст!");
                }
                else
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        if (fields.Length == 2)
                        {
                            dt_PhoneBook.Rows.Add(fields[0], fields[1]);
                        }
                    }
                }
            }
        }

        private void bt_Poisk_Click(object sender, EventArgs e)
        {
            string searchText = tb_PoiskName.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Поле поиска пустое");
                return;
            }

            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dt_PhoneBook.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool containsSearchText = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                        {
                            containsSearchText = true;
                            break;
                        }
                    }
                    
                    if (!containsSearchText)
                    {
                        rowsToRemove.Add(row);
                    }
                }
            }

            if (rowsToRemove.Count > 0)
            {
                foreach (DataGridViewRow row in rowsToRemove)
                {
                    dt_PhoneBook.Rows.Remove(row);
                }
            }
        }

        private void bt_rebutPoisk_Click(object sender, EventArgs e)
        {
            dt_PhoneBook.Columns.Clear();
            LoadPhoneBook(@"contacts - contacts.csv");
        }

        private void bt_AddContact_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = tb_NameContact.Text;
                string Phone = Regex.Replace(tb_PhoneContact.Text, @"(\d{1})(\d{3})(\d{3})(\d{4})", "+7 ($2) $3-$4");


                if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(tb_PhoneContact.Text))
                {
                    MessageBox.Show("Заполните поля!");
                    return;
                }
                else if (!Name.Contains(' '))
                {
                    MessageBox.Show("Имя контакта должно содержать 2 слова!");
                    return;
                }
                else
                {
                    foreach (var el in tb_NameContact.Text)
                    {
                        if (tb_NameContact.Text.Contains(' '))
                        {
                            continue;
                        }

                        if (!char.IsLetter(el))
                        {
                            MessageBox.Show("Имя контакта должно содержать только буквы!");
                            return;
                        }
                    }

                    foreach (var el in tb_PhoneContact.Text)
                    {
                        if (!char.IsDigit(el))
                        {
                            MessageBox.Show("Телефон должен содержать только цифры!");
                            return;
                        }
                    }
                }

                if (tb_PhoneContact.Text.Length != 11)
                {
                    MessageBox.Show("Телефон должен содерать 11 цифр");
                    return;
                }
                else
                {
                    bool ContactExist = false;
                    for (int i = 0; i < dt_PhoneBook.RowCount; i++)
                    {
                        DataGridViewCell cell = dt_PhoneBook.Rows[i].Cells[0];

                        if (cell.Value != null && cell.Value.ToString() == tb_NameContact.Text)
                        {
                            ContactExist = true;
                            break;
                        }
                    }

                    if (ContactExist)
                    {
                        MessageBox.Show("Контакт уже есть!");
                        return;
                    }
                    else
                    {
                        _contact.Name = Name;
                        _contact.Phone = Phone;

                        _phoneBook.listPhoneBook.Add(_contact);

                        dt_PhoneBook.Rows.Add(_contact.Name, _contact.Phone);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void bt_DeletContact_Click(object sender, EventArgs e)
        {
            string Name = tb_NameContactForDelete.Text;

            if (string.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("Заполните поле!");
                return;
            }
            else if (!Name.Contains(' '))
            {
                MessageBox.Show("Имя контакта должно содержать 2 слова!");
                return;
            }
            else
            {
                foreach (var el in Name)
                {
                    if (Name.Contains(' '))
                    {
                        continue;
                    }

                    if (!char.IsLetter(el))
                    {
                        MessageBox.Show("Имя контакта должно содержать только буквы!");
                        return;
                    }
                }
            }

            foreach (DataGridViewRow row in dt_PhoneBook.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == Name)
                {
                    dt_PhoneBook.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Контакт удален.");
                    return;
                }
            }

            MessageBox.Show("Контак не найден");
        }

        private void bt_saveContactForFile_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.Title = "Сохранить данные в файл";
            saveFileDialog.FileName = "data.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        for (int i = 0; i < dt_PhoneBook.Rows.Count - 1; i++)
                        {
                            string column1Value = dt_PhoneBook.Rows[i].Cells[0].Value.ToString();
                            string column2Value = dt_PhoneBook.Rows[i].Cells[1].Value.ToString();
                            _contact.Name = column1Value;
                            _contact.Phone = column2Value;
                            _phoneBook.listPhoneBook.Add(_contact);

                            sw.WriteLine(column1Value + "\t" + column2Value);
                        }
                    }

                    MessageBox.Show("Данные успешно сохранены в файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}