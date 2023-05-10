namespace ModelView
{
    partial class FilterForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            EditionTypeCheckedListBox = new CheckedListBox();
            FilterButton = new Button();
            ResetButton = new Button();
            textBox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // EditionTypeCheckedListBox
            // 
            EditionTypeCheckedListBox.CheckOnClick = true;
            EditionTypeCheckedListBox.FormattingEnabled = true;
            EditionTypeCheckedListBox.Location = new Point(33, 32);
            EditionTypeCheckedListBox.Margin = new Padding(3, 2, 3, 2);
            EditionTypeCheckedListBox.Name = "EditionTypeCheckedListBox";
            EditionTypeCheckedListBox.Size = new Size(191, 76);
            EditionTypeCheckedListBox.TabIndex = 0;
            EditionTypeCheckedListBox.TabStop = false;
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(33, 177);
            FilterButton.Margin = new Padding(3, 2, 3, 2);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(92, 22);
            FilterButton.TabIndex = 1;
            FilterButton.Text = "Применить";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(140, 177);
            ResetButton.Margin = new Padding(3, 2, 3, 2);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(84, 22);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Сбросить";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(33, 145);
            textBox.Margin = new Padding(3, 2, 3, 2);
            textBox.Name = "textBox";
            textBox.Size = new Size(191, 23);
            textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 128);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск по строке:";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(21, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(215, 109);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип издания";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 216);
            Controls.Add(textBox);
            Controls.Add(ResetButton);
            Controls.Add(FilterButton);
            Controls.Add(EditionTypeCheckedListBox);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox EditionTypeCheckedListBox;
        private Button FilterButton;
        private Button ResetButton;
        private TextBox textBox;
        private Label label1;
        private GroupBox groupBox1;
    }
}
