namespace ModelView
{
    partial class MagazineUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Window;
            textBox7.Cursor = Cursors.IBeam;
            textBox7.Location = new Point(171, 272);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Введите число";
            textBox7.Size = new Size(140, 23);
            textBox7.TabIndex = 26;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Location = new Point(1, 272);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Введите число";
            textBox6.Size = new Size(140, 23);
            textBox6.TabIndex = 22;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(1, 222);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Введите текст";
            textBox5.Size = new Size(310, 23);
            textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(1, 172);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Введите текст";
            textBox4.Size = new Size(310, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(1, 122);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введите текст";
            textBox3.Size = new Size(310, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(1, 72);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Введите текст";
            textBox2.Size = new Size(310, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(1, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите текст";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 254);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 27;
            label7.Text = "Кол-во страниц";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 254);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 25;
            label6.Text = "Год публикации";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 204);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 24;
            label5.Text = "Главный редактор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 154);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 23;
            label4.Text = "Место публикации";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 104);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 17;
            label3.Text = "Организация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 56);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 16;
            label2.Text = "Тип";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 3);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 15;
            label1.Text = "Наименование";
            // 
            // MagazineUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MagazineUserControl";
            Size = new Size(312, 370);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
