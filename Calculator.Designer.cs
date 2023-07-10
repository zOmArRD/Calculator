namespace Calculator
{
    partial class Calculator
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(6, 12);
            this.resultBox.MaxLength = 14;
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(318, 53);
            this.resultBox.TabIndex = 0;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.ForeColor = System.Drawing.Color.White;
            this.btnPlusMinus.Location = new System.Drawing.Point(6, 311);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(75, 50);
            this.btnPlusMinus.TabIndex = 1;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(87, 311);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 50);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.AddNumber);
            // 
            // btnPeriod
            // 
            this.btnPeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPeriod.FlatAppearance.BorderSize = 0;
            this.btnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.ForeColor = System.Drawing.Color.White;
            this.btnPeriod.Location = new System.Drawing.Point(168, 311);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(75, 50);
            this.btnPeriod.TabIndex = 3;
            this.btnPeriod.Text = "∙";
            this.btnPeriod.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.Black;
            this.btnEquals.Location = new System.Drawing.Point(249, 311);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 50);
            this.btnEquals.TabIndex = 4;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(6, 255);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 50);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(87, 255);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(168, 255);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 50);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.AddNumber);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(249, 255);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 50);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Tag = "+";
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(6, 199);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 50);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(87, 199);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 50);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(168, 199);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 50);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.AddNumber);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(249, 199);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 50);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Tag = "−";
            this.btnMinus.Text = "−";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(6, 143);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 50);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(87, 143);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 50);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.AddNumber);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(168, 143);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 50);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.AddNumber);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(249, 143);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 50);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Tag = "×";
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(6, 87);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 50);
            this.btnCE.TabIndex = 17;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.Clear);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(87, 87);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 50);
            this.btnC.TabIndex = 18;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.ClearAll);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(168, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "⏎";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.RemoveLastNumber);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(249, 87);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 50);
            this.btnDivision.TabIndex = 20;
            this.btnDivision.Tag = "÷";
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.OperatorClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(330, 366);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.resultBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDivision;

        private System.Windows.Forms.Button btnPlusMinus;

        private System.Windows.Forms.TextBox resultBox;

        #endregion
    }
}