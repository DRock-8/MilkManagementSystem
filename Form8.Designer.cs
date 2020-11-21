
namespace firstApplication
{
    partial class Form8
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
            this.button3.Location = new System.Drawing.Point(42, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 37);
            this.button3.TabIndex = 39;
            this.button3.Text = "HOME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(631, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 38;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(448, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 37;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ttamt
            // 
            this.ttamt.Location = new System.Drawing.Point(826, 336);
            this.ttamt.Name = "ttamt";
            this.ttamt.Size = new System.Drawing.Size(100, 22);
            this.ttamt.TabIndex = 36;
            this.ttamt.TextChanged += new System.EventHandler(this.ttamt_TextChanged);
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(411, 401);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 22);
            this.rate.TabIndex = 35;
            this.rate.TextChanged += new System.EventHandler(this.rate_TextChanged);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(411, 347);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(100, 22);
            this.qty.TabIndex = 33;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(411, 241);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(284, 22);
            this.custName.TabIndex = 32;
            this.custName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(411, 171);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 29;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Total Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Milk Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "PURCHASE";
            // 
            // milkType
            // 
            this.milkType.FormattingEnabled = true;
            this.milkType.Items.AddRange(new object[] {
            "COW",
            "BUFFALO"});
            this.milkType.Location = new System.Drawing.Point(411, 294);
            this.milkType.Name = "milkType";
            this.milkType.Size = new System.Drawing.Size(121, 24);
            this.milkType.TabIndex = 40;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(283, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 43);
            this.button4.TabIndex = 41;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1347, 571);
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
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
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