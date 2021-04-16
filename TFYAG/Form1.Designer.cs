namespace TFYAG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorTB = new System.Windows.Forms.TextBox();
            this.clearBUT = new System.Windows.Forms.Button();
            this.mainTB = new System.Windows.Forms.RichTextBox();
            this.sendBUT = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorTB);
            this.panel1.Controls.Add(this.clearBUT);
            this.panel1.Controls.Add(this.mainTB);
            this.panel1.Controls.Add(this.sendBUT);
            this.panel1.Controls.Add(this.outputTB);
            this.panel1.Location = new System.Drawing.Point(54, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 355);
            this.panel1.TabIndex = 0;
            // 
            // errorTB
            // 
            this.errorTB.BackColor = System.Drawing.SystemColors.ControlText;
            this.errorTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorTB.ForeColor = System.Drawing.Color.Red;
            this.errorTB.Location = new System.Drawing.Point(296, 63);
            this.errorTB.Multiline = true;
            this.errorTB.Name = "errorTB";
            this.errorTB.ReadOnly = true;
            this.errorTB.Size = new System.Drawing.Size(447, 72);
            this.errorTB.TabIndex = 2;
            this.errorTB.Text = "EmptyBox";
            this.errorTB.Click += new System.EventHandler(this.errorTB_Click);
            // 
            // clearBUT
            // 
            this.clearBUT.Location = new System.Drawing.Point(139, 81);
            this.clearBUT.Name = "clearBUT";
            this.clearBUT.Size = new System.Drawing.Size(129, 35);
            this.clearBUT.TabIndex = 1;
            this.clearBUT.Text = "button2";
            this.clearBUT.UseVisualStyleBackColor = true;
            // 
            // mainTB
            // 
            this.mainTB.Location = new System.Drawing.Point(0, 0);
            this.mainTB.Name = "mainTB";
            this.mainTB.Size = new System.Drawing.Size(743, 56);
            this.mainTB.TabIndex = 1;
            this.mainTB.Text = "";
            this.mainTB.TextChanged += new System.EventHandler(this.MainTB_TextChanged);
            // 
            // sendBUT
            // 
            this.sendBUT.Location = new System.Drawing.Point(0, 81);
            this.sendBUT.Name = "sendBUT";
            this.sendBUT.Size = new System.Drawing.Size(133, 35);
            this.sendBUT.TabIndex = 1;
            this.sendBUT.Text = "button1";
            this.sendBUT.UseVisualStyleBackColor = true;
            // 
            // outputTB
            // 
            this.outputTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputTB.ForeColor = System.Drawing.SystemColors.Info;
            this.outputTB.Location = new System.Drawing.Point(1, 141);
            this.outputTB.Name = "outputTB";
            this.outputTB.ReadOnly = true;
            this.outputTB.Size = new System.Drawing.Size(743, 214);
            this.outputTB.TabIndex = 0;
            this.outputTB.Text = "EmptyBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 424);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sendBUT;
        private System.Windows.Forms.Button clearBUT;
        private System.Windows.Forms.RichTextBox outputTB;
        private System.Windows.Forms.RichTextBox mainTB;
        private System.Windows.Forms.TextBox errorTB;
    }
}

