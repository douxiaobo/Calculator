namespace Calculator
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.机型转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtDivision = new System.Windows.Forms.Button();
            this.BtMult = new System.Windows.Forms.Button();
            this.BtSubtract = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.BtDebgyu = new System.Windows.Forms.Button();
            this.BtComma = new System.Windows.Forms.Button();
            this.BtNumber0 = new System.Windows.Forms.Button();
            this.BtNumber9 = new System.Windows.Forms.Button();
            this.BtNumber8 = new System.Windows.Forms.Button();
            this.BtNumber7 = new System.Windows.Forms.Button();
            this.BtNumber6 = new System.Windows.Forms.Button();
            this.BtNumber5 = new System.Windows.Forms.Button();
            this.BtNumber4 = new System.Windows.Forms.Button();
            this.BtNumber3 = new System.Windows.Forms.Button();
            this.BtNumber2 = new System.Windows.Forms.Button();
            this.BtNumber1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.机型转换ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 机型转换ToolStripMenuItem
            // 
            this.机型转换ToolStripMenuItem.Name = "机型转换ToolStripMenuItem";
            this.机型转换ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.机型转换ToolStripMenuItem.Text = "机型转换";
            this.机型转换ToolStripMenuItem.Click += new System.EventHandler(this.机型转换ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 26);
            this.textBox1.TabIndex = 1;
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(232, 94);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(167, 46);
            this.BtClear.TabIndex = 48;
            this.BtClear.Text = "C";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtDivision
            // 
            this.BtDivision.Location = new System.Drawing.Point(333, 373);
            this.BtDivision.Name = "BtDivision";
            this.BtDivision.Size = new System.Drawing.Size(66, 46);
            this.BtDivision.TabIndex = 47;
            this.BtDivision.Text = "/";
            this.BtDivision.UseVisualStyleBackColor = true;
            this.BtDivision.Click += new System.EventHandler(this.BtDivision_Click);
            // 
            // BtMult
            // 
            this.BtMult.Location = new System.Drawing.Point(333, 310);
            this.BtMult.Name = "BtMult";
            this.BtMult.Size = new System.Drawing.Size(66, 49);
            this.BtMult.TabIndex = 46;
            this.BtMult.Text = "*";
            this.BtMult.UseVisualStyleBackColor = true;
            this.BtMult.Click += new System.EventHandler(this.BtMult_Click);
            // 
            // BtSubtract
            // 
            this.BtSubtract.Location = new System.Drawing.Point(333, 240);
            this.BtSubtract.Name = "BtSubtract";
            this.BtSubtract.Size = new System.Drawing.Size(66, 45);
            this.BtSubtract.TabIndex = 45;
            this.BtSubtract.Text = "-";
            this.BtSubtract.UseVisualStyleBackColor = true;
            this.BtSubtract.Click += new System.EventHandler(this.BtSubtract_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(333, 166);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(66, 46);
            this.BtAdd.TabIndex = 44;
            this.BtAdd.Text = "+";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BtDebgyu
            // 
            this.BtDebgyu.Location = new System.Drawing.Point(232, 373);
            this.BtDebgyu.Name = "BtDebgyu";
            this.BtDebgyu.Size = new System.Drawing.Size(66, 46);
            this.BtDebgyu.TabIndex = 43;
            this.BtDebgyu.Text = "=";
            this.BtDebgyu.UseVisualStyleBackColor = true;
            this.BtDebgyu.Click += new System.EventHandler(this.BtDebgyu_Click);
            // 
            // BtComma
            // 
            this.BtComma.Location = new System.Drawing.Point(125, 373);
            this.BtComma.Name = "BtComma";
            this.BtComma.Size = new System.Drawing.Size(66, 46);
            this.BtComma.TabIndex = 42;
            this.BtComma.Text = ".";
            this.BtComma.UseVisualStyleBackColor = true;
            this.BtComma.Click += new System.EventHandler(this.BtComma_Click);
            // 
            // BtNumber0
            // 
            this.BtNumber0.Location = new System.Drawing.Point(22, 373);
            this.BtNumber0.Name = "BtNumber0";
            this.BtNumber0.Size = new System.Drawing.Size(66, 46);
            this.BtNumber0.TabIndex = 41;
            this.BtNumber0.Text = "0";
            this.BtNumber0.UseVisualStyleBackColor = true;
            this.BtNumber0.Click += new System.EventHandler(this.BtNumber0_Click);
            // 
            // BtNumber9
            // 
            this.BtNumber9.Location = new System.Drawing.Point(232, 307);
            this.BtNumber9.Name = "BtNumber9";
            this.BtNumber9.Size = new System.Drawing.Size(66, 49);
            this.BtNumber9.TabIndex = 40;
            this.BtNumber9.Text = "9";
            this.BtNumber9.UseVisualStyleBackColor = true;
            this.BtNumber9.Click += new System.EventHandler(this.BtNumber9_Click);
            // 
            // BtNumber8
            // 
            this.BtNumber8.Location = new System.Drawing.Point(125, 310);
            this.BtNumber8.Name = "BtNumber8";
            this.BtNumber8.Size = new System.Drawing.Size(66, 46);
            this.BtNumber8.TabIndex = 39;
            this.BtNumber8.Text = "8";
            this.BtNumber8.UseVisualStyleBackColor = true;
            this.BtNumber8.Click += new System.EventHandler(this.BtNumber8_Click);
            // 
            // BtNumber7
            // 
            this.BtNumber7.Location = new System.Drawing.Point(22, 307);
            this.BtNumber7.Name = "BtNumber7";
            this.BtNumber7.Size = new System.Drawing.Size(66, 46);
            this.BtNumber7.TabIndex = 38;
            this.BtNumber7.Text = "7";
            this.BtNumber7.UseVisualStyleBackColor = true;
            this.BtNumber7.Click += new System.EventHandler(this.BtNumber7_Click);
            // 
            // BtNumber6
            // 
            this.BtNumber6.Location = new System.Drawing.Point(232, 240);
            this.BtNumber6.Name = "BtNumber6";
            this.BtNumber6.Size = new System.Drawing.Size(66, 45);
            this.BtNumber6.TabIndex = 37;
            this.BtNumber6.Text = "6";
            this.BtNumber6.UseVisualStyleBackColor = true;
            this.BtNumber6.Click += new System.EventHandler(this.BtNumber6_Click);
            // 
            // BtNumber5
            // 
            this.BtNumber5.Location = new System.Drawing.Point(125, 239);
            this.BtNumber5.Name = "BtNumber5";
            this.BtNumber5.Size = new System.Drawing.Size(66, 46);
            this.BtNumber5.TabIndex = 36;
            this.BtNumber5.Text = "5";
            this.BtNumber5.UseVisualStyleBackColor = true;
            this.BtNumber5.Click += new System.EventHandler(this.BtNumber5_Click);
            // 
            // BtNumber4
            // 
            this.BtNumber4.Location = new System.Drawing.Point(22, 239);
            this.BtNumber4.Name = "BtNumber4";
            this.BtNumber4.Size = new System.Drawing.Size(66, 46);
            this.BtNumber4.TabIndex = 35;
            this.BtNumber4.Text = "4";
            this.BtNumber4.UseVisualStyleBackColor = true;
            this.BtNumber4.Click += new System.EventHandler(this.BtNumber4_Click);
            // 
            // BtNumber3
            // 
            this.BtNumber3.Location = new System.Drawing.Point(232, 166);
            this.BtNumber3.Name = "BtNumber3";
            this.BtNumber3.Size = new System.Drawing.Size(66, 46);
            this.BtNumber3.TabIndex = 34;
            this.BtNumber3.Text = "3";
            this.BtNumber3.UseVisualStyleBackColor = true;
            this.BtNumber3.Click += new System.EventHandler(this.BtNumber3_Click);
            // 
            // BtNumber2
            // 
            this.BtNumber2.Location = new System.Drawing.Point(125, 166);
            this.BtNumber2.Name = "BtNumber2";
            this.BtNumber2.Size = new System.Drawing.Size(66, 46);
            this.BtNumber2.TabIndex = 33;
            this.BtNumber2.Text = "2";
            this.BtNumber2.UseVisualStyleBackColor = true;
            this.BtNumber2.Click += new System.EventHandler(this.BtNumber2_Click);
            // 
            // BtNumber1
            // 
            this.BtNumber1.Location = new System.Drawing.Point(22, 166);
            this.BtNumber1.Name = "BtNumber1";
            this.BtNumber1.Size = new System.Drawing.Size(66, 46);
            this.BtNumber1.TabIndex = 32;
            this.BtNumber1.Text = "1";
            this.BtNumber1.UseVisualStyleBackColor = true;
            this.BtNumber1.Click += new System.EventHandler(this.BtNumber1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.BtDivision);
            this.Controls.Add(this.BtMult);
            this.Controls.Add(this.BtSubtract);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.BtDebgyu);
            this.Controls.Add(this.BtComma);
            this.Controls.Add(this.BtNumber0);
            this.Controls.Add(this.BtNumber9);
            this.Controls.Add(this.BtNumber8);
            this.Controls.Add(this.BtNumber7);
            this.Controls.Add(this.BtNumber6);
            this.Controls.Add(this.BtNumber5);
            this.Controls.Add(this.BtNumber4);
            this.Controls.Add(this.BtNumber3);
            this.Controls.Add(this.BtNumber2);
            this.Controls.Add(this.BtNumber1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "普通计算器 by Dou Xiaobo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 机型转换ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtDivision;
        private System.Windows.Forms.Button BtMult;
        private System.Windows.Forms.Button BtSubtract;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button BtDebgyu;
        private System.Windows.Forms.Button BtComma;
        private System.Windows.Forms.Button BtNumber0;
        private System.Windows.Forms.Button BtNumber9;
        private System.Windows.Forms.Button BtNumber8;
        private System.Windows.Forms.Button BtNumber7;
        private System.Windows.Forms.Button BtNumber6;
        private System.Windows.Forms.Button BtNumber5;
        private System.Windows.Forms.Button BtNumber4;
        private System.Windows.Forms.Button BtNumber3;
        private System.Windows.Forms.Button BtNumber2;
        private System.Windows.Forms.Button BtNumber1;
    }
}