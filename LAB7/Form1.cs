using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_interface1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

      

        /// <summary>
        /// Обрабатывает событие нажатия кнопки для выполнения расчета длины в различных единицах измерения.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Событие, содержащее данные о нажатии кнопки.</param>
        /// <remarks>
        /// Метод проверяет, какая радиокнопка выбрана, и выполняет соответствующий расчет, 
        /// преобразуя значение из текстового поля в метры, сантиметры или километры в футы, дюймы, ярды, мили, морские мили и лиги.
        /// Если введенное значение не может быть преобразовано в число или меньше или равно нулю, 
        /// выводится сообщение об ошибке и поле ввода очищается.
        /// </remarks>
        private void buttonCalculate_click(object sender, EventArgs e)
        {
            if (radioButtonMetre.Checked)
            {
                string input = textBox1.Text;
                if (double.TryParse(input, out double res) && res > 0)
                {

                    resFt.Text = Convert.ToString(Math.Round(res * 3.281, 5)) + " футов";
                    resInch.Text = Convert.ToString(Math.Round(res * 39.37, 5)) + " дюймов";
                    resYd.Text = Convert.ToString(Math.Round(res * 1.094, 5)) + " ярдов";
                    resMile.Text = Convert.ToString(Math.Round(res / 1609, 5)) + " миль";
                    resNMile.Text = Convert.ToString(Math.Round(res / 1852, 5)) + " морских миль";
                    resLeag.Text = Convert.ToString(Math.Round(res / 4827, 5)) + " лиг";

                }
                else
                {
                    resFt.Text = " ";

                    MessageBox.Show("Поле ввода не должно быть пустым.");
                    textBox1.Clear();
                }
            }
            else if (radioButton2Centimeter.Checked)
            {
                string input = textBox1.Text;
                if (double.TryParse(input, out double res) && res > 0)
                {
                    resFt.Text = Convert.ToString(res / 30.48) + " футов";
                    resInch.Text = Convert.ToString(res / 2.54) + " дюймов";
                    resYd.Text = Convert.ToString(res / 91.44) + " ярдов";
                    resMile.Text = Convert.ToString(res / 1609.34) + " миль"; 
                    resNMile.Text = Convert.ToString(res / 1852) + " морских миль"; 
                    resLeag.Text = Convert.ToString(res / 4828) + " лиг"; 


                }
                else
                {
                    resFt.Text = " ";

                    MessageBox.Show("Поле ввода не должно быть пустым.");
                    textBox1.Clear();
                }
            }
            else if (radioButton3Kilometer.Checked)
            {
                string input = textBox1.Text;
                if (double.TryParse(input, out double res) && res > 0)
                {

                    resFt.Text = Convert.ToString(Math.Round(res * 3280.84, 5)) + " футов";
                    resInch.Text = Convert.ToString(Math.Round(res * 39370.08, 5)) + " дюймов";
                    resYd.Text = Convert.ToString(Math.Round(res * 1094, 2)) + " ярдов";
                    resMile.Text = Convert.ToString(Math.Round(res / 1.609, 5)) + " миль";
                    resNMile.Text = Convert.ToString(Math.Round(res / 1.852, 5)) + " морских миль";
                    resLeag.Text = Convert.ToString(Math.Round(res / 4.828, 5)) + " лиг";

                }
                else
                {
                    

                    MessageBox.Show("Поле ввода не должно быть пустым.");
                    textBox1.Clear();
                }
            }

        }

        /// <summary>
        /// Обрабатывает событие нажатия клавиши в текстовом поле для ограничения ввода символов.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Событие, содержащее данные о нажатой клавише.</param>
        /// <remarks>
        /// Метод позволяет вводить только символы, отличные от цифр и запрещает ввод минуса, если текстовое поле пустое. 
        /// Также запрещает ввод символа Backspace. Все остальные символы игнорируются.
        /// </remarks>

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) // цифры разрешены
            return;
            if ((e.KeyChar == '-') && (textBox1.Text.Length == 0)) // минус запрещен
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Back) // BackSpase запрещен
                e.Handled = true;
            e.KeyChar = '\0';// остальные символы игнорировать

        }
    }
}
