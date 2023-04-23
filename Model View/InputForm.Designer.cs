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
            ComboBoxEditionTypes = new ComboBox();
            label1 = new Label();
            bookUserControl1 = new BookUserControl();
            collectionUserControl1 = new CollectionUserControl();
            dissertationUserControl1 = new DissertationUserControl();
            magazineUserControl1 = new MagazineUserControl();
            groupBox1 = new GroupBox();
            OKbutton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxEditionTypes
            // 
            ComboBoxEditionTypes.ForeColor = SystemColors.MenuText;
            ComboBoxEditionTypes.FormattingEnabled = true;
            ComboBoxEditionTypes.Location = new Point(68, 40);
            ComboBoxEditionTypes.Margin = new Padding(3, 2, 3, 2);
            ComboBoxEditionTypes.Name = "ComboBoxEditionTypes";
            ComboBoxEditionTypes.Size = new Size(227, 23);
            ComboBoxEditionTypes.TabIndex = 0;
            ComboBoxEditionTypes.Text = "Выберите тип издания";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Тип издания:";
            // 
            // bookUserControl1
            // 
            bookUserControl1.BackColor = SystemColors.MenuBar;
            bookUserControl1.Location = new Point(20, 20);
            bookUserControl1.Margin = new Padding(3, 2, 3, 2);
            bookUserControl1.Name = "bookUserControl1";
            bookUserControl1.Size = new Size(312, 370);
            bookUserControl1.TabIndex = 2;
            bookUserControl1.Visible = false;
            // 
            // collectionUserControl1
            // 
            collectionUserControl1.BackColor = SystemColors.MenuBar;
            collectionUserControl1.Location = new Point(20, 20);
            collectionUserControl1.Margin = new Padding(3, 2, 3, 2);
            collectionUserControl1.Name = "collectionUserControl1";
            collectionUserControl1.Size = new Size(312, 370);
            collectionUserControl1.TabIndex = 3;
            collectionUserControl1.Visible = false;
            // 
            // dissertationUserControl1
            // 
            dissertationUserControl1.BackColor = SystemColors.MenuBar;
            dissertationUserControl1.Location = new Point(20, 20);
            dissertationUserControl1.Margin = new Padding(3, 2, 3, 2);
            dissertationUserControl1.Name = "dissertationUserControl1";
            dissertationUserControl1.Size = new Size(312, 370);
            dissertationUserControl1.TabIndex = 4;
            dissertationUserControl1.Visible = false;
            // 
            // magazineUserControl1
            // 
            magazineUserControl1.BackColor = SystemColors.MenuBar;
            magazineUserControl1.Location = new Point(20, 20);
            magazineUserControl1.Margin = new Padding(3, 2, 3, 2);
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
            OKbutton.Location = new Point(275, 497);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(98, 29);
            OKbutton.TabIndex = 7;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 549);
            Controls.Add(OKbutton);
            Controls.Add(groupBox1);
            Controls.Add(ComboBoxEditionTypes);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InputForm";
            Text = "Добавление издания";
            Load += InputForm_Load;
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
    }
}
