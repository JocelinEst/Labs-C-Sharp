using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB12
{
    public partial class TwoDefinitionMatrix : Form
    {
        public TwoDefinitionMatrix()
        {
            InitializeComponent();
        
           
            //Дефолтные значения

            dataGridViewInitial.RowCount = 5;
            dataGridViewInitial.ColumnCount = 5;

            dataGridViewRes.RowCount = 5;
            dataGridViewRes.ColumnCount = 5;

            numericUpDownNumOfCols.Value = 5;
            numericUpDownNumOfRows.Value = 5;

           
      
            dataGridViewInitial.ColumnHeadersVisible = true;
            dataGridViewInitial.RowHeadersVisible = true;
            dataGridViewRes.RowHeadersVisible = true;
            dataGridViewRes.ColumnHeadersVisible = true;

            SetDefaultValues(dataGridViewInitial);
            SetDefaultValues(dataGridViewRes);


        }

        private void SetDefaultValues(DataGridView dgv)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    dgv[j, i].Value = 1;
                }
            }
            
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].HeaderCell.Value = i.ToString();
            }
        }

        //Контроль размерности
        //Строки
        private void numericUpDownNumOfRows_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewInitial.RowCount = (int)numericUpDownNumOfRows.Value;
            dataGridViewRes.RowCount = (int)numericUpDownNumOfRows.Value;
        

        }
        //Столбцы
        private void numericUpDownNumOfCols_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewInitial.ColumnCount=(int)numericUpDownNumOfCols.Value;
            dataGridViewRes.ColumnCount=(int)numericUpDownNumOfCols.Value;
           
        }


        //Дефолтные значения 
        //Для изначального
        private void dataGridViewInitial_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataGridViewRow currentRow = dataGridViewInitial.Rows[(int)numericUpDownNumOfRows.Value - 1];
            //for (int i = 0; i < dataGridViewInitial.ColumnCount; i++)
            //{
            //    currentRow.Cells[i].Value = 1;
            //}
            SetDefaultValues(dataGridViewInitial);
            SetDefaultValues(dataGridViewRes);
        }

        private void dataGridViewInitial_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridViewInitial.Rows)
            //{
            //    row.Cells[e.Column.Index].Value = 1;
            //}
            SetDefaultValues(dataGridViewInitial);
            SetDefaultValues(dataGridViewRes);
        }
      
        //Для результирующего
        private void dataGridViewRes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataGridViewRow currentRow = dataGridViewRes.Rows[(int)numericUpDownNumOfRows.Value - 1];
            //for (int i = 0; i < dataGridViewRes.ColumnCount; i++)
            //{
            //    currentRow.Cells[i].Value = 1;
            //}
            SetDefaultValues(dataGridViewInitial);
            SetDefaultValues(dataGridViewRes);
        }
        private void dataGridViewRes_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridViewRes.Rows)
            //{
            //    row.Cells[e.Column.Index].Value = 1;
            //}
            SetDefaultValues(dataGridViewInitial);
            SetDefaultValues(dataGridViewRes);
        }



        //Запрет ввода фигни для изначальной таблицы
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            // Проверяем, если нажатая клавиша - это не цифра, не минус и не запятая
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ',')
            {
                // Разрешаем Backspace и Delete
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                {
                    e.Handled = true; // Запрещаем ввод
                }
            }

            // Проверяем, если введен минус
            if (e.KeyChar == '-')
            {
                // Если минус уже введен или он не первый символ, запрещаем ввод
                if (tb.Text.Length > 0 || tb.Text.Contains('-'))
                {
                    e.Handled = true;
                }
            }

            // Проверяем, если введена запятая
            if (e.KeyChar == ',')
            {
                // Если запятая уже введена или она первый символ, запрещаем ввод
                if (tb.Text.Contains(',') || tb.Text.Length == 0 || tb.Text.Contains(",,"))
                {
                    e.Handled = true;
                }
            }


        }

        private void dataGridViewInitial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress -= tb_KeyPress; // Удаляем предыдущий обработчик, чтобы избежать дублирования
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress); // Добавляем новый обработчик
        }

        //Рандомное заполнение массива
        private void buttonRndFiling_Click(object sender, EventArgs e)
        {
            int rowCount = (int)numericUpDownNumOfRows.Value; 
            int colCount = (int)numericUpDownNumOfCols.Value;
           
            TwoDefArr arr = new TwoDefArr(rowCount, colCount);
            arr = arr.rndArray(rowCount, colCount);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    dataGridViewInitial.Rows[i].Cells[j].Value = arr.Array[i, j];
                    //dataGridViewInitial[j,i].Value = arr.Array[i, j];
                }
            }
        }
    }
}
