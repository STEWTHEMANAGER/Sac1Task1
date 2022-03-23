
namespace Sac1Task1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnEndQuote = new System.Windows.Forms.Button();
            this.lblWorth = new System.Windows.Forms.Label();
            this.lblTotalWorth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(132, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 30);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEndQuote
            // 
            this.btnEndQuote.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEndQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndQuote.ForeColor = System.Drawing.Color.White;
            this.btnEndQuote.Location = new System.Drawing.Point(410, 238);
            this.btnEndQuote.Name = "btnEndQuote";
            this.btnEndQuote.Size = new System.Drawing.Size(112, 30);
            this.btnEndQuote.TabIndex = 3;
            this.btnEndQuote.Text = "End the quote";
            this.btnEndQuote.UseVisualStyleBackColor = false;
            this.btnEndQuote.Click += new System.EventHandler(this.btnEndQuote_Click);
            // 
            // lblWorth
            // 
            this.lblWorth.AutoSize = true;
            this.lblWorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorth.Location = new System.Drawing.Point(406, 66);
            this.lblWorth.Name = "lblWorth";
            this.lblWorth.Size = new System.Drawing.Size(0, 20);
            this.lblWorth.TabIndex = 4;
            // 
            // lblTotalWorth
            // 
            this.lblTotalWorth.AutoSize = true;
            this.lblTotalWorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWorth.Location = new System.Drawing.Point(406, 91);
            this.lblTotalWorth.Name = "lblTotalWorth";
            this.lblTotalWorth.Size = new System.Drawing.Size(0, 20);
            this.lblTotalWorth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "How old is the textbook?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "How much did you pay for it?";
            // 
            // nudAge
            // 
            this.nudAge.DecimalPlaces = 2;
            this.nudAge.Location = new System.Drawing.Point(132, 86);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(190, 22);
            this.nudAge.TabIndex = 8;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(132, 190);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(190, 22);
            this.nudPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 414);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalWorth);
            this.Controls.Add(this.lblWorth);
            this.Controls.Add(this.btnEndQuote);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnEndQuote;
        private System.Windows.Forms.Label lblWorth;
        private System.Windows.Forms.Label lblTotalWorth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.NumericUpDown nudPrice;
    }
}

