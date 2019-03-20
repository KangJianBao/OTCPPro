namespace OTCPServer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开启服务";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 53);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(406, 270);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(330, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空日志";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 344);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtLog);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTCP服务端";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.RichTextBox txtLog;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}

