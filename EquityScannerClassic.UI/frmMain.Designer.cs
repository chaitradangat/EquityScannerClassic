namespace EquityScannerClassic.UI
{
    partial class frmMain
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
            this.grdEquities = new System.Windows.Forms.DataGridView();
            this.btnScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frequency ( minutes )";
            // 
            // grdEquities
            // 
            this.grdEquities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquities.Location = new System.Drawing.Point(7, 213);
            this.grdEquities.Name = "grdEquities";
            this.grdEquities.Size = new System.Drawing.Size(1023, 199);
            this.grdEquities.TabIndex = 2;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(887, 13);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(140, 54);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 420);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.grdEquities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Equity Scanner Classic";
            ((System.ComponentModel.ISupportInitialize)(this.grdEquities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdEquities;
        private System.Windows.Forms.Button btnScan;
    }
}

