
namespace firstApplication
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.adminBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Yellow;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.Location = new System.Drawing.Point(228, 380);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(213, 69);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // transactionBtn
            // 
            this.transactionBtn.BackColor = System.Drawing.Color.Yellow;
            this.transactionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionBtn.Location = new System.Drawing.Point(510, 380);
            this.transactionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(234, 69);
            this.transactionBtn.TabIndex = 2;
            this.transactionBtn.Text = "Transaction";
            this.transactionBtn.UseVisualStyleBackColor = false;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Yellow;
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(832, 380);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(206, 69);
            this.reportBtn.TabIndex = 3;
            this.reportBtn.Text = "Report";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOME";
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1318, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.adminBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Label label1;
    }
}