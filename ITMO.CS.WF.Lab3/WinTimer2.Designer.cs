namespace ITMO.CS.WF.Lab3
{
    partial class WinTimer2
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
            this.userControlTimer21 = new ITMO.CS.WF.Lab3.UserControlTimer2();
            this.SuspendLayout();
            // 
            // userControlTimer21
            // 
            this.userControlTimer21.Location = new System.Drawing.Point(12, 12);
            this.userControlTimer21.Name = "userControlTimer21";
            this.userControlTimer21.Size = new System.Drawing.Size(71, 25);
            this.userControlTimer21.TabIndex = 0;
            // 
            // WinTimer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlTimer21);
            this.Name = "WinTimer2";
            this.Text = "WinTimer2";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer2 userControlTimer21;
    }
}