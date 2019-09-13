namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblPending = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(176, 132);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(45, 45);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.operation_click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(125, 132);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(45, 45);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.button_click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(125, 183);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(45, 45);
            this.btnThree.TabIndex = 12;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.button_click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(176, 183);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(45, 45);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.operation_click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(176, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.operation_click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(125, 234);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(45, 45);
            this.btnDot.TabIndex = 17;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.button_click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(74, 132);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(45, 45);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.button_click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(23, 183);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(45, 45);
            this.btnOne.TabIndex = 10;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.button_click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(23, 132);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(45, 45);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.button_click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(74, 183);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(45, 45);
            this.btnTwo.TabIndex = 11;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.button_click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(23, 234);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(96, 45);
            this.btnZero.TabIndex = 15;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button_click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(227, 183);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(61, 96);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(125, 81);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(45, 45);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.button_click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(23, 81);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(45, 45);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.button_click);
            // 
            // btnCe
            // 
            this.btnCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCe.Location = new System.Drawing.Point(227, 81);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(61, 45);
            this.btnCe.TabIndex = 4;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.BtnCe_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(176, 81);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(45, 45);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.operation_click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(227, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 45);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(74, 81);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(45, 45);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.button_click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(23, 41);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(265, 34);
            this.txtResult.TabIndex = 20;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.BackColor = System.Drawing.SystemColors.Window;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPending.Location = new System.Drawing.Point(23, 11);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(0, 25);
            this.lblPending.TabIndex = 21;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(23, 285);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(265, 45);
            this.btnInfo.TabIndex = 22;
            this.btnInfo.Text = "Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(311, 345);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Button btnInfo;
    }
}

