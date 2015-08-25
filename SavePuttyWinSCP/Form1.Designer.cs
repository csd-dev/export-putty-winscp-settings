namespace SavePuttyWinSCP
{
    partial class ExportForm
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
            this.btnExpPutty = new System.Windows.Forms.Button();
            this.btnExpWinSCP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpPutty
            // 
            this.btnExpPutty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpPutty.Location = new System.Drawing.Point(84, 12);
            this.btnExpPutty.Name = "btnExpPutty";
            this.btnExpPutty.Size = new System.Drawing.Size(201, 25);
            this.btnExpPutty.TabIndex = 0;
            this.btnExpPutty.Text = "Export Putty";
            this.btnExpPutty.UseVisualStyleBackColor = true;
            this.btnExpPutty.Click += new System.EventHandler(this.btnExpPutty_Click);
            // 
            // btnExpWinSCP
            // 
            this.btnExpWinSCP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpWinSCP.Location = new System.Drawing.Point(84, 43);
            this.btnExpWinSCP.Name = "btnExpWinSCP";
            this.btnExpWinSCP.Size = new System.Drawing.Size(201, 23);
            this.btnExpWinSCP.TabIndex = 1;
            this.btnExpWinSCP.Text = "Export WinSCP";
            this.btnExpWinSCP.UseVisualStyleBackColor = true;
            this.btnExpWinSCP.Click += new System.EventHandler(this.btnExpWinSCP_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 80);
            this.Controls.Add(this.btnExpWinSCP);
            this.Controls.Add(this.btnExpPutty);
            this.MaximizeBox = false;
            this.Name = "ExportForm";
            this.Text = "Export Putty / WinSCP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExpPutty;
        private System.Windows.Forms.Button btnExpWinSCP;
    }
}

