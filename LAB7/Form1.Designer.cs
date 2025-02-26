namespace Lab7_interface1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultFt = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.resultInch = new System.Windows.Forms.Label();
            this.resultYd = new System.Windows.Forms.Label();
            this.resultMile = new System.Windows.Forms.Label();
            this.resultNMile = new System.Windows.Forms.Label();
            this.resultLeag = new System.Windows.Forms.Label();
            this.resFt = new System.Windows.Forms.Label();
            this.resMile = new System.Windows.Forms.Label();
            this.resYd = new System.Windows.Forms.Label();
            this.resNMile = new System.Windows.Forms.Label();
            this.resLeag = new System.Windows.Forms.Label();
            this.resInch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.GroupBox();
            this.radioButton3Kilometer = new System.Windows.Forms.RadioButton();
            this.radioButton2Centimeter = new System.Windows.Forms.RadioButton();
            this.radioButtonMetre = new System.Windows.Forms.RadioButton();
            this.length.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultFt
            // 
            this.resultFt.AutoSize = true;
            this.resultFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultFt.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultFt.Location = new System.Drawing.Point(381, 34);
            this.resultFt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultFt.Name = "resultFt";
            this.resultFt.Size = new System.Drawing.Size(202, 17);
            this.resultFt.TabIndex = 2;
            this.resultFt.Text = "Результат длина в футах:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.buttonCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalculate.Location = new System.Drawing.Point(80, 234);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(145, 31);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "РАССЧИТАТЬ";
            this.buttonCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_click);
            // 
            // resultInch
            // 
            this.resultInch.AutoSize = true;
            this.resultInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultInch.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultInch.Location = new System.Drawing.Point(373, 64);
            this.resultInch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultInch.Name = "resultInch";
            this.resultInch.Size = new System.Drawing.Size(213, 17);
            this.resultInch.TabIndex = 11;
            this.resultInch.Text = "Результат длина в дюймах:";
            // 
            // resultYd
            // 
            this.resultYd.AutoSize = true;
            this.resultYd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultYd.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultYd.Location = new System.Drawing.Point(381, 91);
            this.resultYd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultYd.Name = "resultYd";
            this.resultYd.Size = new System.Drawing.Size(201, 17);
            this.resultYd.TabIndex = 12;
            this.resultYd.Text = "Результат длина в ярдах:";
            // 
            // resultMile
            // 
            this.resultMile.AutoSize = true;
            this.resultMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultMile.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultMile.Location = new System.Drawing.Point(381, 123);
            this.resultMile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultMile.Name = "resultMile";
            this.resultMile.Size = new System.Drawing.Size(202, 17);
            this.resultMile.TabIndex = 13;
            this.resultMile.Text = "Результат длина в милях:";
            // 
            // resultNMile
            // 
            this.resultNMile.AutoSize = true;
            this.resultNMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultNMile.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultNMile.Location = new System.Drawing.Point(318, 150);
            this.resultNMile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultNMile.Name = "resultNMile";
            this.resultNMile.Size = new System.Drawing.Size(267, 17);
            this.resultNMile.TabIndex = 14;
            this.resultNMile.Text = "Результат длина в морских милях:";
            // 
            // resultLeag
            // 
            this.resultLeag.AutoSize = true;
            this.resultLeag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLeag.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultLeag.Location = new System.Drawing.Point(384, 181);
            this.resultLeag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLeag.Name = "resultLeag";
            this.resultLeag.Size = new System.Drawing.Size(198, 17);
            this.resultLeag.TabIndex = 15;
            this.resultLeag.Text = "Результат длина в лигах:";
            // 
            // resFt
            // 
            this.resFt.AutoSize = true;
            this.resFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resFt.ForeColor = System.Drawing.Color.White;
            this.resFt.Location = new System.Drawing.Point(595, 34);
            this.resFt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resFt.MinimumSize = new System.Drawing.Size(67, 0);
            this.resFt.Name = "resFt";
            this.resFt.Size = new System.Drawing.Size(67, 17);
            this.resFt.TabIndex = 3;
            // 
            // resMile
            // 
            this.resMile.AutoSize = true;
            this.resMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resMile.ForeColor = System.Drawing.Color.White;
            this.resMile.Location = new System.Drawing.Point(595, 123);
            this.resMile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resMile.MinimumSize = new System.Drawing.Size(67, 0);
            this.resMile.Name = "resMile";
            this.resMile.Size = new System.Drawing.Size(67, 17);
            this.resMile.TabIndex = 6;
            // 
            // resYd
            // 
            this.resYd.AutoSize = true;
            this.resYd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resYd.ForeColor = System.Drawing.Color.White;
            this.resYd.Location = new System.Drawing.Point(595, 91);
            this.resYd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resYd.MinimumSize = new System.Drawing.Size(67, 0);
            this.resYd.Name = "resYd";
            this.resYd.Size = new System.Drawing.Size(67, 17);
            this.resYd.TabIndex = 7;
            // 
            // resNMile
            // 
            this.resNMile.AutoSize = true;
            this.resNMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resNMile.ForeColor = System.Drawing.Color.White;
            this.resNMile.Location = new System.Drawing.Point(595, 150);
            this.resNMile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resNMile.MinimumSize = new System.Drawing.Size(67, 0);
            this.resNMile.Name = "resNMile";
            this.resNMile.Size = new System.Drawing.Size(67, 17);
            this.resNMile.TabIndex = 8;
            // 
            // resLeag
            // 
            this.resLeag.AutoSize = true;
            this.resLeag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resLeag.ForeColor = System.Drawing.Color.White;
            this.resLeag.Location = new System.Drawing.Point(595, 181);
            this.resLeag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resLeag.MinimumSize = new System.Drawing.Size(67, 0);
            this.resLeag.Name = "resLeag";
            this.resLeag.Size = new System.Drawing.Size(67, 17);
            this.resLeag.TabIndex = 10;
            // 
            // resInch
            // 
            this.resInch.AutoSize = true;
            this.resInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resInch.ForeColor = System.Drawing.Color.White;
            this.resInch.Location = new System.Drawing.Point(595, 64);
            this.resInch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resInch.MinimumSize = new System.Drawing.Size(67, 0);
            this.resInch.Name = "resInch";
            this.resInch.Size = new System.Drawing.Size(67, 17);
            this.resInch.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(170, 180);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 23);
            this.textBox1.TabIndex = 18;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(29, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите длину:";
            // 
            // length
            // 
            this.length.Controls.Add(this.radioButton3Kilometer);
            this.length.Controls.Add(this.radioButton2Centimeter);
            this.length.Controls.Add(this.radioButtonMetre);
            this.length.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.length.ForeColor = System.Drawing.SystemColors.Menu;
            this.length.Location = new System.Drawing.Point(30, 32);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(241, 132);
            this.length.TabIndex = 19;
            this.length.TabStop = false;
            this.length.Text = "Выберете меру длины";
            // 
            // radioButton3Kilometer
            // 
            this.radioButton3Kilometer.AutoSize = true;
            this.radioButton3Kilometer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton3Kilometer.Location = new System.Drawing.Point(19, 92);
            this.radioButton3Kilometer.Name = "radioButton3Kilometer";
            this.radioButton3Kilometer.Size = new System.Drawing.Size(98, 21);
            this.radioButton3Kilometer.TabIndex = 2;
            this.radioButton3Kilometer.TabStop = true;
            this.radioButton3Kilometer.Text = "Километр";
            this.radioButton3Kilometer.UseVisualStyleBackColor = true;
            
            // 
            // radioButton2Centimeter
            // 
            this.radioButton2Centimeter.AutoSize = true;
            this.radioButton2Centimeter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton2Centimeter.Location = new System.Drawing.Point(19, 64);
            this.radioButton2Centimeter.Name = "radioButton2Centimeter";
            this.radioButton2Centimeter.Size = new System.Drawing.Size(106, 21);
            this.radioButton2Centimeter.TabIndex = 1;
            this.radioButton2Centimeter.TabStop = true;
            this.radioButton2Centimeter.Text = "Сантиметр";
            this.radioButton2Centimeter.UseVisualStyleBackColor = true;
            
            // 
            // radioButtonMetre
            // 
            this.radioButtonMetre.AutoSize = true;
            this.radioButtonMetre.Checked = true;
            this.radioButtonMetre.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButtonMetre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonMetre.Location = new System.Drawing.Point(19, 36);
            this.radioButtonMetre.Name = "radioButtonMetre";
            this.radioButtonMetre.Size = new System.Drawing.Size(63, 21);
            this.radioButtonMetre.TabIndex = 0;
            this.radioButtonMetre.TabStop = true;
            this.radioButtonMetre.Text = "Метр";
            this.radioButtonMetre.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(783, 342);
            this.Controls.Add(this.length);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resInch);
            this.Controls.Add(this.resultLeag);
            this.Controls.Add(this.resultNMile);
            this.Controls.Add(this.resultMile);
            this.Controls.Add(this.resultYd);
            this.Controls.Add(this.resultInch);
            this.Controls.Add(this.resLeag);
            this.Controls.Add(this.resNMile);
            this.Controls.Add(this.resYd);
            this.Controls.Add(this.resMile);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.resFt);
            this.Controls.Add(this.resultFt);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Перевод длины";
           
            this.length.ResumeLayout(false);
            this.length.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resultFt;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label resultInch;
        private System.Windows.Forms.Label resultYd;
        private System.Windows.Forms.Label resultMile;
        private System.Windows.Forms.Label resultNMile;
        private System.Windows.Forms.Label resultLeag;
        private System.Windows.Forms.Label resFt;
        private System.Windows.Forms.Label resMile;
        private System.Windows.Forms.Label resYd;
        private System.Windows.Forms.Label resNMile;
        private System.Windows.Forms.Label resLeag;
        private System.Windows.Forms.Label resInch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox length;
        private System.Windows.Forms.RadioButton radioButton3Kilometer;
        private System.Windows.Forms.RadioButton radioButton2Centimeter;
        private System.Windows.Forms.RadioButton radioButtonMetre;
    }
}

