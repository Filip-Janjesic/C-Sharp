namespace LoveCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoyName = new System.Windows.Forms.TextBox();
            this.txtGirlName = new System.Windows.Forms.TextBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Girl Names";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoyName
            // 
            this.txtBoyName.Location = new System.Drawing.Point(189, 74);
            this.txtBoyName.Name = "txtBoyName";
            this.txtBoyName.Size = new System.Drawing.Size(165, 26);
            this.txtBoyName.TabIndex = 2;
            // 
            // txtGirlName
            // 
            this.txtGirlName.Location = new System.Drawing.Point(189, 128);
            this.txtGirlName.Name = "txtGirlName";
            this.txtGirlName.Size = new System.Drawing.Size(165, 26);
            this.txtGirlName.TabIndex = 3;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(207, 207);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(110, 33);
            this.btnCalculator.TabIndex = 4;
            this.btnCalculator.Text = "Calculate";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 315);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.txtGirlName);
            this.Controls.Add(this.txtBoyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Love Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoyName;
        private System.Windows.Forms.TextBox txtGirlName;
        private System.Windows.Forms.Button btnCalculator;
    }
}

