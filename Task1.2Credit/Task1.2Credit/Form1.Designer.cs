namespace Task1._2Credit
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.rdbtnHello = new System.Windows.Forms.RadioButton();
            this.rdbtnGoodbye = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnExitBrowser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(308, 106);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(284, 55);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "placeholder";
            // 
            // rdbtnHello
            // 
            this.rdbtnHello.AutoSize = true;
            this.rdbtnHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnHello.Location = new System.Drawing.Point(220, 262);
            this.rdbtnHello.Name = "rdbtnHello";
            this.rdbtnHello.Size = new System.Drawing.Size(137, 33);
            this.rdbtnHello.TabIndex = 1;
            this.rdbtnHello.Text = "Say Hello";
            this.rdbtnHello.UseVisualStyleBackColor = true;
            this.rdbtnHello.Click += new System.EventHandler(this.RadioChosen);
            // 
            // rdbtnGoodbye
            // 
            this.rdbtnGoodbye.AutoSize = true;
            this.rdbtnGoodbye.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnGoodbye.Location = new System.Drawing.Point(402, 262);
            this.rdbtnGoodbye.Name = "rdbtnGoodbye";
            this.rdbtnGoodbye.Size = new System.Drawing.Size(179, 33);
            this.rdbtnGoodbye.TabIndex = 2;
            this.rdbtnGoodbye.Text = "Say Goodbye";
            this.rdbtnGoodbye.UseVisualStyleBackColor = true;
            this.rdbtnGoodbye.Click += new System.EventHandler(this.RadioChosen);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(248, 322);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 38);
            this.txtName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 450);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Links";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExitBrowser);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnYoutube);
            this.panel2.Controls.Add(this.btnGoogle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 420);
            this.panel2.TabIndex = 2;
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGoogle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogle.Location = new System.Drawing.Point(0, 0);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(141, 60);
            this.btnGoogle.TabIndex = 0;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = false;
            this.btnGoogle.Click += new System.EventHandler(this.BtnGoogle_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYoutube.Location = new System.Drawing.Point(0, 60);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(141, 60);
            this.btnYoutube.TabIndex = 1;
            this.btnYoutube.Text = "Youtube";
            this.btnYoutube.UseVisualStyleBackColor = true;
            this.btnYoutube.Click += new System.EventHandler(this.BtnYoutube_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBrowser.Location = new System.Drawing.Point(141, 0);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(659, 450);
            this.wbBrowser.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(0, 120);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(141, 60);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(0, 180);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(141, 60);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnExitBrowser
            // 
            this.btnExitBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExitBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitBrowser.Location = new System.Drawing.Point(0, 240);
            this.btnExitBrowser.Name = "btnExitBrowser";
            this.btnExitBrowser.Size = new System.Drawing.Size(141, 78);
            this.btnExitBrowser.TabIndex = 4;
            this.btnExitBrowser.Text = "Exit Browser";
            this.btnExitBrowser.UseVisualStyleBackColor = true;
            this.btnExitBrowser.Click += new System.EventHandler(this.BtnExitBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rdbtnGoodbye);
            this.Controls.Add(this.rdbtnHello);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.RadioButton rdbtnHello;
        private System.Windows.Forms.RadioButton rdbtnGoodbye;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExitBrowser;
    }
}

