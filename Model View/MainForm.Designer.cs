namespace ModelView
{
    partial class MainForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            EditionDataGridView = new DataGridView();
            AddButton = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            çàãðóçèòüToolStripMenuItem = new ToolStripMenuItem();
            ñîõðàíèòüToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)EditionDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // EditionDataGridView
            // 
            EditionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EditionDataGridView.Location = new Point(16, 92);
            EditionDataGridView.Name = "EditionDataGridView";
            EditionDataGridView.RowHeadersWidth = 51;
            EditionDataGridView.RowTemplate.Height = 29;
            EditionDataGridView.Size = new Size(744, 262);
            EditionDataGridView.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.AccessibleDescription = "âàûâàûâàìâàìâàì";
            AddButton.AccessibleName = "âàìâàì";
            AddButton.AccessibleRole = AccessibleRole.Caret;
            AddButton.AutoSize = true;
            AddButton.BackColor = SystemColors.ScrollBar;
            AddButton.BackgroundImage = (Image)resources.GetObject("AddButton.BackgroundImage");
            AddButton.BackgroundImageLayout = ImageLayout.Zoom;
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Akrobat Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.ForeColor = SystemColors.ScrollBar;
            AddButton.Location = new Point(15, 46);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(40, 40);
            AddButton.TabIndex = 1;
            AddButton.Text = "\r\n";
            AddButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(EditionDataGridView);
            groupBox1.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 389);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Áèáëèîòå÷íûå èçäàíèÿ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Akrobat Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ScrollBar;
            button1.Location = new Point(70, 46);
            button1.Name = "button1";
            button1.Size = new Size(35, 40);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ScrollBar;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(67, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çàãðóçèòüToolStripMenuItem, ñîõðàíèòüToolStripMenuItem });
            loadToolStripMenuItem.ForeColor = Color.Black;
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(59, 24);
            loadToolStripMenuItem.Text = "Ôàéë";
            // 
            // çàãðóçèòüToolStripMenuItem
            // 
            çàãðóçèòüToolStripMenuItem.Name = "çàãðóçèòüToolStripMenuItem";
            çàãðóçèòüToolStripMenuItem.Size = new Size(166, 26);
            çàãðóçèòüToolStripMenuItem.Text = "Çàãðóçèòü";
            // 
            // ñîõðàíèòüToolStripMenuItem
            // 
            ñîõðàíèòüToolStripMenuItem.Name = "ñîõðàíèòüToolStripMenuItem";
            ñîõðàíèòüToolStripMenuItem.Size = new Size(166, 26);
            ñîõðàíèòüToolStripMenuItem.Text = "Ñîõðàíèòü";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)EditionDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView EditionDataGridView;
        private Button AddButton;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem çàãðóçèòüToolStripMenuItem;
        private ToolStripMenuItem ñîõðàíèòüToolStripMenuItem;
        private Button button1;
    }
}
