namespace Homework1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_res = new System.Windows.Forms.Button();
            this.bt_dot = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_plusminus = new System.Windows.Forms.Button();
            this.bt_plus = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_min = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_mul = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_sqrt = new System.Windows.Forms.Button();
            this.bt_x2 = new System.Windows.Forms.Button();
            this.bt_1divx = new System.Windows.Forms.Button();
            this.bt_bs = new System.Windows.Forms.Button();
            this.bt_c = new System.Windows.Forms.Button();
            this.bt_ce = new System.Windows.Forms.Button();
            this.bt_per = new System.Windows.Forms.Button();
            this.tb_calc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_res);
            this.panel1.Controls.Add(this.bt_dot);
            this.panel1.Controls.Add(this.bt_0);
            this.panel1.Controls.Add(this.bt_plusminus);
            this.panel1.Controls.Add(this.bt_plus);
            this.panel1.Controls.Add(this.bt_3);
            this.panel1.Controls.Add(this.bt_2);
            this.panel1.Controls.Add(this.bt_1);
            this.panel1.Controls.Add(this.bt_min);
            this.panel1.Controls.Add(this.bt_6);
            this.panel1.Controls.Add(this.bt_5);
            this.panel1.Controls.Add(this.bt_4);
            this.panel1.Controls.Add(this.bt_mul);
            this.panel1.Controls.Add(this.bt_9);
            this.panel1.Controls.Add(this.bt_8);
            this.panel1.Controls.Add(this.bt_7);
            this.panel1.Controls.Add(this.bt_div);
            this.panel1.Controls.Add(this.bt_sqrt);
            this.panel1.Controls.Add(this.bt_x2);
            this.panel1.Controls.Add(this.bt_1divx);
            this.panel1.Controls.Add(this.bt_bs);
            this.panel1.Controls.Add(this.bt_c);
            this.panel1.Controls.Add(this.bt_ce);
            this.panel1.Controls.Add(this.bt_per);
            this.panel1.Controls.Add(this.tb_calc);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 460);
            this.panel1.TabIndex = 0;
            // 
            // bt_res
            // 
            this.bt_res.Location = new System.Drawing.Point(285, 390);
            this.bt_res.Margin = new System.Windows.Forms.Padding(0);
            this.bt_res.Name = "bt_res";
            this.bt_res.Size = new System.Drawing.Size(95, 70);
            this.bt_res.TabIndex = 24;
            this.bt_res.Text = "=";
            this.bt_res.UseVisualStyleBackColor = true;
            this.bt_res.Click += new System.EventHandler(this.bt_res_Click);
            // 
            // bt_dot
            // 
            this.bt_dot.Location = new System.Drawing.Point(190, 390);
            this.bt_dot.Margin = new System.Windows.Forms.Padding(0);
            this.bt_dot.Name = "bt_dot";
            this.bt_dot.Size = new System.Drawing.Size(95, 70);
            this.bt_dot.TabIndex = 23;
            this.bt_dot.Text = ",";
            this.bt_dot.UseVisualStyleBackColor = true;
            this.bt_dot.Click += new System.EventHandler(this.bt_dot_Click);
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(95, 390);
            this.bt_0.Margin = new System.Windows.Forms.Padding(0);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(95, 70);
            this.bt_0.TabIndex = 22;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_plusminus
            // 
            this.bt_plusminus.Location = new System.Drawing.Point(0, 390);
            this.bt_plusminus.Margin = new System.Windows.Forms.Padding(0);
            this.bt_plusminus.Name = "bt_plusminus";
            this.bt_plusminus.Size = new System.Drawing.Size(95, 70);
            this.bt_plusminus.TabIndex = 21;
            this.bt_plusminus.Text = "+/-";
            this.bt_plusminus.UseVisualStyleBackColor = true;
            this.bt_plusminus.Click += new System.EventHandler(this.bt_plusminus_Click);
            // 
            // bt_plus
            // 
            this.bt_plus.Location = new System.Drawing.Point(285, 323);
            this.bt_plus.Margin = new System.Windows.Forms.Padding(0);
            this.bt_plus.Name = "bt_plus";
            this.bt_plus.Size = new System.Drawing.Size(95, 70);
            this.bt_plus.TabIndex = 20;
            this.bt_plus.Text = "+";
            this.bt_plus.UseVisualStyleBackColor = true;
            this.bt_plus.Click += new System.EventHandler(this.bt_plus_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(190, 323);
            this.bt_3.Margin = new System.Windows.Forms.Padding(0);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(95, 70);
            this.bt_3.TabIndex = 19;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(95, 323);
            this.bt_2.Margin = new System.Windows.Forms.Padding(0);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(95, 70);
            this.bt_2.TabIndex = 18;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(0, 323);
            this.bt_1.Margin = new System.Windows.Forms.Padding(0);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(95, 70);
            this.bt_1.TabIndex = 17;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_min
            // 
            this.bt_min.Location = new System.Drawing.Point(285, 253);
            this.bt_min.Margin = new System.Windows.Forms.Padding(0);
            this.bt_min.Name = "bt_min";
            this.bt_min.Size = new System.Drawing.Size(95, 70);
            this.bt_min.TabIndex = 16;
            this.bt_min.Text = "-";
            this.bt_min.UseVisualStyleBackColor = true;
            this.bt_min.Click += new System.EventHandler(this.bt_min_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(190, 253);
            this.bt_6.Margin = new System.Windows.Forms.Padding(0);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(95, 70);
            this.bt_6.TabIndex = 15;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(95, 253);
            this.bt_5.Margin = new System.Windows.Forms.Padding(0);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(95, 70);
            this.bt_5.TabIndex = 14;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(0, 253);
            this.bt_4.Margin = new System.Windows.Forms.Padding(0);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(95, 70);
            this.bt_4.TabIndex = 13;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_mul
            // 
            this.bt_mul.Location = new System.Drawing.Point(285, 183);
            this.bt_mul.Margin = new System.Windows.Forms.Padding(0);
            this.bt_mul.Name = "bt_mul";
            this.bt_mul.Size = new System.Drawing.Size(95, 70);
            this.bt_mul.TabIndex = 12;
            this.bt_mul.Text = "×";
            this.bt_mul.UseVisualStyleBackColor = true;
            this.bt_mul.Click += new System.EventHandler(this.bt_mul_Click);
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(190, 183);
            this.bt_9.Margin = new System.Windows.Forms.Padding(0);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(95, 70);
            this.bt_9.TabIndex = 11;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(95, 183);
            this.bt_8.Margin = new System.Windows.Forms.Padding(0);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(95, 70);
            this.bt_8.TabIndex = 10;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(0, 183);
            this.bt_7.Margin = new System.Windows.Forms.Padding(0);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(95, 70);
            this.bt_7.TabIndex = 9;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_div
            // 
            this.bt_div.Location = new System.Drawing.Point(285, 113);
            this.bt_div.Margin = new System.Windows.Forms.Padding(0);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(95, 70);
            this.bt_div.TabIndex = 8;
            this.bt_div.Text = "÷";
            this.bt_div.UseVisualStyleBackColor = true;
            this.bt_div.Click += new System.EventHandler(this.bt_div_Click);
            // 
            // bt_sqrt
            // 
            this.bt_sqrt.Location = new System.Drawing.Point(190, 113);
            this.bt_sqrt.Margin = new System.Windows.Forms.Padding(0);
            this.bt_sqrt.Name = "bt_sqrt";
            this.bt_sqrt.Size = new System.Drawing.Size(95, 70);
            this.bt_sqrt.TabIndex = 7;
            this.bt_sqrt.Text = "√ x";
            this.bt_sqrt.UseVisualStyleBackColor = true;
            this.bt_sqrt.Click += new System.EventHandler(this.bt_sqrt_Click);
            // 
            // bt_x2
            // 
            this.bt_x2.Location = new System.Drawing.Point(95, 113);
            this.bt_x2.Margin = new System.Windows.Forms.Padding(0);
            this.bt_x2.Name = "bt_x2";
            this.bt_x2.Size = new System.Drawing.Size(95, 70);
            this.bt_x2.TabIndex = 6;
            this.bt_x2.Text = "x^2";
            this.bt_x2.UseVisualStyleBackColor = true;
            this.bt_x2.Click += new System.EventHandler(this.bt_x2_Click);
            // 
            // bt_1divx
            // 
            this.bt_1divx.Location = new System.Drawing.Point(0, 113);
            this.bt_1divx.Margin = new System.Windows.Forms.Padding(0);
            this.bt_1divx.Name = "bt_1divx";
            this.bt_1divx.Size = new System.Drawing.Size(95, 70);
            this.bt_1divx.TabIndex = 5;
            this.bt_1divx.Text = "1/x";
            this.bt_1divx.UseVisualStyleBackColor = true;
            this.bt_1divx.Click += new System.EventHandler(this.bt_1divx_Click);
            // 
            // bt_bs
            // 
            this.bt_bs.Location = new System.Drawing.Point(285, 43);
            this.bt_bs.Margin = new System.Windows.Forms.Padding(0);
            this.bt_bs.Name = "bt_bs";
            this.bt_bs.Size = new System.Drawing.Size(95, 70);
            this.bt_bs.TabIndex = 4;
            this.bt_bs.Text = "⌫";
            this.bt_bs.UseVisualStyleBackColor = true;
            this.bt_bs.Click += new System.EventHandler(this.bt_bs_Click);
            // 
            // bt_c
            // 
            this.bt_c.Location = new System.Drawing.Point(190, 43);
            this.bt_c.Margin = new System.Windows.Forms.Padding(0);
            this.bt_c.Name = "bt_c";
            this.bt_c.Size = new System.Drawing.Size(95, 70);
            this.bt_c.TabIndex = 3;
            this.bt_c.Text = "C";
            this.bt_c.UseVisualStyleBackColor = true;
            this.bt_c.Click += new System.EventHandler(this.bt_c_Click);
            // 
            // bt_ce
            // 
            this.bt_ce.Location = new System.Drawing.Point(95, 43);
            this.bt_ce.Margin = new System.Windows.Forms.Padding(0);
            this.bt_ce.Name = "bt_ce";
            this.bt_ce.Size = new System.Drawing.Size(95, 70);
            this.bt_ce.TabIndex = 2;
            this.bt_ce.Text = "CE";
            this.bt_ce.UseVisualStyleBackColor = true;
            this.bt_ce.Click += new System.EventHandler(this.bt_ce_Click);
            // 
            // bt_per
            // 
            this.bt_per.Location = new System.Drawing.Point(0, 43);
            this.bt_per.Margin = new System.Windows.Forms.Padding(0);
            this.bt_per.Name = "bt_per";
            this.bt_per.Size = new System.Drawing.Size(95, 70);
            this.bt_per.TabIndex = 1;
            this.bt_per.Text = "%";
            this.bt_per.UseVisualStyleBackColor = true;
            this.bt_per.Click += new System.EventHandler(this.bt_per_Click);
            // 
            // tb_calc
            // 
            this.tb_calc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_calc.Location = new System.Drawing.Point(0, 0);
            this.tb_calc.Multiline = true;
            this.tb_calc.Name = "tb_calc";
            this.tb_calc.Size = new System.Drawing.Size(380, 40);
            this.tb_calc.TabIndex = 0;
            this.tb_calc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_calc_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_calc;
        private System.Windows.Forms.Button bt_res;
        private System.Windows.Forms.Button bt_dot;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_plusminus;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_min;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_mul;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_sqrt;
        private System.Windows.Forms.Button bt_x2;
        private System.Windows.Forms.Button bt_1divx;
        private System.Windows.Forms.Button bt_bs;
        private System.Windows.Forms.Button bt_c;
        private System.Windows.Forms.Button bt_ce;
        private System.Windows.Forms.Button bt_per;
    }
}

