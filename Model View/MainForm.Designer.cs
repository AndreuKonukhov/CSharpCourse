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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            EditionDataGridView = new DataGridView();
            AddButton = new Button();
            groupBox1 = new GroupBox();
            ClearButton = new Button();
            RemoveButton = new Button();
            menuStrip1 = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)EditionDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // EditionDataGridView
            // 
            EditionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EditionDataGridView.BackgroundColor = SystemColors.InactiveBorder;
            EditionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EditionDataGridView.GridColor = SystemColors.GrayText;
            EditionDataGridView.Location = new Point(16, 92);
            EditionDataGridView.Name = "EditionDataGridView";
            EditionDataGridView.RowHeadersVisible = false;
            EditionDataGridView.RowHeadersWidth = 51;
            EditionDataGridView.RowTemplate.Height = 29;
            EditionDataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
            EditionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EditionDataGridView.Size = new Size(948, 262);
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
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(RemoveButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(EditionDataGridView);
            groupBox1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 412);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Библиотечные издания";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(16, 360);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
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
            RemoveButton.Location = new Point(70, 46);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(35, 40);
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
            menuStrip1.Size = new Size(67, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьToolStripMenuItem, сохранитьToolStripMenuItem });
            loadToolStripMenuItem.ForeColor = Color.Black;
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(59, 24);
            loadToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(166, 26);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1018, 473);
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
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private Button RemoveButton;
        private Button ClearButton;
    }
}
