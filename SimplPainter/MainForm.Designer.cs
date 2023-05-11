namespace SimplPainter
{
    partial class MainForm
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
            this.ClientArea = new System.Windows.Forms.Panel();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ChromPanel = new System.Windows.Forms.Panel();
            this.chromClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientArea.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.ChromPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientArea
            // 
            this.ClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientArea.Controls.Add(this.button1);
            this.ClientArea.Controls.Add(this.ToolsPanel);
            this.ClientArea.Controls.Add(this.ChromPanel);
            this.ClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientArea.Location = new System.Drawing.Point(3, 3);
            this.ClientArea.Margin = new System.Windows.Forms.Padding(0);
            this.ClientArea.Name = "ClientArea";
            this.ClientArea.Size = new System.Drawing.Size(894, 634);
            this.ClientArea.TabIndex = 0;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ToolsPanel.Controls.Add(this.flowLayoutPanel1);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 40);
            this.ToolsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Padding = new System.Windows.Forms.Padding(20);
            this.ToolsPanel.Size = new System.Drawing.Size(300, 594);
            this.ToolsPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 184);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ChromPanel
            // 
            this.ChromPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromPanel.Controls.Add(this.chromClose);
            this.ChromPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChromPanel.Location = new System.Drawing.Point(0, 0);
            this.ChromPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ChromPanel.Name = "ChromPanel";
            this.ChromPanel.Size = new System.Drawing.Size(894, 40);
            this.ChromPanel.TabIndex = 0;
            this.ChromPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChromPanel_MouseDown);
            // 
            // chromClose
            // 
            this.chromClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chromClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chromClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.chromClose.FlatAppearance.BorderSize = 0;
            this.chromClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chromClose.Location = new System.Drawing.Point(814, 0);
            this.chromClose.Margin = new System.Windows.Forms.Padding(0);
            this.chromClose.Name = "chromClose";
            this.chromClose.Size = new System.Drawing.Size(80, 40);
            this.chromClose.TabIndex = 2;
            this.chromClose.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SimplPainter.Properties.Resources.close;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(600, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 192);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.ControlBox = false;
            this.Controls.Add(this.ClientArea);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ClientArea.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.ChromPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientArea;
        private System.Windows.Forms.Panel ChromPanel;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button chromClose;
        private System.Windows.Forms.Button button1;
    }
}

