namespace LAB10
{
    partial class Storehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storehouse));
            this.itemCollection = new System.Windows.Forms.ListBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.countInput = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.generalInfoLabel = new System.Windows.Forms.Label();
            this.generalInfoOutput = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.RichTextBox();
            this.itemListLabel = new System.Windows.Forms.Label();
            this.showList = new System.Windows.Forms.Button();
            this.itemCollectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemCollection
            // 
            this.itemCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemCollection.ForeColor = System.Drawing.SystemColors.Desktop;
            this.itemCollection.FormattingEnabled = true;
            this.itemCollection.ItemHeight = 16;
            this.itemCollection.Location = new System.Drawing.Point(10, 103);
            this.itemCollection.Name = "itemCollection";
            this.itemCollection.Size = new System.Drawing.Size(267, 68);
            this.itemCollection.TabIndex = 0;
            this.itemCollection.DoubleClick += new System.EventHandler(this.itemCollection_DoubleClick);
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameInput.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nameInput.Location = new System.Drawing.Point(12, 222);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(265, 22);
            this.nameInput.TabIndex = 1;
            this.nameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameInput_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameLabel.Location = new System.Drawing.Point(9, 203);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(175, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Наименование товара";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.priceLabel.Location = new System.Drawing.Point(12, 251);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(114, 16);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Цена за штуку";
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceInput.ForeColor = System.Drawing.SystemColors.Desktop;
            this.priceInput.Location = new System.Drawing.Point(12, 270);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(265, 22);
            this.priceInput.TabIndex = 3;
            this.priceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceInput_KeyPress);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.countLabel.Location = new System.Drawing.Point(12, 302);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(95, 16);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Количество";
            // 
            // countInput
            // 
            this.countInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countInput.ForeColor = System.Drawing.SystemColors.Desktop;
            this.countInput.Location = new System.Drawing.Point(12, 321);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(265, 22);
            this.countInput.TabIndex = 5;
            this.countInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countInput_KeyPress);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addBtn.Location = new System.Drawing.Point(109, 357);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editBtn.Location = new System.Drawing.Point(12, 357);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(95, 23);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteBtn.Location = new System.Drawing.Point(203, 357);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(83, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.saveBtn.Location = new System.Drawing.Point(524, 251);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(176, 27);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Сохранить в файл";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.DarkRed;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.resetBtn.Location = new System.Drawing.Point(12, 405);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 48);
            this.resetBtn.TabIndex = 11;
            this.resetBtn.Text = "Сброс";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // generalInfoLabel
            // 
            this.generalInfoLabel.AutoSize = true;
            this.generalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalInfoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.generalInfoLabel.Location = new System.Drawing.Point(344, 302);
            this.generalInfoLabel.Name = "generalInfoLabel";
            this.generalInfoLabel.Size = new System.Drawing.Size(151, 16);
            this.generalInfoLabel.TabIndex = 12;
            this.generalInfoLabel.Text = "Общая информация";
            // 
            // generalInfoOutput
            // 
            this.generalInfoOutput.AutoSize = true;
            this.generalInfoOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalInfoOutput.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.generalInfoOutput.Location = new System.Drawing.Point(344, 328);
            this.generalInfoOutput.Name = "generalInfoOutput";
            this.generalInfoOutput.Size = new System.Drawing.Size(0, 16);
            this.generalInfoOutput.TabIndex = 13;
            // 
            // itemList
            // 
            this.itemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemList.Location = new System.Drawing.Point(347, 103);
            this.itemList.Name = "itemList";
            this.itemList.ReadOnly = true;
            this.itemList.Size = new System.Drawing.Size(381, 139);
            this.itemList.TabIndex = 15;
            this.itemList.Text = "";
            // 
            // itemListLabel
            // 
            this.itemListLabel.AutoSize = true;
            this.itemListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemListLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.itemListLabel.Location = new System.Drawing.Point(344, 78);
            this.itemListLabel.Name = "itemListLabel";
            this.itemListLabel.Size = new System.Drawing.Size(150, 16);
            this.itemListLabel.TabIndex = 16;
            this.itemListLabel.Text = "Имеющиеся товары";
            // 
            // showList
            // 
            this.showList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.showList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showList.Location = new System.Drawing.Point(347, 251);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(171, 26);
            this.showList.TabIndex = 17;
            this.showList.Text = "Показать список";
            this.showList.UseVisualStyleBackColor = false;
            this.showList.Click += new System.EventHandler(this.showList_Click);
            // 
            // itemCollectionLabel
            // 
            this.itemCollectionLabel.AutoSize = true;
            this.itemCollectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemCollectionLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.itemCollectionLabel.Location = new System.Drawing.Point(8, 71);
            this.itemCollectionLabel.Name = "itemCollectionLabel";
            this.itemCollectionLabel.Size = new System.Drawing.Size(176, 20);
            this.itemCollectionLabel.TabIndex = 14;
            this.itemCollectionLabel.Text = "Имеющиеся товары";
            // 
            // Storehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 492);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.itemListLabel);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.itemCollectionLabel);
            this.Controls.Add(this.generalInfoOutput);
            this.Controls.Add(this.generalInfoLabel);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.countInput);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.itemCollection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Storehouse";
            this.Text = "Склад";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemCollection;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox countInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label generalInfoLabel;
        private System.Windows.Forms.Label generalInfoOutput;
        private System.Windows.Forms.RichTextBox itemList;
        private System.Windows.Forms.Label itemListLabel;
        private System.Windows.Forms.Button showList;
        private System.Windows.Forms.Label itemCollectionLabel;
    }
}

