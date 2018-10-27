namespace Mileage_Calculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.startingMileageBox = new System.Windows.Forms.TextBox();
            this.endingMileageBox = new System.Windows.Forms.TextBox();
            this.mileageRateBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Mileage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Mileage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mileage Rate:";
            // 
            // startingMileageBox
            // 
            this.startingMileageBox.Location = new System.Drawing.Point(104, 4);
            this.startingMileageBox.Name = "startingMileageBox";
            this.startingMileageBox.Size = new System.Drawing.Size(100, 20);
            this.startingMileageBox.TabIndex = 3;
            // 
            // endingMileageBox
            // 
            this.endingMileageBox.Location = new System.Drawing.Point(104, 30);
            this.endingMileageBox.Name = "endingMileageBox";
            this.endingMileageBox.Size = new System.Drawing.Size(100, 20);
            this.endingMileageBox.TabIndex = 4;
            // 
            // mileageRateBox
            // 
            this.mileageRateBox.Location = new System.Drawing.Point(104, 56);
            this.mileageRateBox.Name = "mileageRateBox";
            this.mileageRateBox.Size = new System.Drawing.Size(100, 20);
            this.mileageRateBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 130);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mileageRateBox);
            this.Controls.Add(this.endingMileageBox);
            this.Controls.Add(this.startingMileageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mileage Calculator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startingMileageBox;
        private System.Windows.Forms.TextBox endingMileageBox;
        private System.Windows.Forms.TextBox mileageRateBox;
        private System.Windows.Forms.Button button1;
    }
}

