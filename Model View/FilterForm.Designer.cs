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
            EditionTypeCheckedListBox.Location = new Point(38, 43);
            EditionTypeCheckedListBox.Name = "EditionTypeCheckedListBox";
            EditionTypeCheckedListBox.Size = new Size(218, 92);
            EditionTypeCheckedListBox.TabIndex = 0;
            EditionTypeCheckedListBox.TabStop = false;
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(38, 236);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(105, 29);
            FilterButton.TabIndex = 1;
            FilterButton.Text = "Применить";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(160, 236);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(96, 29);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Сбросить";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(38, 193);
            textBox.Name = "textBox";
            textBox.Size = new Size(218, 27);
            textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 171);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 4;
            label1.Text = "Поиск по строке:";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 145);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип издания";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 288);
            Controls.Add(textBox);
            Controls.Add(ResetButton);
            Controls.Add(FilterButton);
            Controls.Add(EditionTypeCheckedListBox);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilterForm";
            FormClosing += FilterForm_FormClosing;
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
