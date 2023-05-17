﻿namespace ModelView
{
    partial class CollectionUserControl
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
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(224, 272);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 27;
            label7.Text = "Кол-во страниц";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Window;
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Location = new Point(195, 296);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.MaxLength = 5;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Введите число";
            textBox6.Size = new Size(159, 27);
            textBox6.TabIndex = 26;
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.KeyPress += CountPage_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 272);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 25;
            label6.Text = "Год публикации";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 205);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 24;
            label5.Text = "Издатель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 139);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 23;
            label4.Text = "Место публикации";
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(1, 296);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.MaxLength = 5;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Введите число";
            textBox5.Size = new Size(159, 27);
            textBox5.TabIndex = 22;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.KeyPress += Year_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(1, 229);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Введите текст";
            textBox4.Size = new Size(354, 27);
            textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(1, 163);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введите текст";
            textBox3.Size = new Size(354, 27);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(1, 96);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Введите текст";
            textBox2.Size = new Size(354, 27);
            textBox2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 75);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 16;
            label2.Text = "Наименование конференции";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 4);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 15;
            label1.Text = "Наименование сборника";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(1, 29);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите текст";
            textBox1.Size = new Size(354, 27);
            textBox1.TabIndex = 14;
            // 
            // CollectionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CollectionUserControl";
            Size = new Size(357, 493);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}
