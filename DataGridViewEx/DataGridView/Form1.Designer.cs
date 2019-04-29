namespace DataGridView
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboRowType = new System.Windows.Forms.ComboBox();
            this.comboBoxReadOnly = new System.Windows.Forms.ComboBox();
            this.comboBoxSimple = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "AddRow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "AddCol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 204);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "ColHeader";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(348, 204);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "RowHeader";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 146);
            this.dataGridView1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Item 1",
            "item (2)",
            "Item\\t3",
            "item 4",
            "item 5",
            "item 6",
            "item 7",
            "item 8",
            "item 9",
            "item 10",
            "item 11",
            "item 12",
            "item 13",
            "item 14",
            "item 15",
            "item 16",
            "item 17"});
            this.listBox1.Location = new System.Drawing.Point(4, 276);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 84);
            this.listBox1.TabIndex = 6;
            // 
            // comboRowType
            // 
            this.comboRowType.FormattingEnabled = true;
            this.comboRowType.Items.AddRange(new object[] {
            "Numbers",
            "Letters",
            "Special symbols"});
            this.comboRowType.Location = new System.Drawing.Point(4, 241);
            this.comboRowType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboRowType.Name = "comboRowType";
            this.comboRowType.Size = new System.Drawing.Size(220, 24);
            this.comboRowType.TabIndex = 6;
            // 
            // comboBoxReadOnly
            // 
            this.comboBoxReadOnly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadOnly.FormattingEnabled = true;
            this.comboBoxReadOnly.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Last Item"});
            this.comboBoxReadOnly.Location = new System.Drawing.Point(233, 241);
            this.comboBoxReadOnly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxReadOnly.Name = "comboBoxReadOnly";
            this.comboBoxReadOnly.Size = new System.Drawing.Size(220, 24);
            this.comboBoxReadOnly.TabIndex = 7;
            // 
            // comboBoxSimple
            // 
            this.comboBoxSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxSimple.FormattingEnabled = true;
            this.comboBoxSimple.Items.AddRange(new object[] {
            "Simple 1",
            "Simple Two",
            "The Simplest"});
            this.comboBoxSimple.Location = new System.Drawing.Point(233, 276);
            this.comboBoxSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSimple.MaxDropDownItems = 3;
            this.comboBoxSimple.Name = "comboBoxSimple";
            this.comboBoxSimple.Size = new System.Drawing.Size(220, 88);
            this.comboBoxSimple.TabIndex = 8;
            this.comboBoxSimple.Text = "Simple 1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 132);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tem1ToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.item3ToolStripMenuItem,
            this.item4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(460, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tem1ToolStripMenuItem
            // 
            this.tem1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.itemToolStripMenuItem1});
            this.tem1ToolStripMenuItem.Name = "tem1ToolStripMenuItem";
            this.tem1ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.tem1ToolStripMenuItem.Text = "tem1";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem.Text = "item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem1
            // 
            this.itemToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem2,
            this.itemToolStripMenuItem3,
            this.itemToolStripMenuItem4});
            this.itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            this.itemToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem1.Text = "item";
            // 
            // itemToolStripMenuItem2
            // 
            this.itemToolStripMenuItem2.Name = "itemToolStripMenuItem2";
            this.itemToolStripMenuItem2.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem2.Text = "item";
            // 
            // itemToolStripMenuItem3
            // 
            this.itemToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem5});
            this.itemToolStripMenuItem3.Name = "itemToolStripMenuItem3";
            this.itemToolStripMenuItem3.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem3.Text = "item";
            // 
            // itemToolStripMenuItem5
            // 
            this.itemToolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem6});
            this.itemToolStripMenuItem5.Name = "itemToolStripMenuItem5";
            this.itemToolStripMenuItem5.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem5.Text = "item";
            // 
            // itemToolStripMenuItem6
            // 
            this.itemToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem7,
            this.itemToolStripMenuItem8,
            this.itemToolStripMenuItem9,
            this.itemToolStripMenuItem10,
            this.itemToolStripMenuItem11});
            this.itemToolStripMenuItem6.Name = "itemToolStripMenuItem6";
            this.itemToolStripMenuItem6.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem6.Text = "item";
            // 
            // itemToolStripMenuItem7
            // 
            this.itemToolStripMenuItem7.Name = "itemToolStripMenuItem7";
            this.itemToolStripMenuItem7.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem7.Text = "item";
            // 
            // itemToolStripMenuItem8
            // 
            this.itemToolStripMenuItem8.Name = "itemToolStripMenuItem8";
            this.itemToolStripMenuItem8.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem8.Text = "item";
            // 
            // itemToolStripMenuItem9
            // 
            this.itemToolStripMenuItem9.Name = "itemToolStripMenuItem9";
            this.itemToolStripMenuItem9.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem9.Text = "item";
            // 
            // itemToolStripMenuItem10
            // 
            this.itemToolStripMenuItem10.Name = "itemToolStripMenuItem10";
            this.itemToolStripMenuItem10.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem10.Text = "item";
            // 
            // itemToolStripMenuItem11
            // 
            this.itemToolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem12});
            this.itemToolStripMenuItem11.Name = "itemToolStripMenuItem11";
            this.itemToolStripMenuItem11.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem11.Text = "item";
            // 
            // itemToolStripMenuItem12
            // 
            this.itemToolStripMenuItem12.Name = "itemToolStripMenuItem12";
            this.itemToolStripMenuItem12.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem12.Text = "item";
            this.itemToolStripMenuItem12.Click += new System.EventHandler(this.itemToolStripMenuItem12_Click);
            // 
            // itemToolStripMenuItem4
            // 
            this.itemToolStripMenuItem4.Name = "itemToolStripMenuItem4";
            this.itemToolStripMenuItem4.Size = new System.Drawing.Size(114, 26);
            this.itemToolStripMenuItem4.Text = "item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.item2ToolStripMenuItem.Text = "item2";
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.item3ToolStripMenuItem.Text = "item3";
            // 
            // item4ToolStripMenuItem
            // 
            this.item4ToolStripMenuItem.Name = "item4ToolStripMenuItem";
            this.item4ToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.item4ToolStripMenuItem.Text = "item4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Editable";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "ReadOnly";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 400);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxSimple);
            this.Controls.Add(this.comboBoxReadOnly);
            this.Controls.Add(this.comboRowType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboRowType;
        private System.Windows.Forms.ComboBox comboBoxReadOnly;
        private System.Windows.Forms.ComboBox comboBoxSimple;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item4ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

