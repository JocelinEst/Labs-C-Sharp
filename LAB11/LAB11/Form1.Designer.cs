namespace LAB11
{
    partial class Form
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
            this.dataGridViewFirst = new System.Windows.Forms.DataGridView();
            this.labelCount = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.dataGridViewSecond = new System.Windows.Forms.DataGridView();
            this.dataGridViewRes = new System.Windows.Forms.DataGridView();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.rundomGenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFirst
            // 
            this.dataGridViewFirst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirst.Location = new System.Drawing.Point(42, 193);
            this.dataGridViewFirst.Name = "dataGridViewFirst";
            this.dataGridViewFirst.Size = new System.Drawing.Size(560, 62);
            this.dataGridViewFirst.TabIndex = 0;
            this.dataGridViewFirst.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFirst_CellValueChanged);
            this.dataGridViewFirst.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewFirst_EditingControlShowing_1);
            this.dataGridViewFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewFirst_KeyPress);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(39, 55);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(124, 13);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Количество элементов";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(43, 76);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCount.TabIndex = 2;
            this.numericUpDownCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(513, 55);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(89, 58);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Вычислить";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // dataGridViewSecond
            // 
            this.dataGridViewSecond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecond.Location = new System.Drawing.Point(42, 335);
            this.dataGridViewSecond.Name = "dataGridViewSecond";
            this.dataGridViewSecond.Size = new System.Drawing.Size(560, 63);
            this.dataGridViewSecond.TabIndex = 7;
            this.dataGridViewSecond.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSecond_CellValueChanged);
            this.dataGridViewSecond.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewSecond_EditingControlShowing);
            // 
            // dataGridViewRes
            // 
            this.dataGridViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes.Location = new System.Drawing.Point(43, 512);
            this.dataGridViewRes.Name = "dataGridViewRes";
            this.dataGridViewRes.ReadOnly = true;
            this.dataGridViewRes.Size = new System.Drawing.Size(559, 64);
            this.dataGridViewRes.TabIndex = 8;
            this.dataGridViewRes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_CellValueChanged);
            this.dataGridViewRes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewRes_EditingControlShowing);
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(40, 158);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(88, 13);
            this.labelFirst.TabIndex = 9;
            this.labelFirst.Text = "Первый массив";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(39, 319);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(84, 13);
            this.labelSecond.TabIndex = 10;
            this.labelSecond.Text = "Второй массив";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(40, 480);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(163, 13);
            this.labelRes.TabIndex = 11;
            this.labelRes.Text = "Результат (Ci = Ai*Ai+1+Bi*Bi+1)";
            // 
            // rundomGenBtn
            // 
            this.rundomGenBtn.Location = new System.Drawing.Point(379, 55);
            this.rundomGenBtn.Name = "rundomGenBtn";
            this.rundomGenBtn.Size = new System.Drawing.Size(119, 58);
            this.rundomGenBtn.TabIndex = 13;
            this.rundomGenBtn.Text = "Заполнить массивы рандомно";
            this.rundomGenBtn.UseVisualStyleBackColor = true;
            this.rundomGenBtn.Click += new System.EventHandler(this.rundomGenBtn_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.rundomGenBtn);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.dataGridViewRes);
            this.Controls.Add(this.dataGridViewSecond);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.dataGridViewFirst);
            this.Name = "Form";
            this.Text = "Расчет массива";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFirst;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.DataGridView dataGridViewSecond;
        private System.Windows.Forms.DataGridView dataGridViewRes;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button rundomGenBtn;
    }
}

