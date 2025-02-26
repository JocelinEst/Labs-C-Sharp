using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB10
{
    public partial class Storehouse : Form
    {
        public Storehouse()
        {
            InitializeComponent();
        }



        //Ограничение полей ввода---------------------------------------------
        private void priceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли нажатая клавиша цифрой или точкой
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                // Проверяем, есть ли уже точка в тексте
                if (e.KeyChar == '.' && (priceInput.Text.Length == 0 || priceInput.Text.Contains('.')))
                {
                    e.Handled = true; // Игнорируем ввод, если точка первая или уже есть
                }
            }
            else
            {
                e.Handled = true; // Игнорируем другие символы
            }
        }

        private void countInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            { return; }
            else { e.Handled = true; }
        }
        private void nameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else { e.Handled = true; }
        }


        //Двойное нажатие на элемент списка--------------------------------------
        private void itemCollection_DoubleClick(object sender, EventArgs e)
        {
            string[] item = itemCollection.SelectedItem.ToString().Split(' ');
            nameInput.Text = item[0];
            priceInput.Text = item[1];
            countInput.Text = item[2];
        }
        List<Items> list = new List<Items>();


        //Добавление элемента в список------------------------------------------
        private void addBtn_Click(object sender, EventArgs e)
        {

            Items item = new Items();
            item.Name = nameInput.Text;
            if (nameInput.Text.Length != 0 && priceInput.Text.Length != 0 || countInput.Text.Length != 0)
            {
                try
                {
                    if (double.TryParse(priceInput.Text, out double price))
                    {
                        item.Price = Convert.ToDouble(priceInput.Text);
                        if (int.TryParse(priceInput.Text, out int count))
                        {
                            item.Count = count;
                            itemCollection.Items.Add(item);
                            list.Add(item);
                        }
                        else { throw new FormatException(); }
                    }
                    else { throw new FormatException(); }


                }
                catch { MessageBox.Show("Некоррректный ввод. Попробуйте снова."); }
            }
            else { MessageBox.Show("Поля не должны быть пустыми."); }


        }

        //Удаление элемента из списка------------------------------------------
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли элемент
            if (itemCollection.SelectedIndex >= 0)
            {
                int selectedIndex = itemCollection.SelectedIndex;

                // Удаляем элемент из itemCollection
                itemCollection.Items.RemoveAt(selectedIndex);

                // Удаляем элемент из list
                list.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
            }
        }

        //Изменение элемента списка---------------------------------------------
        private void editBtn_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбранный элемент не null и является экземпляром класса items
            if (itemCollection.SelectedItem is Items selectedItem)
            {
                // Обновляем поля выбранного элемента
                selectedItem.Name = nameInput.Text;

                // Пытаемся преобразовать вводимые данные в цену и количество
                if (double.TryParse(priceInput.Text, out double price))
                {
                    selectedItem.Price = price;
                }
                else
                {
                    MessageBox.Show("Некорректный ввод цены. Попробуйте снова.");
                    return;
                }

                if (int.TryParse(countInput.Text, out int count))
                {
                    selectedItem.Count = count;
                }
                else
                {
                    MessageBox.Show("Некорректный ввод количества. Попробуйте снова.");
                    return;
                }

                // Обновляем отображение в ListBox
                itemCollection.Items[itemCollection.SelectedIndex] = selectedItem;
            }
            else
            {
                MessageBox.Show("Выберите элемент для редактирования.");
            }
        }

        //Перевод содержимого ListBox в RichTextBox---------------------------
        private void showList_Click(object sender, EventArgs e)
        {
            itemList.Clear();
            if (list.Count > 0)
            {
                for (int i = 0; i < itemCollection.Items.Count; i++)
                {
                    itemList.AppendText(itemCollection.Items[i].ToString());
                }



                double totalPrice = 0;

                for (int j = 0; j < list.Count; j++)
                {
                    totalPrice += list[j].Price;
                }

                double averagePrice = totalPrice / list.Count;

                double minCount = 0;
                Items minItem = new Items();
                minItem.Count = int.MaxValue;

                for (int k = 0; k < list.Count; k++)
                {
                    if (list[k].Count < minItem.Count)
                    {
                        minItem = list[k];
                    }
                }



                generalInfoOutput.Text = $"Средняя стоимость перечисленных товаров: {averagePrice}₽\n Товар,которого меньше всего на складе: {minItem}";
            }
            else { MessageBox.Show("Добавьте товары в список."); }
        } 

        //Кнопка сброса всего вообще короче--------------------------------------------
        private void resetBtn_Click(object sender, EventArgs e)
        {
            itemList.Clear();
            itemCollection.Items.Clear();
            nameInput.Text=string.Empty;
            priceInput.Text=string.Empty;
            countInput.Text=string.Empty;
            list.Clear();
            generalInfoOutput.Text = $"Средняя стоимость перечисленных товаров: 0₽\n Товар,которого меньше всего на складе: ";
        }

        //Сохранение файла-----------------------------------------------------------
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно для сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить текст в файл";

                // Если пользователь выбрал имя файла и нажал OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Сохраняем содержимое RichTextBox в выбранный файл
                        itemList.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                        MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    }

