namespace SimplePaint
{
    partial class MainWindow
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
            this.PanelFileButtons = new System.Windows.Forms.Panel();
            this.UndoButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.ReduButton = new System.Windows.Forms.Button();
            this.ChromPanel = new System.Windows.Forms.Panel();
            this.ChromMinimize = new System.Windows.Forms.Button();
            this.ChromMaximize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChromClose = new System.Windows.Forms.Button();
            this.ClientArea.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.PanelFileButtons.SuspendLayout();
            this.ChromPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientArea
            // 
            this.ClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientArea.Controls.Add(this.ToolsPanel);
            this.ClientArea.Controls.Add(this.ChromPanel);
            this.ClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientArea.Location = new System.Drawing.Point(3, 3);
            this.ClientArea.Margin = new System.Windows.Forms.Padding(0);
            this.ClientArea.Name = "ClientArea";
            this.ClientArea.Size = new System.Drawing.Size(894, 594);
            this.ClientArea.TabIndex = 0;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ToolsPanel.Controls.Add(this.PanelFileButtons);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 40);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(300, 554);
            this.ToolsPanel.TabIndex = 1;
            // 
            // PanelFileButtons
            // 
            this.PanelFileButtons.Controls.Add(this.UndoButton);
            this.PanelFileButtons.Controls.Add(this.SaveFileButton);
            this.PanelFileButtons.Controls.Add(this.ReduButton);
            this.PanelFileButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFileButtons.Location = new System.Drawing.Point(0, 0);
            this.PanelFileButtons.Name = "PanelFileButtons";
            this.PanelFileButtons.Size = new System.Drawing.Size(300, 50);
            this.PanelFileButtons.TabIndex = 2;
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.UndoButton.BackgroundImage = global::SimplePaint.Properties.Resources.undo;
            this.UndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UndoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UndoButton.FlatAppearance.BorderSize = 0;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Location = new System.Drawing.Point(100, 0);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(100, 50);
            this.UndoButton.TabIndex = 6;
            this.UndoButton.UseVisualStyleBackColor = false;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SaveFileButton.BackgroundImage = global::SimplePaint.Properties.Resources.save;
            this.SaveFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveFileButton.FlatAppearance.BorderSize = 0;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Location = new System.Drawing.Point(0, 0);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(100, 50);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.UseVisualStyleBackColor = false;
            // 
            // ReduButton
            // 
            this.ReduButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ReduButton.BackgroundImage = global::SimplePaint.Properties.Resources.redu;
            this.ReduButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReduButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReduButton.Enabled = false;
            this.ReduButton.FlatAppearance.BorderSize = 0;
            this.ReduButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReduButton.Location = new System.Drawing.Point(200, 0);
            this.ReduButton.Name = "ReduButton";
            this.ReduButton.Size = new System.Drawing.Size(100, 50);
            this.ReduButton.TabIndex = 5;
            this.ReduButton.UseVisualStyleBackColor = false;
            // 
            // ChromPanel
            // 
            this.ChromPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromPanel.Controls.Add(this.ChromMinimize);
            this.ChromPanel.Controls.Add(this.ChromMaximize);
            this.ChromPanel.Controls.Add(this.label1);
            this.ChromPanel.Controls.Add(this.ChromClose);
            this.ChromPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChromPanel.Location = new System.Drawing.Point(0, 0);
            this.ChromPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ChromPanel.Name = "ChromPanel";
            this.ChromPanel.Size = new System.Drawing.Size(894, 40);
            this.ChromPanel.TabIndex = 0;
            this.ChromPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChromPanel_MouseDown);
            // 
            // ChromMinimize
            // 
            this.ChromMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromMinimize.BackgroundImage = global::SimplePaint.Properties.Resources.minimize;
            this.ChromMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChromMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChromMinimize.FlatAppearance.BorderSize = 0;
            this.ChromMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromMinimize.Location = new System.Drawing.Point(654, 0);
            this.ChromMinimize.Name = "ChromMinimize";
            this.ChromMinimize.Size = new System.Drawing.Size(80, 40);
            this.ChromMinimize.TabIndex = 3;
            this.ChromMinimize.UseVisualStyleBackColor = true;
            this.ChromMinimize.Click += new System.EventHandler(this.ChromMinimize_Click);
            // 
            // ChromMaximize
            // 
            this.ChromMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromMaximize.BackgroundImage = global::SimplePaint.Properties.Resources.maximazi;
            this.ChromMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChromMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChromMaximize.FlatAppearance.BorderSize = 0;
            this.ChromMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromMaximize.Location = new System.Drawing.Point(734, 0);
            this.ChromMaximize.Name = "ChromMaximize";
            this.ChromMaximize.Size = new System.Drawing.Size(80, 40);
            this.ChromMaximize.TabIndex = 2;
            this.ChromMaximize.UseVisualStyleBackColor = true;
            this.ChromMaximize.Click += new System.EventHandler(this.ChromMaximize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple Paint";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChromPanel_MouseDown);
            // 
            // ChromClose
            // 
            this.ChromClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ChromClose.BackgroundImage = global::SimplePaint.Properties.Resources.close;
            this.ChromClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChromClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChromClose.FlatAppearance.BorderSize = 0;
            this.ChromClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromClose.Location = new System.Drawing.Point(814, 0);
            this.ChromClose.Name = "ChromClose";
            this.ChromClose.Size = new System.Drawing.Size(80, 40);
            this.ChromClose.TabIndex = 1;
            this.ChromClose.UseVisualStyleBackColor = true;
            this.ChromClose.Click += new System.EventHandler(this.ChromClose_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.ClientArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.ClientArea.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.PanelFileButtons.ResumeLayout(false);
            this.ChromPanel.ResumeLayout(false);
            this.ChromPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientArea;
        private System.Windows.Forms.Panel ChromPanel;
        private System.Windows.Forms.Button ChromClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChromMinimize;
        private System.Windows.Forms.Button ChromMaximize;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Panel PanelFileButtons;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button ReduButton;
    }
}

