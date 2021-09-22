
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listE = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xp = new System.Windows.Forms.NumericUpDown();
            this.Children = new System.Windows.Forms.NumericUpDown();
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serializeE = new System.Windows.Forms.Button();
            this.DeserializeE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Children)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // listE
            // 
            this.listE.HideSelection = false;
            this.listE.Location = new System.Drawing.Point(12, 46);
            this.listE.Name = "listE";
            this.listE.Size = new System.Drawing.Size(239, 250);
            this.listE.TabIndex = 0;
            this.listE.UseCompatibleStateImageBehavior = false;
            this.listE.View = System.Windows.Forms.View.List;
            this.listE.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xp);
            this.panel1.Controls.Add(this.Children);
            this.panel1.Controls.Add(this.Salary);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(289, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 250);
            this.panel1.TabIndex = 1;
            // 
            // xp
            // 
            this.xp.Location = new System.Drawing.Point(95, 202);
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(225, 23);
            this.xp.TabIndex = 12;
            // 
            // Children
            // 
            this.Children.Location = new System.Drawing.Point(95, 149);
            this.Children.Name = "Children";
            this.Children.Size = new System.Drawing.Size(225, 23);
            this.Children.TabIndex = 11;
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(95, 107);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(225, 23);
            this.Salary.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 23);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Experience";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Children";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(643, 46);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(98, 47);
            this.add.TabIndex = 0;
            this.add.Text = "Add new employees";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serializeE
            // 
            this.serializeE.BackColor = System.Drawing.Color.Yellow;
            this.serializeE.Location = new System.Drawing.Point(643, 120);
            this.serializeE.Name = "serializeE";
            this.serializeE.Size = new System.Drawing.Size(98, 27);
            this.serializeE.TabIndex = 13;
            this.serializeE.Text = "Serialize";
            this.serializeE.UseVisualStyleBackColor = false;
            this.serializeE.Click += new System.EventHandler(this.serializeE_Click);
            // 
            // DeserializeE
            // 
            this.DeserializeE.BackColor = System.Drawing.Color.IndianRed;
            this.DeserializeE.Location = new System.Drawing.Point(643, 164);
            this.DeserializeE.Name = "DeserializeE";
            this.DeserializeE.Size = new System.Drawing.Size(98, 29);
            this.DeserializeE.TabIndex = 14;
            this.DeserializeE.Text = "Deserialize";
            this.DeserializeE.UseVisualStyleBackColor = false;
            this.DeserializeE.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeserializeE);
            this.Controls.Add(this.serializeE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Children)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown xp;
        private System.Windows.Forms.NumericUpDown Children;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button serializeE;
        private System.Windows.Forms.Button DeserializeE;
    }
}

