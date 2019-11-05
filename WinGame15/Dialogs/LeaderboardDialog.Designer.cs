namespace WinGame15.Dialogs
{
    partial class LeaderboardDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardDialog));
            this.DgLd = new System.Windows.Forms.DataGridView();
            this.DgNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgMoves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgLd)).BeginInit();
            this.SuspendLayout();
            // 
            // DgLd
            // 
            this.DgLd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgNum,
            this.DgName,
            this.DgMoves,
            this.DgTime});
            this.DgLd.Location = new System.Drawing.Point(12, 34);
            this.DgLd.Name = "DgLd";
            this.DgLd.Size = new System.Drawing.Size(324, 238);
            this.DgLd.TabIndex = 0;
            // 
            // DgNum
            // 
            this.DgNum.HeaderText = "№";
            this.DgNum.Name = "DgNum";
            this.DgNum.ReadOnly = true;
            this.DgNum.Width = 40;
            // 
            // DgName
            // 
            this.DgName.HeaderText = "Name";
            this.DgName.Name = "DgName";
            this.DgName.ReadOnly = true;
            this.DgName.Width = 80;
            // 
            // DgMoves
            // 
            this.DgMoves.HeaderText = "Moves";
            this.DgMoves.Name = "DgMoves";
            this.DgMoves.ReadOnly = true;
            this.DgMoves.Width = 80;
            // 
            // DgTime
            // 
            this.DgTime.HeaderText = "Time";
            this.DgTime.Name = "DgTime";
            this.DgTime.ReadOnly = true;
            this.DgTime.Width = 80;
            // 
            // LeaderboardDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinGame15.Properties.Resources.back1;
            this.ClientSize = new System.Drawing.Size(350, 308);
            this.Controls.Add(this.DgLd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeaderboardDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.LeaderboardDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgLd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgMoves;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTime;
    }
}