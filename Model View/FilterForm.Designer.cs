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
            button2 = new Button();
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
            // button2
            // 
            button2.Location = new Point(215, 251);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 288);
            Controls.Add(button2);
            Controls.Add(FilterButton);
            Controls.Add(EditionTypeCheckedListBox);
            Name = "FilterForm";
            Text = "FolterForm";
            Load += FilterForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox EditionTypeCheckedListBox;
        private Button FilterButton;
        private Button button2;
    }
}