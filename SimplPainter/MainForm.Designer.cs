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
            this.ChromPanel = new System.Windows.Forms.Panel();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.round_Button1 = new SimplPainter.Round_Button();
            this.round_Button2 = new SimplPainter.Round_Button();
            this.round_Button3 = new SimplPainter.Round_Button();
            this.round_Button4 = new SimplPainter.Round_Button();
            this.ChromMinimize = new SimplPainter.Round_Button();
            this.ChromMaximize = new SimplPainter.Round_Button();
            this.ChromClose = new SimplPainter.Round_Button();
            this.round_Button5 = new SimplPainter.Round_Button();
            this.ClientArea.SuspendLayout();
            this.ChromPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientArea
            // 
            this.ClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientArea.Controls.Add(this.ToolsPanel);
            this.ClientArea.Controls.Add(this.ChromPanel);
            this.ClientArea.Controls.Add(this.round_Button5);
            this.ClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientArea.Location = new System.Drawing.Point(3, 3);
            this.ClientArea.Margin = new System.Windows.Forms.Padding(0);
            this.ClientArea.Name = "ClientArea";
            this.ClientArea.Size = new System.Drawing.Size(894, 634);
            this.ClientArea.TabIndex = 0;
            // 
            // ChromPanel
            // 
            this.ChromPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromPanel.Controls.Add(this.ChromMinimize);
            this.ChromPanel.Controls.Add(this.ChromMaximize);
            this.ChromPanel.Controls.Add(this.ChromClose);
            this.ChromPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChromPanel.Location = new System.Drawing.Point(0, 0);
            this.ChromPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ChromPanel.Name = "ChromPanel";
            this.ChromPanel.Size = new System.Drawing.Size(894, 40);
            this.ChromPanel.TabIndex = 0;
            this.ChromPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChromPanel_MouseDown);
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
            this.flowLayoutPanel1.Controls.Add(this.round_Button1);
            this.flowLayoutPanel1.Controls.Add(this.round_Button2);
            this.flowLayoutPanel1.Controls.Add(this.round_Button3);
            this.flowLayoutPanel1.Controls.Add(this.round_Button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 184);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // round_Button1
            // 
            this.round_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button1.BorderColor = System.Drawing.Color.White;
            this.round_Button1.BorderRadius = 20;
            this.round_Button1.BorderSize = 5;
            this.round_Button1.FlatAppearance.BorderSize = 0;
            this.round_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_Button1.ForeColor = System.Drawing.Color.White;
            this.round_Button1.Location = new System.Drawing.Point(5, 5);
            this.round_Button1.Margin = new System.Windows.Forms.Padding(5);
            this.round_Button1.Name = "round_Button1";
            this.round_Button1.Size = new System.Drawing.Size(55, 55);
            this.round_Button1.TabIndex = 2;
            this.round_Button1.TextColor = System.Drawing.Color.White;
            this.round_Button1.UseVisualStyleBackColor = false;
            // 
            // round_Button2
            // 
            this.round_Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button2.BorderColor = System.Drawing.Color.White;
            this.round_Button2.BorderRadius = 20;
            this.round_Button2.BorderSize = 5;
            this.round_Button2.FlatAppearance.BorderSize = 0;
            this.round_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_Button2.ForeColor = System.Drawing.Color.White;
            this.round_Button2.Location = new System.Drawing.Point(70, 5);
            this.round_Button2.Margin = new System.Windows.Forms.Padding(5);
            this.round_Button2.Name = "round_Button2";
            this.round_Button2.Size = new System.Drawing.Size(55, 55);
            this.round_Button2.TabIndex = 3;
            this.round_Button2.TextColor = System.Drawing.Color.White;
            this.round_Button2.UseVisualStyleBackColor = false;
            // 
            // round_Button3
            // 
            this.round_Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button3.BorderColor = System.Drawing.Color.White;
            this.round_Button3.BorderRadius = 20;
            this.round_Button3.BorderSize = 5;
            this.round_Button3.FlatAppearance.BorderSize = 0;
            this.round_Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_Button3.ForeColor = System.Drawing.Color.White;
            this.round_Button3.Location = new System.Drawing.Point(135, 5);
            this.round_Button3.Margin = new System.Windows.Forms.Padding(5);
            this.round_Button3.Name = "round_Button3";
            this.round_Button3.Size = new System.Drawing.Size(55, 55);
            this.round_Button3.TabIndex = 4;
            this.round_Button3.TextColor = System.Drawing.Color.White;
            this.round_Button3.UseVisualStyleBackColor = false;
            // 
            // round_Button4
            // 
            this.round_Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button4.BorderColor = System.Drawing.Color.White;
            this.round_Button4.BorderRadius = 20;
            this.round_Button4.BorderSize = 5;
            this.round_Button4.FlatAppearance.BorderSize = 0;
            this.round_Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.round_Button4, true);
            this.round_Button4.ForeColor = System.Drawing.Color.White;
            this.round_Button4.Location = new System.Drawing.Point(200, 5);
            this.round_Button4.Margin = new System.Windows.Forms.Padding(5);
            this.round_Button4.Name = "round_Button4";
            this.round_Button4.Size = new System.Drawing.Size(55, 55);
            this.round_Button4.TabIndex = 5;
            this.round_Button4.TextColor = System.Drawing.Color.White;
            this.round_Button4.UseVisualStyleBackColor = false;
            // 
            // ChromMinimize
            // 
            this.ChromMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromMinimize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromMinimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ChromMinimize.BorderRadius = 0;
            this.ChromMinimize.BorderSize = 0;
            this.ChromMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChromMinimize.FlatAppearance.BorderSize = 0;
            this.ChromMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromMinimize.ForeColor = System.Drawing.Color.White;
            this.ChromMinimize.Location = new System.Drawing.Point(648, 0);
            this.ChromMinimize.Name = "ChromMinimize";
            this.ChromMinimize.Size = new System.Drawing.Size(82, 40);
            this.ChromMinimize.TabIndex = 3;
            this.ChromMinimize.Text = "_";
            this.ChromMinimize.TextColor = System.Drawing.Color.White;
            this.ChromMinimize.UseVisualStyleBackColor = false;
            this.ChromMinimize.Click += new System.EventHandler(this.ChromMinimize_Click);
            // 
            // ChromMaximize
            // 
            this.ChromMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromMaximize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromMaximize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ChromMaximize.BorderRadius = 0;
            this.ChromMaximize.BorderSize = 0;
            this.ChromMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChromMaximize.FlatAppearance.BorderSize = 0;
            this.ChromMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromMaximize.ForeColor = System.Drawing.Color.White;
            this.ChromMaximize.Location = new System.Drawing.Point(730, 0);
            this.ChromMaximize.Name = "ChromMaximize";
            this.ChromMaximize.Size = new System.Drawing.Size(82, 40);
            this.ChromMaximize.TabIndex = 2;
            this.ChromMaximize.Text = "[ ]";
            this.ChromMaximize.TextColor = System.Drawing.Color.White;
            this.ChromMaximize.UseVisualStyleBackColor = false;
            this.ChromMaximize.Click += new System.EventHandler(this.ChromMaximize_Click);
            // 
            // ChromClose
            // 
            this.ChromClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ChromClose.BorderRadius = 0;
            this.ChromClose.BorderSize = 0;
            this.ChromClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChromClose.FlatAppearance.BorderSize = 0;
            this.ChromClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromClose.ForeColor = System.Drawing.Color.White;
            this.ChromClose.Location = new System.Drawing.Point(812, 0);
            this.ChromClose.Name = "ChromClose";
            this.ChromClose.Size = new System.Drawing.Size(82, 40);
            this.ChromClose.TabIndex = 1;
            this.ChromClose.Text = "X";
            this.ChromClose.TextColor = System.Drawing.Color.White;
            this.ChromClose.UseVisualStyleBackColor = false;
            this.ChromClose.Click += new System.EventHandler(this.ChromClose_Click);
            // 
            // round_Button5
            // 
            this.round_Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.round_Button5.BorderColor = System.Drawing.Color.White;
            this.round_Button5.BorderRadius = 150;
            this.round_Button5.BorderSize = 5;
            this.round_Button5.FlatAppearance.BorderSize = 0;
            this.round_Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_Button5.ForeColor = System.Drawing.Color.White;
            this.round_Button5.Location = new System.Drawing.Point(555, 225);
            this.round_Button5.Margin = new System.Windows.Forms.Padding(5);
            this.round_Button5.Name = "round_Button5";
            this.round_Button5.Size = new System.Drawing.Size(150, 150);
            this.round_Button5.TabIndex = 6;
            this.round_Button5.TextColor = System.Drawing.Color.White;
            this.round_Button5.UseVisualStyleBackColor = false;
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
            this.ChromPanel.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientArea;
        private System.Windows.Forms.Panel ChromPanel;
        private Round_Button ChromClose;
        private Round_Button ChromMinimize;
        private Round_Button ChromMaximize;
        private System.Windows.Forms.Panel ToolsPanel;
        private Round_Button round_Button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Round_Button round_Button2;
        private Round_Button round_Button3;
        private Round_Button round_Button4;
        private Round_Button round_Button5;
    }
}

