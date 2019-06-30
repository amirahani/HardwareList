namespace HardwareList
{
    partial class frmHardwareList
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
            this.btnHardwareList = new System.Windows.Forms.Button();
            this.lstHardwareList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnHardwareList
            // 
            this.btnHardwareList.Location = new System.Drawing.Point(34, 32);
            this.btnHardwareList.Name = "btnHardwareList";
            this.btnHardwareList.Size = new System.Drawing.Size(129, 23);
            this.btnHardwareList.TabIndex = 0;
            this.btnHardwareList.Text = "Get Hardware List";
            this.btnHardwareList.UseVisualStyleBackColor = true;
            this.btnHardwareList.Click += new System.EventHandler(this.btnHardwareList_Click);
            // 
            // lstHardwareList
            // 
            this.lstHardwareList.FormattingEnabled = true;
            this.lstHardwareList.Location = new System.Drawing.Point(34, 62);
            this.lstHardwareList.Name = "lstHardwareList";
            this.lstHardwareList.Size = new System.Drawing.Size(1055, 459);
            this.lstHardwareList.TabIndex = 1;
            // 
            // frmHardwareList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 571);
            this.Controls.Add(this.lstHardwareList);
            this.Controls.Add(this.btnHardwareList);
            this.Name = "frmHardwareList";
            this.Text = "Hardware List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHardwareList;
        private System.Windows.Forms.ListBox lstHardwareList;
    }
}

