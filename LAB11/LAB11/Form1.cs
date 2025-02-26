using System;
using System.Linq;
using System.Windows.Forms;

namespace LAB11
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            
            dataGridViewFirst.AllowUserToAddRows = false;
            dataGridViewFirst.AllowUserToDeleteRows = false;
            dataGridViewFirst.AllowUserToResizeRows = false;
            dataGridViewSecond.AllowUserToAddRows = false;
            dataGridViewSecond.AllowUserToDeleteRows = false;
            dataGridViewSecond.AllowUserToResizeRows = false;
            dataGridViewRes.AllowUserToAddRows = false;
            dataGridViewRes.AllowUserToDeleteRows = false;
            dataGridViewRes.AllowUserToResizeRows = false;
            

            dataGridViewFirst.RowCount = 2;
            
            dataGridViewSecond.RowCount = 2;
            dataGridViewRes.RowCount = 2;
            dataGridViewFirst.ColumnCount = 2;
            dataGridViewSecond.ColumnCount = 2;
            dataGridViewRes.ColumnCount = 1;

            dataGridViewFirst.Rows[0].ReadOnly = true;
            dataGridViewSecond.Rows[0].ReadOnly = true;
            dataGridViewRes.Rows[0].ReadOnly = true;

            DataGridViewRow row = dataGridViewFirst.Rows[0];
            for (int i = 0; i < numericUpDownCount.Value; i++)
            {
                row.Cells[i].Value = i;

            }
            row = dataGridViewSecond.Rows[0];
            for (int i = 0; i < numericUpDownCount.Value; i++)
            {
                row.Cells[i].Value = i;

            }
            row = dataGridViewRes.Rows[0];
            for (int i = 0; i < numericUpDownCount.Value - 1; i++)
            {
                row.Cells[i].Value = i;

            }


            row = dataGridViewFirst.Rows[1];
            for (int i = 0; i < numericUpDownCount.Value; i++)
            {
                row.Cells[i].Value = 1;

            }
            row = dataGridViewSecond.Rows[1];
            for (int i = 0; i < numericUpDownCount.Value; i++)
            {
                row.Cells[i].Value = 1;

            }
            row = dataGridViewRes.Rows[1];
            for (int i = 0; i < numericUpDownCount.Value - 1; i++)
            {
                row.Cells[i].Value = 1;

            }
            
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewFirst.ColumnCount=(int)numericUpDownCount.Value;
            dataGridViewSecond.ColumnCount=(int)numericUpDownCount.Value;
            dataGridViewRes.ColumnCount=(int)numericUpDownCount.Value-1;

            DataGridViewRow row = dataGridViewFirst.Rows[0];
            
            for (int i = 0; i < numericUpDownCount.Value; i++)
            {
                row.Cells[i].Value = i;

            }
            row = dataGridViewSecond.Rows[0];
            for (int i = 0; i < numericUpDownCount.Value; i++)
            {
                row.Cells[i].Value = i;

            }
            row = dataGridViewRes.Rows[0];
            for (int i = 0; i < numericUpDownCount.Value-1; i++)
            {
                row.Cells[i].Value = i;

            }


            row = dataGridViewFirst.Rows[1];
            for (int i = 0; i < numericUpDownCount.Value; i++)
            {
                row.Cells[i].Value = 1;

            }
            row = dataGridViewSecond.Rows[1];
            for (int i = 0; i < numericUpDownCount.Value; i++)
            {
                row.Cells[i].Value = 1;

            }
            row = dataGridViewRes.Rows[1];
            for (int i = 0; i < numericUpDownCount.Value - 1; i++)
            {
                row.Cells[i].Value = 1;

            }
        }


        private void buttonCalc_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridViewRes.Rows[1];
            Mas masRes = new Mas();
            masRes = masRes.FromRowToMas(row);

            row = dataGridViewFirst.Rows[1];
            Mas mas1 = new Mas();
            mas1 = mas1.FromRowToMas(row);

            row = dataGridViewSecond.Rows[1];
            Mas mas2 = new Mas();
            mas2 = mas2.FromRowToMas(row);

            row = dataGridViewRes.Rows[1];
            masRes = masRes.calcMas(mas1, mas2);
            for (int i = 0; i < dataGridViewRes.ColumnCount; i++) { 
                row.Cells[i].Value = masRes[i];
            }
        }
        

        private void rundomGenBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row2 = dataGridViewFirst.Rows[1];
            Mas mas = new Mas();
            mas = mas.rndMas(dataGridViewFirst.ColumnCount);
            for (int i = 0; i < dataGridViewFirst.ColumnCount; i++) {
                row2.Cells[i].Value = mas.Matrix[i];
            }

            row2 = dataGridViewSecond.Rows[1];
            Mas mas1 = new Mas();
            mas1 = mas1.rndMas(dataGridViewSecond.ColumnCount);
            for (int i = 0; i < dataGridViewSecond.ColumnCount; i++)
            {
                row2.Cells[i].Value = mas.Matrix[i];
            }

        }

        private void dataGridViewFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currentText = dataGridViewFirst.CurrentCell.Value.ToString();
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
            {
      
                if (e.KeyChar == ',' && currentText.Contains(","))
                {
                    e.Handled = true; 
                }
            }
            else
            {
                e.Handled = true; 
            }

        }

        private void dataGridViewFirst_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewFirst.Rows[1];
            for (int i = 0; i < row.Cells.Count; i++)
            {
                if (row.Cells[i].Value == null)
                {
                    row.Cells[i].Value = 1;
                }
            }
        }
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

        private void dataGridViewFirst_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress -= tb_KeyPress; // Удаляем предыдущий обработчик, чтобы избежать дублирования
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress); // Добавляем новый обработчик
        }

        private void dataGridViewSecond_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewSecond.Rows[1];
            for (int i = 0; i < row.Cells.Count; i++)
            {
                if (row.Cells[i].Value == null)
                {
                    row.Cells[i].Value = 1;
                }
            }
        }

        private void dataGridViewRes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewRes.Rows[1];
            for (int i = 0; i < row.Cells.Count; i++)
            {
                if (row.Cells[i].Value == null)
                {
                    row.Cells[i].Value = 1;
                }
            }
        }

        private void dataGridViewRes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress -= tb_KeyPress; // Удаляем предыдущий обработчик, чтобы избежать дублирования
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress); // Добавляем новый обработчик
        }

        private void dataGridViewSecond_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress -= tb_KeyPress; // Удаляем предыдущий обработчик, чтобы избежать дублирования
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress); // Добавляем новый обработчик
        }
    }
}
