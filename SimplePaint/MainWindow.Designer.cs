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
            this.ChromPanel = new System.Windows.Forms.Panel();
            this.ChromMinimize = new System.Windows.Forms.Button();
            this.ChromMaximize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChromClose = new System.Windows.Forms.Button();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.LabelWidht = new System.Windows.Forms.Label();
            this.CanvaHeight = new System.Windows.Forms.TextBox();
            this.CanvaWidht = new System.Windows.Forms.TextBox();
            this.UndoButton = new System.Windows.Forms.Button();
            this.LabelShapes = new System.Windows.Forms.Label();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.ReduButton = new System.Windows.Forms.Button();
            this.LabelTools = new System.Windows.Forms.Label();
            this.ColorPicked = new System.Windows.Forms.Button();
            this.PanelShapes = new System.Windows.Forms.Panel();
            this.Pipette = new System.Windows.Forms.Button();
            this.PanelTools = new System.Windows.Forms.Panel();
            this.BrushSize = new System.Windows.Forms.TextBox();
            this.LabelSize = new System.Windows.Forms.Label();
            this.BrushDown = new System.Windows.Forms.Button();
            this.BrushUp = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.ClientArea = new System.Windows.Forms.Panel();
            this.PanelCanva = new System.Windows.Forms.Panel();
            this.Canva = new System.Windows.Forms.PictureBox();
            this.ChromPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.PanelTools.SuspendLayout();
            this.ClientArea.SuspendLayout();
            this.PanelCanva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).BeginInit();
            this.SuspendLayout();
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
            this.ChromPanel.Size = new System.Drawing.Size(1494, 40);
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
            this.ChromMinimize.Location = new System.Drawing.Point(1254, 0);
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
            this.ChromMaximize.Location = new System.Drawing.Point(1334, 0);
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
            this.ChromClose.Location = new System.Drawing.Point(1414, 0);
            this.ChromClose.Name = "ChromClose";
            this.ChromClose.Size = new System.Drawing.Size(80, 40);
            this.ChromClose.TabIndex = 1;
            this.ChromClose.UseVisualStyleBackColor = true;
            this.ChromClose.Click += new System.EventHandler(this.ChromClose_Click);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ToolsPanel.Controls.Add(this.LabelHeight);
            this.ToolsPanel.Controls.Add(this.LabelWidht);
            this.ToolsPanel.Controls.Add(this.CanvaHeight);
            this.ToolsPanel.Controls.Add(this.CanvaWidht);
            this.ToolsPanel.Controls.Add(this.UndoButton);
            this.ToolsPanel.Controls.Add(this.LabelShapes);
            this.ToolsPanel.Controls.Add(this.SaveFileButton);
            this.ToolsPanel.Controls.Add(this.ReduButton);
            this.ToolsPanel.Controls.Add(this.LabelTools);
            this.ToolsPanel.Controls.Add(this.ColorPicked);
            this.ToolsPanel.Controls.Add(this.PanelShapes);
            this.ToolsPanel.Controls.Add(this.Pipette);
            this.ToolsPanel.Controls.Add(this.PanelTools);
            this.ToolsPanel.Controls.Add(this.button35);
            this.ToolsPanel.Controls.Add(this.button36);
            this.ToolsPanel.Controls.Add(this.button37);
            this.ToolsPanel.Controls.Add(this.button38);
            this.ToolsPanel.Controls.Add(this.button39);
            this.ToolsPanel.Controls.Add(this.button40);
            this.ToolsPanel.Controls.Add(this.button41);
            this.ToolsPanel.Controls.Add(this.button28);
            this.ToolsPanel.Controls.Add(this.button29);
            this.ToolsPanel.Controls.Add(this.button30);
            this.ToolsPanel.Controls.Add(this.button31);
            this.ToolsPanel.Controls.Add(this.button32);
            this.ToolsPanel.Controls.Add(this.button33);
            this.ToolsPanel.Controls.Add(this.button34);
            this.ToolsPanel.Controls.Add(this.button27);
            this.ToolsPanel.Controls.Add(this.button26);
            this.ToolsPanel.Controls.Add(this.button25);
            this.ToolsPanel.Controls.Add(this.button24);
            this.ToolsPanel.Controls.Add(this.button23);
            this.ToolsPanel.Controls.Add(this.button22);
            this.ToolsPanel.Controls.Add(this.button21);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 40);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ToolsPanel.Size = new System.Drawing.Size(300, 854);
            this.ToolsPanel.TabIndex = 1;
            // 
            // LabelHeight
            // 
            this.LabelHeight.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeight.ForeColor = System.Drawing.Color.White;
            this.LabelHeight.Location = new System.Drawing.Point(170, 759);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(120, 42);
            this.LabelHeight.TabIndex = 43;
            this.LabelHeight.Text = "HEIGHT";
            this.LabelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWidht
            // 
            this.LabelWidht.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidht.ForeColor = System.Drawing.Color.White;
            this.LabelWidht.Location = new System.Drawing.Point(10, 759);
            this.LabelWidht.Name = "LabelWidht";
            this.LabelWidht.Size = new System.Drawing.Size(120, 42);
            this.LabelWidht.TabIndex = 42;
            this.LabelWidht.Text = "WIDHT";
            this.LabelWidht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CanvaHeight
            // 
            this.CanvaHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.CanvaHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CanvaHeight.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanvaHeight.ForeColor = System.Drawing.Color.White;
            this.CanvaHeight.Location = new System.Drawing.Point(170, 802);
            this.CanvaHeight.Name = "CanvaHeight";
            this.CanvaHeight.Size = new System.Drawing.Size(120, 39);
            this.CanvaHeight.TabIndex = 41;
            this.CanvaHeight.Text = "500";
            this.CanvaHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CanvaHeight.TextChanged += new System.EventHandler(this.CanvaSize_Changed);
            this.CanvaHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOnlyNumbers);
            // 
            // CanvaWidht
            // 
            this.CanvaWidht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.CanvaWidht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CanvaWidht.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanvaWidht.ForeColor = System.Drawing.Color.White;
            this.CanvaWidht.Location = new System.Drawing.Point(10, 802);
            this.CanvaWidht.Name = "CanvaWidht";
            this.CanvaWidht.Size = new System.Drawing.Size(120, 39);
            this.CanvaWidht.TabIndex = 2;
            this.CanvaWidht.Text = "750";
            this.CanvaWidht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CanvaWidht.TextChanged += new System.EventHandler(this.CanvaSize_Changed);
            this.CanvaWidht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOnlyNumbers);
            this.CanvaWidht.Leave += new System.EventHandler(this.CanvaSize_Changed);
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.UndoButton.BackgroundImage = global::SimplePaint.Properties.Resources.undo;
            this.UndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UndoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.UndoButton.FlatAppearance.BorderSize = 0;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Location = new System.Drawing.Point(105, 10);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(90, 40);
            this.UndoButton.TabIndex = 6;
            this.UndoButton.UseVisualStyleBackColor = false;
            // 
            // LabelShapes
            // 
            this.LabelShapes.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShapes.ForeColor = System.Drawing.Color.White;
            this.LabelShapes.Location = new System.Drawing.Point(10, 509);
            this.LabelShapes.Name = "LabelShapes";
            this.LabelShapes.Size = new System.Drawing.Size(280, 42);
            this.LabelShapes.TabIndex = 40;
            this.LabelShapes.Text = "SHAPES";
            this.LabelShapes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SaveFileButton.BackgroundImage = global::SimplePaint.Properties.Resources.save;
            this.SaveFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SaveFileButton.FlatAppearance.BorderSize = 0;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Location = new System.Drawing.Point(10, 10);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(90, 40);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.UseVisualStyleBackColor = false;
            // 
            // ReduButton
            // 
            this.ReduButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ReduButton.BackgroundImage = global::SimplePaint.Properties.Resources.redu;
            this.ReduButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReduButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ReduButton.FlatAppearance.BorderSize = 0;
            this.ReduButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReduButton.Location = new System.Drawing.Point(200, 10);
            this.ReduButton.Name = "ReduButton";
            this.ReduButton.Size = new System.Drawing.Size(90, 40);
            this.ReduButton.TabIndex = 5;
            this.ReduButton.UseVisualStyleBackColor = false;
            // 
            // LabelTools
            // 
            this.LabelTools.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTools.ForeColor = System.Drawing.Color.White;
            this.LabelTools.Location = new System.Drawing.Point(13, 250);
            this.LabelTools.Name = "LabelTools";
            this.LabelTools.Size = new System.Drawing.Size(277, 42);
            this.LabelTools.TabIndex = 2;
            this.LabelTools.Text = "TOOLS";
            this.LabelTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPicked
            // 
            this.ColorPicked.BackColor = System.Drawing.Color.White;
            this.ColorPicked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ColorPicked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ColorPicked.FlatAppearance.BorderSize = 0;
            this.ColorPicked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPicked.Location = new System.Drawing.Point(20, 190);
            this.ColorPicked.Margin = new System.Windows.Forms.Padding(0);
            this.ColorPicked.Name = "ColorPicked";
            this.ColorPicked.Size = new System.Drawing.Size(140, 40);
            this.ColorPicked.TabIndex = 39;
            this.ColorPicked.UseVisualStyleBackColor = false;
            // 
            // PanelShapes
            // 
            this.PanelShapes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.PanelShapes.Location = new System.Drawing.Point(10, 554);
            this.PanelShapes.Name = "PanelShapes";
            this.PanelShapes.Size = new System.Drawing.Size(280, 200);
            this.PanelShapes.TabIndex = 13;
            // 
            // Pipette
            // 
            this.Pipette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Pipette.BackgroundImage = global::SimplePaint.Properties.Resources.pipette;
            this.Pipette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pipette.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Pipette.FlatAppearance.BorderSize = 0;
            this.Pipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pipette.Location = new System.Drawing.Point(170, 190);
            this.Pipette.Margin = new System.Windows.Forms.Padding(0);
            this.Pipette.Name = "Pipette";
            this.Pipette.Size = new System.Drawing.Size(120, 40);
            this.Pipette.TabIndex = 8;
            this.Pipette.UseVisualStyleBackColor = false;
            // 
            // PanelTools
            // 
            this.PanelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.PanelTools.Controls.Add(this.BrushSize);
            this.PanelTools.Controls.Add(this.LabelSize);
            this.PanelTools.Controls.Add(this.BrushDown);
            this.PanelTools.Controls.Add(this.BrushUp);
            this.PanelTools.Location = new System.Drawing.Point(10, 295);
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.Size = new System.Drawing.Size(280, 200);
            this.PanelTools.TabIndex = 11;
            // 
            // BrushSize
            // 
            this.BrushSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.BrushSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrushSize.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrushSize.ForeColor = System.Drawing.Color.White;
            this.BrushSize.Location = new System.Drawing.Point(146, 154);
            this.BrushSize.MaxLength = 3;
            this.BrushSize.Name = "BrushSize";
            this.BrushSize.Size = new System.Drawing.Size(55, 39);
            this.BrushSize.TabIndex = 2;
            this.BrushSize.Text = "8";
            this.BrushSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BrushSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOnlyNumbers);
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSize.ForeColor = System.Drawing.Color.White;
            this.LabelSize.Location = new System.Drawing.Point(61, 154);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(59, 38);
            this.LabelSize.TabIndex = 3;
            this.LabelSize.Text = "SIZE";
            // 
            // BrushDown
            // 
            this.BrushDown.BackgroundImage = global::SimplePaint.Properties.Resources.arrow_left;
            this.BrushDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrushDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.BrushDown.FlatAppearance.BorderSize = 0;
            this.BrushDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrushDown.Location = new System.Drawing.Point(123, 154);
            this.BrushDown.Margin = new System.Windows.Forms.Padding(0);
            this.BrushDown.Name = "BrushDown";
            this.BrushDown.Size = new System.Drawing.Size(20, 39);
            this.BrushDown.TabIndex = 9;
            this.BrushDown.UseVisualStyleBackColor = false;
            // 
            // BrushUp
            // 
            this.BrushUp.BackgroundImage = global::SimplePaint.Properties.Resources.arrow_right;
            this.BrushUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrushUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.BrushUp.FlatAppearance.BorderSize = 0;
            this.BrushUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrushUp.Location = new System.Drawing.Point(204, 154);
            this.BrushUp.Margin = new System.Windows.Forms.Padding(0);
            this.BrushUp.Name = "BrushUp";
            this.BrushUp.Size = new System.Drawing.Size(20, 39);
            this.BrushUp.TabIndex = 10;
            this.BrushUp.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.Blue;
            this.button35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button35.FlatAppearance.BorderSize = 0;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Location = new System.Drawing.Point(250, 140);
            this.button35.Margin = new System.Windows.Forms.Padding(0);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(40, 40);
            this.button35.TabIndex = 38;
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.Aqua;
            this.button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Location = new System.Drawing.Point(210, 140);
            this.button36.Margin = new System.Windows.Forms.Padding(0);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(40, 40);
            this.button36.TabIndex = 37;
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.Lime;
            this.button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button37.FlatAppearance.BorderSize = 0;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Location = new System.Drawing.Point(170, 140);
            this.button37.Margin = new System.Windows.Forms.Padding(0);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(40, 40);
            this.button37.TabIndex = 36;
            this.button37.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.Yellow;
            this.button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button38.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button38.FlatAppearance.BorderSize = 0;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Location = new System.Drawing.Point(130, 140);
            this.button38.Margin = new System.Windows.Forms.Padding(0);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(40, 40);
            this.button38.TabIndex = 35;
            this.button38.UseVisualStyleBackColor = false;
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button39.FlatAppearance.BorderSize = 0;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Location = new System.Drawing.Point(90, 140);
            this.button39.Margin = new System.Windows.Forms.Padding(0);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(40, 40);
            this.button39.TabIndex = 34;
            this.button39.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.Red;
            this.button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button40.FlatAppearance.BorderSize = 0;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Location = new System.Drawing.Point(50, 140);
            this.button40.Margin = new System.Windows.Forms.Padding(0);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(40, 40);
            this.button40.TabIndex = 33;
            this.button40.UseVisualStyleBackColor = false;
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.Black;
            this.button41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button41.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button41.FlatAppearance.BorderSize = 0;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Location = new System.Drawing.Point(10, 140);
            this.button41.Margin = new System.Windows.Forms.Padding(0);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(40, 40);
            this.button41.TabIndex = 32;
            this.button41.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Location = new System.Drawing.Point(250, 100);
            this.button28.Margin = new System.Windows.Forms.Padding(0);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(40, 40);
            this.button28.TabIndex = 31;
            this.button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(210, 100);
            this.button29.Margin = new System.Windows.Forms.Padding(0);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(40, 40);
            this.button29.TabIndex = 30;
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Location = new System.Drawing.Point(170, 100);
            this.button30.Margin = new System.Windows.Forms.Padding(0);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(40, 40);
            this.button30.TabIndex = 29;
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Location = new System.Drawing.Point(130, 100);
            this.button31.Margin = new System.Windows.Forms.Padding(0);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(40, 40);
            this.button31.TabIndex = 28;
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Location = new System.Drawing.Point(90, 100);
            this.button32.Margin = new System.Windows.Forms.Padding(0);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(40, 40);
            this.button32.TabIndex = 27;
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Location = new System.Drawing.Point(50, 100);
            this.button33.Margin = new System.Windows.Forms.Padding(0);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(40, 40);
            this.button33.TabIndex = 26;
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Silver;
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Location = new System.Drawing.Point(10, 100);
            this.button34.Margin = new System.Windows.Forms.Padding(0);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(40, 40);
            this.button34.TabIndex = 25;
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(250, 60);
            this.button27.Margin = new System.Windows.Forms.Padding(0);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(40, 40);
            this.button27.TabIndex = 24;
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Location = new System.Drawing.Point(210, 60);
            this.button26.Margin = new System.Windows.Forms.Padding(0);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(40, 40);
            this.button26.TabIndex = 23;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(170, 60);
            this.button25.Margin = new System.Windows.Forms.Padding(0);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(40, 40);
            this.button25.TabIndex = 22;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(130, 60);
            this.button24.Margin = new System.Windows.Forms.Padding(0);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(40, 40);
            this.button24.TabIndex = 21;
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(90, 60);
            this.button23.Margin = new System.Windows.Forms.Padding(0);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(40, 40);
            this.button23.TabIndex = 20;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(50, 60);
            this.button22.Margin = new System.Windows.Forms.Padding(0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(40, 40);
            this.button22.TabIndex = 19;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(10, 60);
            this.button21.Margin = new System.Windows.Forms.Padding(0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(40, 40);
            this.button21.TabIndex = 18;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // ClientArea
            // 
            this.ClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientArea.Controls.Add(this.PanelCanva);
            this.ClientArea.Controls.Add(this.ToolsPanel);
            this.ClientArea.Controls.Add(this.ChromPanel);
            this.ClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientArea.Location = new System.Drawing.Point(3, 3);
            this.ClientArea.Margin = new System.Windows.Forms.Padding(0);
            this.ClientArea.Name = "ClientArea";
            this.ClientArea.Size = new System.Drawing.Size(1494, 894);
            this.ClientArea.TabIndex = 0;
            // 
            // PanelCanva
            // 
            this.PanelCanva.AutoScroll = true;
            this.PanelCanva.Controls.Add(this.Canva);
            this.PanelCanva.Location = new System.Drawing.Point(316, 60);
            this.PanelCanva.Name = "PanelCanva";
            this.PanelCanva.Size = new System.Drawing.Size(1158, 814);
            this.PanelCanva.TabIndex = 2;
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.Color.White;
            this.Canva.Location = new System.Drawing.Point(0, 0);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(96, 96);
            this.Canva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canva.TabIndex = 0;
            this.Canva.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.ClientArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.ChromPanel.ResumeLayout(false);
            this.ChromPanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            this.PanelTools.ResumeLayout(false);
            this.PanelTools.PerformLayout();
            this.ClientArea.ResumeLayout(false);
            this.PanelCanva.ResumeLayout(false);
            this.PanelCanva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChromPanel;
        private System.Windows.Forms.Button ChromMinimize;
        private System.Windows.Forms.Button ChromMaximize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChromClose;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button ReduButton;
        private System.Windows.Forms.Button BrushUp;
        private System.Windows.Forms.TextBox BrushSize;
        private System.Windows.Forms.Button BrushDown;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Button Pipette;
        private System.Windows.Forms.Panel ClientArea;
        private System.Windows.Forms.Panel PanelTools;
        private System.Windows.Forms.Panel PanelShapes;
        private System.Windows.Forms.Button ColorPicked;
        private System.Windows.Forms.Label LabelShapes;
        private System.Windows.Forms.Label LabelTools;
        private System.Windows.Forms.TextBox CanvaWidht;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.Label LabelWidht;
        private System.Windows.Forms.TextBox CanvaHeight;
        private System.Windows.Forms.Panel PanelCanva;
        private System.Windows.Forms.PictureBox Canva;
    }
}

