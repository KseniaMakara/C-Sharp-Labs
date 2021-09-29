
namespace DataBase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.select = new System.Windows.Forms.TabPage();
            this.insert = new System.Windows.Forms.TabPage();
            this.update = new System.Windows.Forms.TabPage();
            this.delete = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.xp = new System.Windows.Forms.Label();
            this.children = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.select.SuspendLayout();
            this.insert.SuspendLayout();
            this.update.SuspendLayout();
            this.delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.select);
            this.tabControl1.Controls.Add(this.insert);
            this.tabControl1.Controls.Add(this.update);
            this.tabControl1.Controls.Add(this.delete);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // select
            // 
            this.select.Controls.Add(this.listBox1);
            this.select.Location = new System.Drawing.Point(4, 22);
            this.select.Name = "select";
            this.select.Padding = new System.Windows.Forms.Padding(3);
            this.select.Size = new System.Drawing.Size(792, 400);
            this.select.TabIndex = 0;
            this.select.Text = "SELECT";
            this.select.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            this.insert.Controls.Add(this.button1);
            this.insert.Controls.Add(this.textBox5);
            this.insert.Controls.Add(this.textBox4);
            this.insert.Controls.Add(this.textBox3);
            this.insert.Controls.Add(this.position);
            this.insert.Controls.Add(this.salary);
            this.insert.Controls.Add(this.children);
            this.insert.Controls.Add(this.xp);
            this.insert.Controls.Add(this.textBox2);
            this.insert.Controls.Add(this.name);
            this.insert.Controls.Add(this.textBox1);
            this.insert.Location = new System.Drawing.Point(4, 22);
            this.insert.Name = "insert";
            this.insert.Padding = new System.Windows.Forms.Padding(3);
            this.insert.Size = new System.Drawing.Size(792, 400);
            this.insert.TabIndex = 1;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Controls.Add(this.label6);
            this.update.Controls.Add(this.id);
            this.update.Controls.Add(this.button2);
            this.update.Controls.Add(this.textBox6);
            this.update.Controls.Add(this.textBox7);
            this.update.Controls.Add(this.textBox8);
            this.update.Controls.Add(this.label1);
            this.update.Controls.Add(this.label2);
            this.update.Controls.Add(this.label3);
            this.update.Controls.Add(this.label4);
            this.update.Controls.Add(this.textBox9);
            this.update.Controls.Add(this.label5);
            this.update.Controls.Add(this.textBox10);
            this.update.Location = new System.Drawing.Point(4, 22);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(792, 400);
            this.update.TabIndex = 2;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Controls.Add(this.del);
            this.delete.Location = new System.Drawing.Point(4, 22);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(792, 400);
            this.delete.TabIndex = 3;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(786, 394);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(8, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(62, 23);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // xp
            // 
            this.xp.Location = new System.Drawing.Point(475, 19);
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(62, 23);
            this.xp.TabIndex = 3;
            this.xp.Text = "Experience";
            this.xp.Click += new System.EventHandler(this.xp_Click);
            // 
            // children
            // 
            this.children.Location = new System.Drawing.Point(367, 19);
            this.children.Name = "children";
            this.children.Size = new System.Drawing.Size(62, 23);
            this.children.TabIndex = 4;
            this.children.Text = "Children";
            this.children.Click += new System.EventHandler(this.children_Click);
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(242, 19);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(62, 23);
            this.salary.TabIndex = 5;
            this.salary.Text = "Salary";
            this.salary.Click += new System.EventHandler(this.salary_Click);
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(129, 19);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(62, 23);
            this.position.TabIndex = 6;
            this.position.Text = "Position";
            this.position.Click += new System.EventHandler(this.position_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(478, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(370, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(245, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(348, 149);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(473, 149);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(581, 149);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(232, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Position";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(345, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(470, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Children";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(578, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Experience";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(235, 149);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(114, 149);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 11;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(282, 256);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(214, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID";
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(34, 33);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 0;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToInsertToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // updateToInsertToolStripMenuItem
            // 
            this.updateToInsertToolStripMenuItem.Name = "updateToInsertToolStripMenuItem";
            this.updateToInsertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToInsertToolStripMenuItem.Text = "Update to insert";
            this.updateToInsertToolStripMenuItem.Click += new System.EventHandler(this.updateToInsertToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.select.ResumeLayout(false);
            this.insert.ResumeLayout(false);
            this.insert.PerformLayout();
            this.update.ResumeLayout(false);
            this.update.PerformLayout();
            this.delete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage select;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage insert;
        private System.Windows.Forms.TabPage update;
        private System.Windows.Forms.TabPage delete;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label children;
        private System.Windows.Forms.Label xp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToInsertToolStripMenuItem;
    }
}

