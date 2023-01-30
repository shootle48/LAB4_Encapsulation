namespace LAB4_Encapsulation
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textbYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textGPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.textMax = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(65, 33);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(150, 31);
            this.textName.TabIndex = 0;
            // 
            // textbYear
            // 
            this.textbYear.Location = new System.Drawing.Point(64, 75);
            this.textbYear.Name = "textbYear";
            this.textbYear.Size = new System.Drawing.Size(150, 31);
            this.textbYear.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "เพิ่มข้อมูล";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textList
            // 
            this.textList.Location = new System.Drawing.Point(26, 164);
            this.textList.Multiline = true;
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(240, 274);
            this.textList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "วันเกิด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "รายชื่อ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "อายุรวมทั้งหมด :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(450, 406);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(22, 25);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "0";
            // 
            // textGPA
            // 
            this.textGPA.Location = new System.Drawing.Point(271, 33);
            this.textGPA.Name = "textGPA";
            this.textGPA.Size = new System.Drawing.Size(150, 31);
            this.textGPA.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "GPA :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "GPA :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "เกรดเฉลี่ยทั้งหมด :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "ชื่อ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "ชื่อ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "GPA";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(538, 193);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(46, 25);
            this.labelMax.TabIndex = 17;
            this.labelMax.Text = "0.00";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(539, 284);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(46, 25);
            this.labelMin.TabIndex = 18;
            this.labelMin.Text = "0.00";
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(464, 354);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(46, 25);
            this.labelAvg.TabIndex = 19;
            this.labelAvg.Text = "0.00";
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(328, 190);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(150, 31);
            this.textMax.TabIndex = 20;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(328, 280);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(150, 31);
            this.textMin.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "เกรดเฉลี่ยสูงสุด";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(399, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "เกรดเฉลี่ยต่ำสุด";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(475, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "ปี";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textGPA);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbYear);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textName;
        private TextBox textbYear;
        private Button button1;
        private TextBox textList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelTotal;
        private TextBox textGPA;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelMax;
        private Label labelMin;
        private Label labelAvg;
        private TextBox textMax;
        private TextBox textMin;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}