namespace Numthod
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCalculatePersamaan = new System.Windows.Forms.Label();
            this.lblXl = new System.Windows.Forms.Label();
            this.lblXu = new System.Windows.Forms.Label();
            this.tbXl = new System.Windows.Forms.TextBox();
            this.tbXu = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lbHasil = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "sin x - e   - x = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            // 
            // lblCalculatePersamaan
            // 
            this.lblCalculatePersamaan.AutoSize = true;
            this.lblCalculatePersamaan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatePersamaan.Location = new System.Drawing.Point(235, 27);
            this.lblCalculatePersamaan.Name = "lblCalculatePersamaan";
            this.lblCalculatePersamaan.Size = new System.Drawing.Size(185, 15);
            this.lblCalculatePersamaan.TabIndex = 2;
            this.lblCalculatePersamaan.Text = "CALCULATOR PERSAMAAN";
            // 
            // lblXl
            // 
            this.lblXl.AutoSize = true;
            this.lblXl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXl.Location = new System.Drawing.Point(232, 95);
            this.lblXl.Name = "lblXl";
            this.lblXl.Size = new System.Drawing.Size(30, 15);
            this.lblXl.TabIndex = 3;
            this.lblXl.Text = "Xl =";
            // 
            // lblXu
            // 
            this.lblXu.AutoSize = true;
            this.lblXu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXu.Location = new System.Drawing.Point(228, 128);
            this.lblXu.Name = "lblXu";
            this.lblXu.Size = new System.Drawing.Size(34, 15);
            this.lblXu.TabIndex = 5;
            this.lblXu.Text = "Xu =";
            // 
            // tbXl
            // 
            this.tbXl.Location = new System.Drawing.Point(268, 91);
            this.tbXl.Name = "tbXl";
            this.tbXl.Size = new System.Drawing.Size(54, 23);
            this.tbXl.TabIndex = 6;
            // 
            // tbXu
            // 
            this.tbXu.Location = new System.Drawing.Point(268, 124);
            this.tbXu.Name = "tbXu";
            this.tbXu.Size = new System.Drawing.Size(54, 23);
            this.tbXu.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(346, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 56);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(304, 171);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(60, 20);
            this.lblHasil.TabIndex = 9;
            this.lblHasil.Text = "HASIL";
            // 
            // lbHasil
            // 
            this.lbHasil.FormattingEnabled = true;
            this.lbHasil.ItemHeight = 15;
            this.lbHasil.Location = new System.Drawing.Point(36, 200);
            this.lbHasil.Name = "lbHasil";
            this.lbHasil.Size = new System.Drawing.Size(603, 169);
            this.lbHasil.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 405);
            this.Controls.Add(this.lbHasil);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbXu);
            this.Controls.Add(this.tbXl);
            this.Controls.Add(this.lblXu);
            this.Controls.Add(this.lblXl);
            this.Controls.Add(this.lblCalculatePersamaan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCalculatePersamaan;
        private System.Windows.Forms.Label lblXl;
        private System.Windows.Forms.Label lblXu;
        private System.Windows.Forms.TextBox tbXl;
        private System.Windows.Forms.TextBox tbXu;
        private System.Windows.Forms.Button btnCalculate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.ListBox lbHasil;
    }
}

