namespace Demo1
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
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.txt_result2 = new System.Windows.Forms.TextBox();
            this.txt_result1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sort_reverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(134, 50);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(112, 34);
            this.btn_sum.TabIndex = 0;
            this.btn_sum.Text = "Sum";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(335, 50);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(119, 34);
            this.btn_max.TabIndex = 1;
            this.btn_max.Text = "Max";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(548, 50);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(125, 34);
            this.btn_min.TabIndex = 2;
            this.btn_min.Text = "Min";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(91, 342);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_sort.TabIndex = 3;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // txt_result2
            // 
            this.txt_result2.Location = new System.Drawing.Point(219, 342);
            this.txt_result2.Name = "txt_result2";
            this.txt_result2.Size = new System.Drawing.Size(414, 22);
            this.txt_result2.TabIndex = 4;
            // 
            // txt_result1
            // 
            this.txt_result1.Location = new System.Drawing.Point(232, 118);
            this.txt_result1.Name = "txt_result1";
            this.txt_result1.Size = new System.Drawing.Size(355, 159);
            this.txt_result1.TabIndex = 5;
            this.txt_result1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_sort_reverse
            // 
            this.btn_sort_reverse.Location = new System.Drawing.Point(91, 402);
            this.btn_sort_reverse.Name = "btn_sort_reverse";
            this.btn_sort_reverse.Size = new System.Drawing.Size(112, 23);
            this.btn_sort_reverse.TabIndex = 7;
            this.btn_sort_reverse.Text = "Sort Reverse";
            this.btn_sort_reverse.UseVisualStyleBackColor = true;
            this.btn_sort_reverse.Click += new System.EventHandler(this.btn_sort_reverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sort_reverse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result1);
            this.Controls.Add(this.txt_result2);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TextBox txt_result2;
        private System.Windows.Forms.RichTextBox txt_result1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sort_reverse;
    }
}

