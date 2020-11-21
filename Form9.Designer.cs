
namespace firstApplication
{
    partial class Form9
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ttamt = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.milkType = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(24, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 37);
            this.button3.TabIndex = 59;
            this.button3.Text = "HOME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(580, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 58;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(399, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 57;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ttamt
            // 
            this.ttamt.Location = new System.Drawing.Point(706, 337);
            this.ttamt.Name = "ttamt";
            this.ttamt.Size = new System.Drawing.Size(100, 22);
            this.ttamt.TabIndex = 56;
            this.ttamt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(393, 339);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(104, 22);
            this.rate.TabIndex = 55;
            this.rate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(706, 291);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(100, 22);
            this.qty.TabIndex = 53;
            this.qty.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(393, 233);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(288, 22);
            this.custName.TabIndex = 52;
            this.custName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(393, 164);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 49;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(565, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Total Amount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(565, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Quantity";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Rate";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Milk Type";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Customer Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 46);
            this.label1.TabIndex = 40;
            this.label1.Text = "SELL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // milkType
            // 
            this.milkType.FormattingEnabled = true;
            this.milkType.Items.AddRange(new object[] {
            "COW",
            "BUFFALO"});
            this.milkType.Location = new System.Drawing.Point(393, 299);
            this.milkType.Name = "milkType";
            this.milkType.Size = new System.Drawing.Size(121, 24);
            this.milkType.TabIndex = 60;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(263, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 43);
            this.button4.TabIndex = 61;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1323, 573);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.milkType);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ttamt);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ttamt;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox milkType;
        private System.Windows.Forms.Button button4;
    }
}