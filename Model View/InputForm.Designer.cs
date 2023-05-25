namespace ModelView
{
    partial class InputForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            ComboBoxEditionTypes = new ComboBox();
            label1 = new Label();
            bookUserControl1 = new BookUserControl();
            collectionUserControl1 = new CollectionUserControl();
            dissertationUserControl1 = new DissertationUserControl();
            magazineUserControl1 = new MagazineUserControl();
            groupBox1 = new GroupBox();
            OKbutton = new Button();
            Cancelbutton = new Button();
            RandomButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxEditionTypes
            // 
            ComboBoxEditionTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEditionTypes.ForeColor = SystemColors.WindowText;
            ComboBoxEditionTypes.FormattingEnabled = true;
            ComboBoxEditionTypes.Location = new Point(41, 40);
            ComboBoxEditionTypes.Margin = new Padding(3, 2, 3, 2);
            ComboBoxEditionTypes.Name = "ComboBoxEditionTypes";
            ComboBoxEditionTypes.Size = new Size(141, 23);
            ComboBoxEditionTypes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Тип издания:";
            // 
            // bookUserControl1
            // 
            bookUserControl1.BackColor = SystemColors.MenuBar;
            bookUserControl1.Location = new Point(20, 20);
            bookUserControl1.Name = "bookUserControl1";
            bookUserControl1.Size = new Size(312, 370);
            bookUserControl1.TabIndex = 2;
            bookUserControl1.Visible = false;
            // 
            // collectionUserControl1
            // 
            collectionUserControl1.BackColor = SystemColors.MenuBar;
            collectionUserControl1.Location = new Point(20, 20);
            collectionUserControl1.Name = "collectionUserControl1";
            collectionUserControl1.Size = new Size(312, 370);
            collectionUserControl1.TabIndex = 3;
            collectionUserControl1.Visible = false;
            // 
            // dissertationUserControl1
            // 
            dissertationUserControl1.BackColor = SystemColors.MenuBar;
            dissertationUserControl1.Location = new Point(20, 20);
            dissertationUserControl1.Name = "dissertationUserControl1";
            dissertationUserControl1.Size = new Size(312, 370);
            dissertationUserControl1.TabIndex = 4;
            dissertationUserControl1.Visible = false;
            // 
            // magazineUserControl1
            // 
            magazineUserControl1.BackColor = SystemColors.MenuBar;
            magazineUserControl1.Location = new Point(20, 20);
            magazineUserControl1.Name = "magazineUserControl1";
            magazineUserControl1.Size = new Size(312, 370);
            magazineUserControl1.TabIndex = 5;
            magazineUserControl1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(collectionUserControl1);
            groupBox1.Controls.Add(dissertationUserControl1);
            groupBox1.Controls.Add(magazineUserControl1);
            groupBox1.Controls.Add(bookUserControl1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(21, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 397);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация об издании";
            // 
            // OKbutton
            // 
            OKbutton.Location = new Point(175, 481);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(96, 30);
            OKbutton.TabIndex = 7;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Location = new Point(277, 481);
            Cancelbutton.Margin = new Padding(3, 2, 3, 2);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(96, 30);
            Cancelbutton.TabIndex = 8;
            Cancelbutton.Text = "Отмена";
            Cancelbutton.UseVisualStyleBackColor = true;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // RandomButton
            // 
            RandomButton.BackColor = SystemColors.GradientActiveCaption;
            RandomButton.FlatStyle = FlatStyle.Flat;
            RandomButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RandomButton.Location = new Point(23, 481);
            RandomButton.Name = "RandomButton";
            RandomButton.Size = new Size(136, 27);
            RandomButton.TabIndex = 13;
            RandomButton.Text = "Случайное издание";
            RandomButton.UseVisualStyleBackColor = false;
            RandomButton.Click += AddRandomEditionButton_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 522);
            Controls.Add(RandomButton);
            Controls.Add(Cancelbutton);
            Controls.Add(OKbutton);
            Controls.Add(groupBox1);
            Controls.Add(ComboBoxEditionTypes);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "InputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление издания";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxEditionTypes;
        private Label label1;
        private BookUserControl bookUserControl1;
        private CollectionUserControl collectionUserControl1;
        private DissertationUserControl dissertationUserControl1;
        private MagazineUserControl magazineUserControl1;
        private GroupBox groupBox1;
        private Button OKbutton;
        private Button Cancelbutton;
        private Button RandomButton;
    }
}
