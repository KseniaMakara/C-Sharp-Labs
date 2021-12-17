
namespace Lab3._1DB
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.maxRate = new System.Windows.Forms.Button();
            this.numCourse = new System.Windows.Forms.NumericUpDown();
            this.textFilterName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxValueRate = new System.Windows.Forms.Button();
            this.countStud = new System.Windows.Forms.Button();
            this.buttonIF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(497, 26);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 35);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Filter by course";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // maxRate
            // 
            this.maxRate.Location = new System.Drawing.Point(497, 132);
            this.maxRate.Name = "maxRate";
            this.maxRate.Size = new System.Drawing.Size(120, 32);
            this.maxRate.TabIndex = 2;
            this.maxRate.Text = "Find by name";
            this.maxRate.UseVisualStyleBackColor = true;
            this.maxRate.Click += new System.EventHandler(this.maxRate_Click);
            // 
            // numCourse
            // 
            this.numCourse.Location = new System.Drawing.Point(497, 86);
            this.numCourse.Name = "numCourse";
            this.numCourse.Size = new System.Drawing.Size(120, 20);
            this.numCourse.TabIndex = 3;
            // 
            // textFilterName
            // 
            this.textFilterName.Location = new System.Drawing.Point(497, 182);
            this.textFilterName.Name = "textFilterName";
            this.textFilterName.Size = new System.Drawing.Size(120, 20);
            this.textFilterName.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete minimum";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Plus number of v12";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxValueRate
            // 
            this.MaxValueRate.Location = new System.Drawing.Point(651, 77);
            this.MaxValueRate.Name = "MaxValueRate";
            this.MaxValueRate.Size = new System.Drawing.Size(87, 35);
            this.MaxValueRate.TabIndex = 7;
            this.MaxValueRate.Text = "Max Rate";
            this.MaxValueRate.UseVisualStyleBackColor = true;
            this.MaxValueRate.Click += new System.EventHandler(this.MaxValueRate_Click);
            // 
            // countStud
            // 
            this.countStud.Location = new System.Drawing.Point(651, 132);
            this.countStud.Name = "countStud";
            this.countStud.Size = new System.Drawing.Size(87, 35);
            this.countStud.TabIndex = 8;
            this.countStud.Text = "Count students on course";
            this.countStud.UseVisualStyleBackColor = true;
            this.countStud.Click += new System.EventHandler(this.countStud_Click);
            // 
            // buttonIF
            // 
            this.buttonIF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIF.Location = new System.Drawing.Point(651, 182);
            this.buttonIF.Name = "buttonIF";
            this.buttonIF.Size = new System.Drawing.Size(87, 66);
            this.buttonIF.TabIndex = 9;
            this.buttonIF.Text = "Студенти де середный бал вищий за 60";
            this.buttonIF.UseVisualStyleBackColor = true;
            this.buttonIF.Click += new System.EventHandler(this.buttonIF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 524);
            this.Controls.Add(this.buttonIF);
            this.Controls.Add(this.countStud);
            this.Controls.Add(this.MaxValueRate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textFilterName);
            this.Controls.Add(this.numCourse);
            this.Controls.Add(this.maxRate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button maxRate;
        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.TextBox textFilterName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MaxValueRate;
        private System.Windows.Forms.Button countStud;
        private System.Windows.Forms.Button buttonIF;
    }
}

