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
            EditionTypeCheckedListBox = new CheckedListBox();
            FilterButton = new Button();
            ResetButton = new Button();
            textBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // EditionTypeCheckedListBox
            // 
            EditionTypeCheckedListBox.FormattingEnabled = true;
            EditionTypeCheckedListBox.Location = new Point(38, 42);
            EditionTypeCheckedListBox.Name = "EditionTypeCheckedListBox";
            EditionTypeCheckedListBox.Size = new Size(159, 114);
            EditionTypeCheckedListBox.TabIndex = 0;
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(24, 251);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(105, 29);
            FilterButton.TabIndex = 1;
            FilterButton.Text = "Применить";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(215, 251);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Сбросить";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(38, 193);
            textBox.Name = "textBox";
            textBox.Size = new Size(199, 27);
            textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 170);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 4;
            label1.Text = "Поиск по строке:";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 288);
            Controls.Add(label1);
            Controls.Add(textBox);
            Controls.Add(ResetButton);
            Controls.Add(FilterButton);
            Controls.Add(EditionTypeCheckedListBox);
            Name = "FilterForm";
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
    }
}
