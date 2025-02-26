namespace LAB12
{
    partial class TwoDefinitionMatrix
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownNumOfCols = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumOfRows = new System.Windows.Forms.NumericUpDown();
            this.labelNumOfRows = new System.Windows.Forms.Label();
            this.labelNumOfCols = new System.Windows.Forms.Label();
            this.buttonRndFiling = new System.Windows.Forms.Button();
            this.buttonFileFiling = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.dataGridViewInitial = new System.Windows.Forms.DataGridView();
            this.dataGridViewRes = new System.Windows.Forms.DataGridView();
            this.labelTableRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumOfCols
            // 
            this.numericUpDownNumOfCols.Location = new System.Drawing.Point(257, 53);
            this.numericUpDownNumOfCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNumOfCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumOfCols.Name = "numericUpDownNumOfCols";
            this.numericUpDownNumOfCols.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownNumOfCols.TabIndex = 0;
            this.numericUpDownNumOfCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumOfCols.ValueChanged += new System.EventHandler(this.numericUpDownNumOfCols_ValueChanged);
            // 
            // numericUpDownNumOfRows
            // 
            this.numericUpDownNumOfRows.Location = new System.Drawing.Point(257, 19);
            this.numericUpDownNumOfRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNumOfRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumOfRows.Name = "numericUpDownNumOfRows";
            this.numericUpDownNumOfRows.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownNumOfRows.TabIndex = 1;
            this.numericUpDownNumOfRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumOfRows.ValueChanged += new System.EventHandler(this.numericUpDownNumOfRows_ValueChanged);
            // 
            // labelNumOfRows
            // 
            this.labelNumOfRows.AutoSize = true;
            this.labelNumOfRows.Location = new System.Drawing.Point(26, 21);
            this.labelNumOfRows.Name = "labelNumOfRows";
            this.labelNumOfRows.Size = new System.Drawing.Size(147, 20);
            this.labelNumOfRows.TabIndex = 2;
            this.labelNumOfRows.Text = "Количество строк";
            // 
            // labelNumOfCols
            // 
            this.labelNumOfCols.AutoSize = true;
            this.labelNumOfCols.Location = new System.Drawing.Point(26, 53);
            this.labelNumOfCols.Name = "labelNumOfCols";
            this.labelNumOfCols.Size = new System.Drawing.Size(176, 20);
            this.labelNumOfCols.TabIndex = 3;
            this.labelNumOfCols.Text = "Количество столбцов";
            // 
            // buttonRndFiling
            // 
            this.buttonRndFiling.Location = new System.Drawing.Point(397, 12);
            this.buttonRndFiling.Name = "buttonRndFiling";
            this.buttonRndFiling.Size = new System.Drawing.Size(167, 74);
            this.buttonRndFiling.TabIndex = 4;
            this.buttonRndFiling.Text = "Заполнить таблицу рандомно";
            this.buttonRndFiling.UseVisualStyleBackColor = true;
            this.buttonRndFiling.Click += new System.EventHandler(this.buttonRndFiling_Click);
            // 
            // buttonFileFiling
            // 
            this.buttonFileFiling.Location = new System.Drawing.Point(570, 12);
            this.buttonFileFiling.Name = "buttonFileFiling";
            this.buttonFileFiling.Size = new System.Drawing.Size(167, 74);
            this.buttonFileFiling.TabIndex = 5;
            this.buttonFileFiling.Text = "Заполнить таблицу из файла";
            this.buttonFileFiling.UseVisualStyleBackColor = true;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(30, 108);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(347, 35);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Вычислить";
            this.buttonCalc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInitial
            // 
            this.dataGridViewInitial.AllowUserToAddRows = false;
            this.dataGridViewInitial.AllowUserToDeleteRows = false;
            this.dataGridViewInitial.AllowUserToResizeColumns = false;
            this.dataGridViewInitial.AllowUserToResizeRows = false;
            this.dataGridViewInitial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInitial.ColumnHeadersVisible = false;
            this.dataGridViewInitial.Location = new System.Drawing.Point(30, 172);
            this.dataGridViewInitial.Name = "dataGridViewInitial";
            this.dataGridViewInitial.RowHeadersVisible = false;
            this.dataGridViewInitial.RowHeadersWidth = 62;
            this.dataGridViewInitial.RowTemplate.Height = 28;
            this.dataGridViewInitial.Size = new System.Drawing.Size(825, 297);
            this.dataGridViewInitial.TabIndex = 7;
            this.dataGridViewInitial.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewInitial_ColumnAdded);
            this.dataGridViewInitial.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewInitial_EditingControlShowing);
            this.dataGridViewInitial.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewInitial_RowsAdded);
            // 
            // dataGridViewRes
            // 
            this.dataGridViewRes.AllowUserToAddRows = false;
            this.dataGridViewRes.AllowUserToDeleteRows = false;
            this.dataGridViewRes.AllowUserToResizeColumns = false;
            this.dataGridViewRes.AllowUserToResizeRows = false;
            this.dataGridViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes.ColumnHeadersVisible = false;
            this.dataGridViewRes.Location = new System.Drawing.Point(30, 592);
            this.dataGridViewRes.Name = "dataGridViewRes";
            this.dataGridViewRes.ReadOnly = true;
            this.dataGridViewRes.RowHeadersVisible = false;
            this.dataGridViewRes.RowHeadersWidth = 62;
            this.dataGridViewRes.RowTemplate.Height = 28;
            this.dataGridViewRes.Size = new System.Drawing.Size(825, 294);
            this.dataGridViewRes.TabIndex = 9;
            this.dataGridViewRes.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewRes_ColumnAdded);
            this.dataGridViewRes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewRes_RowsAdded);
            // 
            // labelTableRes
            // 
            this.labelTableRes.AutoSize = true;
            this.labelTableRes.Location = new System.Drawing.Point(33, 551);
            this.labelTableRes.Name = "labelTableRes";
            this.labelTableRes.Size = new System.Drawing.Size(169, 20);
            this.labelTableRes.TabIndex = 10;
            this.labelTableRes.Text = "Полученная таблица";
            // 
            // TwoDefinitionMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 942);
            this.Controls.Add(this.labelTableRes);
            this.Controls.Add(this.dataGridViewRes);
            this.Controls.Add(this.dataGridViewInitial);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonFileFiling);
            this.Controls.Add(this.buttonRndFiling);
            this.Controls.Add(this.labelNumOfCols);
            this.Controls.Add(this.labelNumOfRows);
            this.Controls.Add(this.numericUpDownNumOfRows);
            this.Controls.Add(this.numericUpDownNumOfCols);
            this.Name = "TwoDefinitionMatrix";
            this.Text = "TwoDefinitionMatrix";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNumOfCols;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfRows;
        private System.Windows.Forms.Label labelNumOfRows;
        private System.Windows.Forms.Label labelNumOfCols;
        private System.Windows.Forms.Button buttonRndFiling;
        private System.Windows.Forms.Button buttonFileFiling;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.DataGridView dataGridViewInitial;
        private System.Windows.Forms.DataGridView dataGridViewRes;
        private System.Windows.Forms.Label labelTableRes;
    }
}

