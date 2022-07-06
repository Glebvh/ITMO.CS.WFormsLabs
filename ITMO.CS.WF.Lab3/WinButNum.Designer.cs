namespace ITMO.CS.WF.Lab3
{
    partial class WinButNum
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
            this.clickButton1 = new ITMO.CS.WF.Lab3.ClickButton();
            this.SuspendLayout();
            // 
            // clickButton1
            // 
            this.clickButton1.Location = new System.Drawing.Point(50, 53);
            this.clickButton1.Name = "clickButton1";
            this.clickButton1.Size = new System.Drawing.Size(317, 75);
            this.clickButton1.TabIndex = 0;
            this.clickButton1.Text = "clickButton1";
            this.clickButton1.UseVisualStyleBackColor = true;
            // 
            // WinButNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clickButton1);
            this.Name = "WinButNum";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ClickButton clickButton1;
    }
}