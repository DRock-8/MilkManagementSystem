
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.adminBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminBtn.BackgroundImage")));
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.Black;
            this.adminBtn.Location = new System.Drawing.Point(189, 155);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(305, 69);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "CUSTOMER";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // transactionBtn
            // 
            this.transactionBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.transactionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transactionBtn.BackgroundImage")));
            this.transactionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionBtn.ForeColor = System.Drawing.Color.Black;
            this.transactionBtn.Location = new System.Drawing.Point(189, 256);
            this.transactionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(305, 69);
            this.transactionBtn.TabIndex = 2;
            this.transactionBtn.Text = "TRANSACTION";
            this.transactionBtn.UseVisualStyleBackColor = false;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reportBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportBtn.BackgroundImage")));
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.Black;
            this.reportBtn.Location = new System.Drawing.Point(189, 441);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(305, 69);
            this.reportBtn.TabIndex = 3;
            this.reportBtn.Text = "REPORT";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(646, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOME";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(189, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 69);
            this.button2.TabIndex = 6;
            this.button2.Text = "STOCK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1466, 642);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
    }
}