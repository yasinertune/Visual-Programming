namespace WindowsFormsApplication2
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
            this.radio_tek = new System.Windows.Forms.RadioButton();
            this.radio_cift = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.radio_3 = new System.Windows.Forms.RadioButton();
            this.check_sirali = new System.Windows.Forms.CheckBox();
            this.check_farkli = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_tek
            // 
            this.radio_tek.AutoSize = true;
            this.radio_tek.Checked = true;
            this.radio_tek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_tek.Location = new System.Drawing.Point(15, 28);
            this.radio_tek.Name = "radio_tek";
            this.radio_tek.Size = new System.Drawing.Size(57, 24);
            this.radio_tek.TabIndex = 0;
            this.radio_tek.TabStop = true;
            this.radio_tek.Text = "TEK";
            this.radio_tek.UseVisualStyleBackColor = true;
            // 
            // radio_cift
            // 
            this.radio_cift.AutoSize = true;
            this.radio_cift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_cift.Location = new System.Drawing.Point(15, 52);
            this.radio_cift.Name = "radio_cift";
            this.radio_cift.Size = new System.Drawing.Size(62, 24);
            this.radio_cift.TabIndex = 1;
            this.radio_cift.TabStop = true;
            this.radio_cift.Text = "ÇİFT";
            this.radio_cift.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(353, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÜRET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 27);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_cift);
            this.groupBox1.Controls.Add(this.radio_tek);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(79, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_3);
            this.groupBox2.Controls.Add(this.radio_2);
            this.groupBox2.Controls.Add(this.radio_1);
            this.groupBox2.Location = new System.Drawing.Point(110, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radio_1
            // 
            this.radio_1.AutoSize = true;
            this.radio_1.Checked = true;
            this.radio_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_1.Location = new System.Drawing.Point(4, 20);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(113, 24);
            this.radio_1.TabIndex = 0;
            this.radio_1.TabStop = true;
            this.radio_1.Text = "1 Basamaklı";
            this.radio_1.UseVisualStyleBackColor = true;
            // 
            // radio_2
            // 
            this.radio_2.AutoSize = true;
            this.radio_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_2.Location = new System.Drawing.Point(4, 44);
            this.radio_2.Name = "radio_2";
            this.radio_2.Size = new System.Drawing.Size(113, 24);
            this.radio_2.TabIndex = 1;
            this.radio_2.TabStop = true;
            this.radio_2.Text = "2 Basamaklı";
            this.radio_2.UseVisualStyleBackColor = true;
            // 
            // radio_3
            // 
            this.radio_3.AutoSize = true;
            this.radio_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_3.Location = new System.Drawing.Point(4, 68);
            this.radio_3.Name = "radio_3";
            this.radio_3.Size = new System.Drawing.Size(113, 24);
            this.radio_3.TabIndex = 2;
            this.radio_3.TabStop = true;
            this.radio_3.Text = "3 Basamaklı";
            this.radio_3.UseVisualStyleBackColor = true;
            // 
            // check_sirali
            // 
            this.check_sirali.AutoSize = true;
            this.check_sirali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_sirali.Location = new System.Drawing.Point(270, 53);
            this.check_sirali.Name = "check_sirali";
            this.check_sirali.Size = new System.Drawing.Size(62, 24);
            this.check_sirali.TabIndex = 10;
            this.check_sirali.Text = "Sıralı";
            this.check_sirali.UseVisualStyleBackColor = true;
            // 
            // check_farkli
            // 
            this.check_farkli.AutoSize = true;
            this.check_farkli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_farkli.Location = new System.Drawing.Point(270, 85);
            this.check_farkli.Name = "check_farkli";
            this.check_farkli.Size = new System.Drawing.Size(66, 24);
            this.check_farkli.TabIndex = 11;
            this.check_farkli.Text = "Farklı";
            this.check_farkli.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 200);
            this.Controls.Add(this.check_farkli);
            this.Controls.Add(this.check_sirali);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_tek;
        private System.Windows.Forms.RadioButton radio_cift;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_3;
        private System.Windows.Forms.RadioButton radio_2;
        private System.Windows.Forms.RadioButton radio_1;
        private System.Windows.Forms.CheckBox check_sirali;
        private System.Windows.Forms.CheckBox check_farkli;

    }
}

