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
            SuspendLayout();
            // 
            // ComboBoxEditionTypes
            // 
            ComboBoxEditionTypes.FormattingEnabled = true;
            ComboBoxEditionTypes.Location = new Point(12, 40);
            ComboBoxEditionTypes.Name = "ComboBoxEditionTypes";
            ComboBoxEditionTypes.Size = new Size(222, 28);
            ComboBoxEditionTypes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 450);
            Controls.Add(label1);
            Controls.Add(ComboBoxEditionTypes);
            Name = "InputForm";
            Text = "InputForm";
            Load += InputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxEditionTypes;
        private Label label1;
    }
}
