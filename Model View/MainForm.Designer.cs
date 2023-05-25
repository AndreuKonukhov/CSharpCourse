using System.Windows.Forms;

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
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            EditionDataGridView = new DataGridView();
            AddButton = new Button();
            groupBox1 = new GroupBox();
            FilterButton = new Button();
            ClearButton = new Button();
            RemoveButton = new Button();
            menuStrip1 = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            LoadFileToolStripMenuItem = new ToolStripMenuItem();
            SaveFileToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)EditionDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // EditionDataGridView
            // 
            EditionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EditionDataGridView.BackgroundColor = SystemColors.Menu;
            EditionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial Unicode MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            EditionDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            EditionDataGridView.GridColor = SystemColors.MenuText;
            EditionDataGridView.Location = new Point(14, 54);
            EditionDataGridView.Margin = new Padding(3, 2, 3, 2);
            EditionDataGridView.Name = "EditionDataGridView";
            EditionDataGridView.RowHeadersVisible = false;
            EditionDataGridView.RowHeadersWidth = 51;
            EditionDataGridView.RowTemplate.Height = 29;
            EditionDataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
            EditionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EditionDataGridView.Size = new Size(830, 196);
            EditionDataGridView.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.AccessibleDescription = "ваываывамвамвам";
            AddButton.AccessibleName = "вамвам";
            AddButton.AccessibleRole = AccessibleRole.Caret;
            AddButton.AutoSize = true;
            AddButton.BackColor = SystemColors.ScrollBar;
            AddButton.BackgroundImage = (Image)resources.GetObject("AddButton.BackgroundImage");
            AddButton.BackgroundImageLayout = ImageLayout.Zoom;
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Akrobat Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.ForeColor = SystemColors.ScrollBar;
            AddButton.Location = new Point(14, 20);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(35, 30);
            AddButton.TabIndex = 1;
            AddButton.Text = "\r\n";
            AddButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(FilterButton);
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(RemoveButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(EditionDataGridView);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.MenuText;
            groupBox1.Location = new Point(10, 43);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(868, 290);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Библиотечные издания";
            // 
            // FilterButton
            // 
            FilterButton.BackColor = SystemColors.ScrollBar;
            FilterButton.BackgroundImage = (Image)resources.GetObject("FilterButton.BackgroundImage");
            FilterButton.BackgroundImageLayout = ImageLayout.Zoom;
            FilterButton.FlatStyle = FlatStyle.Flat;
            FilterButton.ForeColor = SystemColors.ScrollBar;
            FilterButton.Location = new Point(115, 24);
            FilterButton.Margin = new Padding(3, 2, 3, 2);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(38, 26);
            FilterButton.TabIndex = 4;
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = SystemColors.WindowText;
            ClearButton.Location = new Point(13, 252);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(116, 29);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.ScrollBar;
            RemoveButton.BackgroundImage = (Image)resources.GetObject("RemoveButton.BackgroundImage");
            RemoveButton.BackgroundImageLayout = ImageLayout.Stretch;
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Akrobat Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.ForeColor = SystemColors.ScrollBar;
            RemoveButton.Location = new Point(64, 20);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(31, 30);
            RemoveButton.TabIndex = 2;
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ScrollBar;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(55, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LoadFileToolStripMenuItem, SaveFileToolStripMenuItem });
            loadToolStripMenuItem.ForeColor = Color.Black;
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(48, 20);
            loadToolStripMenuItem.Text = "Файл";
            // 
            // LoadFileToolStripMenuItem
            // 
            LoadFileToolStripMenuItem.Name = "LoadFileToolStripMenuItem";
            LoadFileToolStripMenuItem.Size = new Size(133, 22);
            LoadFileToolStripMenuItem.Text = "Загрузить";
            LoadFileToolStripMenuItem.Click += LoadFileToolStripMenuItem_Click;
            // 
            // SaveFileToolStripMenuItem
            // 
            SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            SaveFileToolStripMenuItem.Size = new Size(133, 22);
            SaveFileToolStripMenuItem.Text = "Сохранить";
            SaveFileToolStripMenuItem.Click += SaveFileToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(891, 355);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "иблиотека";
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
        private ToolStripMenuItem LoadFileToolStripMenuItem;
        private ToolStripMenuItem SaveFileToolStripMenuItem;
        private Button RemoveButton;
        private Button ClearButton;
        private Button FilterButton;
    }
}
