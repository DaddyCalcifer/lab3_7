namespace lab3_7
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.do_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.del0 = new System.Windows.Forms.CheckBox();
            this.del1 = new System.Windows.Forms.CheckBox();
            this.del2 = new System.Windows.Forms.CheckBox();
            this.del3 = new System.Windows.Forms.CheckBox();
            this.del4 = new System.Windows.Forms.CheckBox();
            this.del9 = new System.Windows.Forms.CheckBox();
            this.del8 = new System.Windows.Forms.CheckBox();
            this.del7 = new System.Windows.Forms.CheckBox();
            this.del6 = new System.Windows.Forms.CheckBox();
            this.del5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(184, 38);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1234567890,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // do_button
            // 
            this.do_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.do_button.Location = new System.Drawing.Point(12, 141);
            this.do_button.Name = "do_button";
            this.do_button.Size = new System.Drawing.Size(184, 49);
            this.do_button.TabIndex = 1;
            this.do_button.Text = "Стереть";
            this.do_button.UseVisualStyleBackColor = true;
            this.do_button.Click += new System.EventHandler(this.do_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Удалить цифры:";
            // 
            // del0
            // 
            this.del0.AutoSize = true;
            this.del0.Checked = true;
            this.del0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.del0.Location = new System.Drawing.Point(11, 86);
            this.del0.Name = "del0";
            this.del0.Size = new System.Drawing.Size(32, 17);
            this.del0.TabIndex = 3;
            this.del0.Text = "0";
            this.del0.UseVisualStyleBackColor = true;
            // 
            // del1
            // 
            this.del1.AutoSize = true;
            this.del1.Location = new System.Drawing.Point(49, 86);
            this.del1.Name = "del1";
            this.del1.Size = new System.Drawing.Size(32, 17);
            this.del1.TabIndex = 4;
            this.del1.Text = "1";
            this.del1.UseVisualStyleBackColor = true;
            // 
            // del2
            // 
            this.del2.AutoSize = true;
            this.del2.Location = new System.Drawing.Point(87, 86);
            this.del2.Name = "del2";
            this.del2.Size = new System.Drawing.Size(32, 17);
            this.del2.TabIndex = 5;
            this.del2.Text = "2";
            this.del2.UseVisualStyleBackColor = true;
            // 
            // del3
            // 
            this.del3.AutoSize = true;
            this.del3.Location = new System.Drawing.Point(125, 86);
            this.del3.Name = "del3";
            this.del3.Size = new System.Drawing.Size(32, 17);
            this.del3.TabIndex = 6;
            this.del3.Text = "3";
            this.del3.UseVisualStyleBackColor = true;
            // 
            // del4
            // 
            this.del4.AutoSize = true;
            this.del4.Location = new System.Drawing.Point(163, 86);
            this.del4.Name = "del4";
            this.del4.Size = new System.Drawing.Size(32, 17);
            this.del4.TabIndex = 7;
            this.del4.Text = "4";
            this.del4.UseVisualStyleBackColor = true;
            // 
            // del9
            // 
            this.del9.AutoSize = true;
            this.del9.Location = new System.Drawing.Point(163, 109);
            this.del9.Name = "del9";
            this.del9.Size = new System.Drawing.Size(32, 17);
            this.del9.TabIndex = 12;
            this.del9.Text = "9";
            this.del9.UseVisualStyleBackColor = true;
            // 
            // del8
            // 
            this.del8.AutoSize = true;
            this.del8.Location = new System.Drawing.Point(125, 109);
            this.del8.Name = "del8";
            this.del8.Size = new System.Drawing.Size(32, 17);
            this.del8.TabIndex = 11;
            this.del8.Text = "8";
            this.del8.UseVisualStyleBackColor = true;
            // 
            // del7
            // 
            this.del7.AutoSize = true;
            this.del7.Location = new System.Drawing.Point(87, 109);
            this.del7.Name = "del7";
            this.del7.Size = new System.Drawing.Size(32, 17);
            this.del7.TabIndex = 10;
            this.del7.Text = "7";
            this.del7.UseVisualStyleBackColor = true;
            // 
            // del6
            // 
            this.del6.AutoSize = true;
            this.del6.Location = new System.Drawing.Point(49, 109);
            this.del6.Name = "del6";
            this.del6.Size = new System.Drawing.Size(32, 17);
            this.del6.TabIndex = 9;
            this.del6.Text = "6";
            this.del6.UseVisualStyleBackColor = true;
            // 
            // del5
            // 
            this.del5.AutoSize = true;
            this.del5.Checked = true;
            this.del5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.del5.Location = new System.Drawing.Point(11, 109);
            this.del5.Name = "del5";
            this.del5.Size = new System.Drawing.Size(32, 17);
            this.del5.TabIndex = 8;
            this.del5.Text = "5";
            this.del5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 203);
            this.Controls.Add(this.del9);
            this.Controls.Add(this.del8);
            this.Controls.Add(this.del7);
            this.Controls.Add(this.del6);
            this.Controls.Add(this.del5);
            this.Controls.Add(this.del4);
            this.Controls.Add(this.del3);
            this.Controls.Add(this.del2);
            this.Controls.Add(this.del1);
            this.Controls.Add(this.del0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.do_button);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Стереть";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button do_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox del0;
        private System.Windows.Forms.CheckBox del1;
        private System.Windows.Forms.CheckBox del2;
        private System.Windows.Forms.CheckBox del3;
        private System.Windows.Forms.CheckBox del4;
        private System.Windows.Forms.CheckBox del9;
        private System.Windows.Forms.CheckBox del8;
        private System.Windows.Forms.CheckBox del7;
        private System.Windows.Forms.CheckBox del6;
        private System.Windows.Forms.CheckBox del5;
    }
}

