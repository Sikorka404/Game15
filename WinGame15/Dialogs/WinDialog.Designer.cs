namespace WinGame15.Dialogs
{
    partial class WinDialog
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
            this.LabelWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelWin
            // 
            this.LabelWin.BackColor = System.Drawing.Color.Transparent;
            this.LabelWin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWin.Location = new System.Drawing.Point(12, 9);
            this.LabelWin.Name = "LabelWin";
            this.LabelWin.Size = new System.Drawing.Size(300, 82);
            this.LabelWin.TabIndex = 0;
            this.LabelWin.Text = "label1";
            this.LabelWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWin.Click += new System.EventHandler(this.LabelWin_Click);
            // 
            // WinDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinGame15.Properties.Resources.back1;
            this.ClientSize = new System.Drawing.Size(324, 100);
            this.Controls.Add(this.LabelWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WinDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WIN";
            this.Load += new System.EventHandler(this.WinDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelWin;
    }
}