
namespace Lab3._2DB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ex1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ex2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ex3 = new System.Windows.Forms.Button();
            this.exIncrease = new System.Windows.Forms.Button();
            this.exDel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // ex1
            // 
            this.ex1.Location = new System.Drawing.Point(500, 12);
            this.ex1.Name = "ex1";
            this.ex1.Size = new System.Drawing.Size(94, 26);
            this.ex1.TabIndex = 1;
            this.ex1.Text = "Course";
            this.ex1.UseVisualStyleBackColor = true;
            this.ex1.Click += new System.EventHandler(this.ex1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(500, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // ex2
            // 
            this.ex2.Location = new System.Drawing.Point(500, 101);
            this.ex2.Name = "ex2";
            this.ex2.Size = new System.Drawing.Size(94, 26);
            this.ex2.TabIndex = 3;
            this.ex2.Text = "MaxRate";
            this.ex2.UseVisualStyleBackColor = true;
            this.ex2.Click += new System.EventHandler(this.ex2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ex3
            // 
            this.ex3.Location = new System.Drawing.Point(500, 188);
            this.ex3.Name = "ex3";
            this.ex3.Size = new System.Drawing.Size(94, 26);
            this.ex3.TabIndex = 5;
            this.ex3.Text = "Count Category";
            this.ex3.UseVisualStyleBackColor = true;
            this.ex3.Click += new System.EventHandler(this.ex3_Click);
            // 
            // exIncrease
            // 
            this.exIncrease.Location = new System.Drawing.Point(666, 12);
            this.exIncrease.Name = "exIncrease";
            this.exIncrease.Size = new System.Drawing.Size(94, 26);
            this.exIncrease.TabIndex = 6;
            this.exIncrease.Text = "Increase";
            this.exIncrease.UseVisualStyleBackColor = true;
            this.exIncrease.Click += new System.EventHandler(this.exIncrease_Click);
            // 
            // exDel
            // 
            this.exDel.Location = new System.Drawing.Point(666, 64);
            this.exDel.Name = "exDel";
            this.exDel.Size = new System.Drawing.Size(94, 26);
            this.exDel.TabIndex = 7;
            this.exDel.Text = "Delete Minimal";
            this.exDel.UseVisualStyleBackColor = true;
            this.exDel.Click += new System.EventHandler(this.exDel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Check condition for ANY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // all
            // 
            this.all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.all.Location = new System.Drawing.Point(666, 188);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(94, 41);
            this.all.TabIndex = 9;
            this.all.Text = "Check condition for ALL";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.all);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exDel);
            this.Controls.Add(this.exIncrease);
            this.Controls.Add(this.ex3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ex2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ex1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ex1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button ex2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ex3;
        private System.Windows.Forms.Button exIncrease;
        private System.Windows.Forms.Button exDel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button all;
    }
}

