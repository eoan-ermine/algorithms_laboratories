namespace LaboratoryWorksGUI
{
    partial class Laboratory5Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.outputView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aInput = new System.Windows.Forms.TextBox();
            this.bInput = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outputView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(-11, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1081, 2);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Работа с одномерными массивами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Лабораторная работа №5";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(0, 532);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1081, 2);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(979, 564);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(877, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "К условию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputView
            // 
            this.outputView.AllowUserToAddRows = false;
            this.outputView.AllowUserToDeleteRows = false;
            this.outputView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputView.Location = new System.Drawing.Point(20, 106);
            this.outputView.Name = "outputView";
            this.outputView.ReadOnly = true;
            this.outputView.RowHeadersWidth = 51;
            this.outputView.RowTemplate.Height = 24;
            this.outputView.Size = new System.Drawing.Size(1024, 150);
            this.outputView.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Генерация исходных данных";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Нижний предел (включительно):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Верхний предел (включительно):";
            // 
            // aInput
            // 
            this.aInput.Location = new System.Drawing.Point(376, 366);
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(100, 22);
            this.aInput.TabIndex = 21;
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(376, 416);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(100, 22);
            this.bInput.TabIndex = 22;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.Location = new System.Drawing.Point(25, 458);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(451, 42);
            this.generateButton.TabIndex = 23;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(229, 325);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(100, 22);
            this.lengthInput.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Кол-во элементов:";
            // 
            // Laboratory5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 607);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Laboratory5Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №5 - решение";
            ((System.ComponentModel.ISupportInitialize)(this.outputView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView outputView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aInput;
        private System.Windows.Forms.TextBox bInput;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.Label label8;
    }
}