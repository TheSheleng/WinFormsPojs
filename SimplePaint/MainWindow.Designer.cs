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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ChromPanel = new System.Windows.Forms.Panel();
            this.ChromMinimize = new System.Windows.Forms.Button();
            this.ChromMaximize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChromClose = new System.Windows.Forms.Button();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.ButtonColor24 = new System.Windows.Forms.Button();
            this.ContextMenuStripColorFill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fillUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelShapes = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonDWLine = new System.Windows.Forms.Button();
            this.ButtonDWRectangle = new System.Windows.Forms.Button();
            this.ButtonDWEllipse = new System.Windows.Forms.Button();
            this.ButtonDWPolygon = new System.Windows.Forms.Button();
            this.PanelTools = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonDWPen = new System.Windows.Forms.Button();
            this.ButtonDWEraser = new System.Windows.Forms.Button();
            this.ButtonDWFill = new System.Windows.Forms.Button();
            this.ButtonDWPipette = new System.Windows.Forms.Button();
            this.ButtonColor23 = new System.Windows.Forms.Button();
            this.ButtonColor22 = new System.Windows.Forms.Button();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.LabelWidht = new System.Windows.Forms.Label();
            this.PenSize = new System.Windows.Forms.TextBox();
            this.CanvaHeight = new System.Windows.Forms.TextBox();
            this.BrushDown = new System.Windows.Forms.Button();
            this.CanvaWidht = new System.Windows.Forms.TextBox();
            this.BrushUp = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.LabelShapes = new System.Windows.Forms.Label();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.ReduButton = new System.Windows.Forms.Button();
            this.LabelTools = new System.Windows.Forms.Label();
            this.ColorPicked = new System.Windows.Forms.Button();
            this.ButtonColor21 = new System.Windows.Forms.Button();
            this.ButtonColor18 = new System.Windows.Forms.Button();
            this.ButtonColor15 = new System.Windows.Forms.Button();
            this.ButtonColor12 = new System.Windows.Forms.Button();
            this.ButtonColor9 = new System.Windows.Forms.Button();
            this.ButtonColor6 = new System.Windows.Forms.Button();
            this.ButtonColor3 = new System.Windows.Forms.Button();
            this.ButtonColor20 = new System.Windows.Forms.Button();
            this.ButtonColor17 = new System.Windows.Forms.Button();
            this.ButtonColor14 = new System.Windows.Forms.Button();
            this.ButtonColor11 = new System.Windows.Forms.Button();
            this.ButtonColor8 = new System.Windows.Forms.Button();
            this.ButtonColor5 = new System.Windows.Forms.Button();
            this.ButtonColor2 = new System.Windows.Forms.Button();
            this.ButtonColor19 = new System.Windows.Forms.Button();
            this.ButtonColor16 = new System.Windows.Forms.Button();
            this.ButtonColor13 = new System.Windows.Forms.Button();
            this.ButtonColor10 = new System.Windows.Forms.Button();
            this.ButtonColor7 = new System.Windows.Forms.Button();
            this.ButtonColor4 = new System.Windows.Forms.Button();
            this.ButtonColor1 = new System.Windows.Forms.Button();
            this.ClientArea = new System.Windows.Forms.Panel();
            this.PanelCanva = new System.Windows.Forms.Panel();
            this.PanelCanvaScroll = new System.Windows.Forms.Panel();
            this.Canva = new System.Windows.Forms.PictureBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ChromPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.ContextMenuStripColorFill.SuspendLayout();
            this.PanelShapes.SuspendLayout();
            this.PanelTools.SuspendLayout();
            this.ClientArea.SuspendLayout();
            this.PanelCanva.SuspendLayout();
            this.PanelCanvaScroll.SuspendLayout();
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
            this.ToolsPanel.Controls.Add(this.ButtonColor24);
            this.ToolsPanel.Controls.Add(this.PanelShapes);
            this.ToolsPanel.Controls.Add(this.PanelTools);
            this.ToolsPanel.Controls.Add(this.ButtonColor23);
            this.ToolsPanel.Controls.Add(this.ButtonColor22);
            this.ToolsPanel.Controls.Add(this.LabelHeight);
            this.ToolsPanel.Controls.Add(this.LabelWidht);
            this.ToolsPanel.Controls.Add(this.PenSize);
            this.ToolsPanel.Controls.Add(this.CanvaHeight);
            this.ToolsPanel.Controls.Add(this.BrushDown);
            this.ToolsPanel.Controls.Add(this.CanvaWidht);
            this.ToolsPanel.Controls.Add(this.BrushUp);
            this.ToolsPanel.Controls.Add(this.UndoButton);
            this.ToolsPanel.Controls.Add(this.LabelShapes);
            this.ToolsPanel.Controls.Add(this.SaveFileButton);
            this.ToolsPanel.Controls.Add(this.ReduButton);
            this.ToolsPanel.Controls.Add(this.LabelTools);
            this.ToolsPanel.Controls.Add(this.ColorPicked);
            this.ToolsPanel.Controls.Add(this.ButtonColor21);
            this.ToolsPanel.Controls.Add(this.ButtonColor18);
            this.ToolsPanel.Controls.Add(this.ButtonColor15);
            this.ToolsPanel.Controls.Add(this.ButtonColor12);
            this.ToolsPanel.Controls.Add(this.ButtonColor9);
            this.ToolsPanel.Controls.Add(this.ButtonColor6);
            this.ToolsPanel.Controls.Add(this.ButtonColor3);
            this.ToolsPanel.Controls.Add(this.ButtonColor20);
            this.ToolsPanel.Controls.Add(this.ButtonColor17);
            this.ToolsPanel.Controls.Add(this.ButtonColor14);
            this.ToolsPanel.Controls.Add(this.ButtonColor11);
            this.ToolsPanel.Controls.Add(this.ButtonColor8);
            this.ToolsPanel.Controls.Add(this.ButtonColor5);
            this.ToolsPanel.Controls.Add(this.ButtonColor2);
            this.ToolsPanel.Controls.Add(this.ButtonColor19);
            this.ToolsPanel.Controls.Add(this.ButtonColor16);
            this.ToolsPanel.Controls.Add(this.ButtonColor13);
            this.ToolsPanel.Controls.Add(this.ButtonColor10);
            this.ToolsPanel.Controls.Add(this.ButtonColor7);
            this.ToolsPanel.Controls.Add(this.ButtonColor4);
            this.ToolsPanel.Controls.Add(this.ButtonColor1);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 40);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ToolsPanel.Size = new System.Drawing.Size(340, 854);
            this.ToolsPanel.TabIndex = 1;
            // 
            // ButtonColor24
            // 
            this.ButtonColor24.BackColor = System.Drawing.Color.Magenta;
            this.ButtonColor24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor24.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor24.FlatAppearance.BorderSize = 0;
            this.ButtonColor24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor24.Location = new System.Drawing.Point(290, 140);
            this.ButtonColor24.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor24.Name = "ButtonColor24";
            this.ButtonColor24.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor24.TabIndex = 46;
            this.ButtonColor24.UseVisualStyleBackColor = false;
            this.ButtonColor24.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ContextMenuStripColorFill
            // 
            this.ContextMenuStripColorFill.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripColorFill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillUpToolStripMenuItem});
            this.ContextMenuStripColorFill.Name = "ContextMenuStripColorFill";
            this.ContextMenuStripColorFill.Size = new System.Drawing.Size(132, 36);
            // 
            // fillUpToolStripMenuItem
            // 
            this.fillUpToolStripMenuItem.Name = "fillUpToolStripMenuItem";
            this.fillUpToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.fillUpToolStripMenuItem.Text = "Fill up";
            this.fillUpToolStripMenuItem.Click += new System.EventHandler(this.FillUpToolStripMenuItem_Click);
            // 
            // PanelShapes
            // 
            this.PanelShapes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.PanelShapes.Controls.Add(this.ButtonDWLine);
            this.PanelShapes.Controls.Add(this.ButtonDWRectangle);
            this.PanelShapes.Controls.Add(this.ButtonDWEllipse);
            this.PanelShapes.Controls.Add(this.ButtonDWPolygon);
            this.PanelShapes.Location = new System.Drawing.Point(5, 475);
            this.PanelShapes.Name = "PanelShapes";
            this.PanelShapes.Padding = new System.Windows.Forms.Padding(5);
            this.PanelShapes.Size = new System.Drawing.Size(330, 90);
            this.PanelShapes.TabIndex = 14;
            // 
            // ButtonDWLine
            // 
            this.ButtonDWLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWLine.BackgroundImage = global::SimplePaint.Properties.Resources.line;
            this.ButtonDWLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDWLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDWLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWLine.FlatAppearance.BorderSize = 0;
            this.ButtonDWLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDWLine.Location = new System.Drawing.Point(10, 10);
            this.ButtonDWLine.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDWLine.Name = "ButtonDWLine";
            this.ButtonDWLine.Size = new System.Drawing.Size(70, 70);
            this.ButtonDWLine.TabIndex = 12;
            this.ButtonDWLine.Tag = "";
            this.ButtonDWLine.UseVisualStyleBackColor = false;
            this.ButtonDWLine.Click += new System.EventHandler(this.ButtonDW_Click);
            // 
            // ButtonDWRectangle
            // 
            this.ButtonDWRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWRectangle.BackgroundImage = global::SimplePaint.Properties.Resources.rectangle;
            this.ButtonDWRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDWRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDWRectangle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWRectangle.FlatAppearance.BorderSize = 0;
            this.ButtonDWRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDWRectangle.Location = new System.Drawing.Point(90, 10);
            this.ButtonDWRectangle.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDWRectangle.Name = "ButtonDWRectangle";
            this.ButtonDWRectangle.Size = new System.Drawing.Size(70, 70);
            this.ButtonDWRectangle.TabIndex = 8;
            this.ButtonDWRectangle.Tag = "";
            this.ButtonDWRectangle.UseVisualStyleBackColor = false;
            this.ButtonDWRectangle.Click += new System.EventHandler(this.ButtonDW_Click);
            // 
            // ButtonDWEllipse
            // 
            this.ButtonDWEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWEllipse.BackgroundImage = global::SimplePaint.Properties.Resources.ellipse;
            this.ButtonDWEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDWEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDWEllipse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWEllipse.FlatAppearance.BorderSize = 0;
            this.ButtonDWEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDWEllipse.Location = new System.Drawing.Point(170, 10);
            this.ButtonDWEllipse.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDWEllipse.Name = "ButtonDWEllipse";
            this.ButtonDWEllipse.Size = new System.Drawing.Size(70, 70);
            this.ButtonDWEllipse.TabIndex = 11;
            this.ButtonDWEllipse.Tag = "";
            this.ButtonDWEllipse.UseVisualStyleBackColor = false;
            this.ButtonDWEllipse.Click += new System.EventHandler(this.ButtonDW_Click);
            // 
            // ButtonDWPolygon
            // 
            this.ButtonDWPolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWPolygon.BackgroundImage = global::SimplePaint.Properties.Resources.polygon;
            this.ButtonDWPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDWPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDWPolygon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWPolygon.FlatAppearance.BorderSize = 0;
            this.ButtonDWPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDWPolygon.Location = new System.Drawing.Point(250, 10);
            this.ButtonDWPolygon.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDWPolygon.Name = "ButtonDWPolygon";
            this.ButtonDWPolygon.Size = new System.Drawing.Size(70, 70);
            this.ButtonDWPolygon.TabIndex = 13;
            this.ButtonDWPolygon.Tag = "";
            this.ButtonDWPolygon.UseVisualStyleBackColor = false;
            this.ButtonDWPolygon.Click += new System.EventHandler(this.ButtonDW_Click);
            // 
            // PanelTools
            // 
            this.PanelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.PanelTools.Controls.Add(this.ButtonDWPen);
            this.PanelTools.Controls.Add(this.ButtonDWEraser);
            this.PanelTools.Controls.Add(this.ButtonDWFill);
            this.PanelTools.Controls.Add(this.ButtonDWPipette);
            this.PanelTools.Location = new System.Drawing.Point(5, 305);
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.Padding = new System.Windows.Forms.Padding(5);
            this.PanelTools.Size = new System.Drawing.Size(330, 90);
            this.PanelTools.TabIndex = 1;
            // 
            // ButtonDWPen
            // 
            this.ButtonDWPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWPen.BackgroundImage = global::SimplePaint.Properties.Resources.pen;
            this.ButtonDWPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDWPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDWPen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWPen.FlatAppearance.BorderSize = 0;
            this.ButtonDWPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDWPen.Location = new System.Drawing.Point(10, 10);
            this.ButtonDWPen.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDWPen.Name = "ButtonDWPen";
            this.ButtonDWPen.Size = new System.Drawing.Size(70, 70);
            this.ButtonDWPen.TabIndex = 12;
            this.ButtonDWPen.Tag = "";
            this.ButtonDWPen.UseVisualStyleBackColor = false;
            this.ButtonDWPen.Click += new System.EventHandler(this.ButtonDW_Click);
            // 
            // ButtonDWEraser
            // 
            this.ButtonDWEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWEraser.BackgroundImage = global::SimplePaint.Properties.Resources.eraser;
            this.ButtonDWEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDWEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDWEraser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWEraser.FlatAppearance.BorderSize = 0;
            this.ButtonDWEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDWEraser.Location = new System.Drawing.Point(90, 10);
            this.ButtonDWEraser.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDWEraser.Name = "ButtonDWEraser";
            this.ButtonDWEraser.Size = new System.Drawing.Size(70, 70);
            this.ButtonDWEraser.TabIndex = 8;
            this.ButtonDWEraser.Tag = "";
            this.ButtonDWEraser.UseVisualStyleBackColor = false;
            this.ButtonDWEraser.Click += new System.EventHandler(this.ButtonDW_Click);
            // 
            // ButtonDWFill
            // 
            this.ButtonDWFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWFill.BackgroundImage = global::SimplePaint.Properties.Resources.fill;
            this.ButtonDWFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDWFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDWFill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWFill.FlatAppearance.BorderSize = 0;
            this.ButtonDWFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDWFill.Location = new System.Drawing.Point(170, 10);
            this.ButtonDWFill.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDWFill.Name = "ButtonDWFill";
            this.ButtonDWFill.Size = new System.Drawing.Size(70, 70);
            this.ButtonDWFill.TabIndex = 11;
            this.ButtonDWFill.Tag = "";
            this.ButtonDWFill.UseVisualStyleBackColor = false;
            this.ButtonDWFill.Click += new System.EventHandler(this.ButtonDW_Click);
            // 
            // ButtonDWPipette
            // 
            this.ButtonDWPipette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWPipette.BackgroundImage = global::SimplePaint.Properties.Resources.pipette;
            this.ButtonDWPipette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDWPipette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDWPipette.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonDWPipette.FlatAppearance.BorderSize = 0;
            this.ButtonDWPipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDWPipette.Location = new System.Drawing.Point(250, 10);
            this.ButtonDWPipette.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDWPipette.Name = "ButtonDWPipette";
            this.ButtonDWPipette.Size = new System.Drawing.Size(70, 70);
            this.ButtonDWPipette.TabIndex = 13;
            this.ButtonDWPipette.Tag = "";
            this.ButtonDWPipette.UseVisualStyleBackColor = false;
            this.ButtonDWPipette.Click += new System.EventHandler(this.ButtonDW_Click);
            // 
            // ButtonColor23
            // 
            this.ButtonColor23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonColor23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor23.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor23.FlatAppearance.BorderSize = 0;
            this.ButtonColor23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor23.Location = new System.Drawing.Point(290, 100);
            this.ButtonColor23.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor23.Name = "ButtonColor23";
            this.ButtonColor23.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor23.TabIndex = 45;
            this.ButtonColor23.UseVisualStyleBackColor = false;
            this.ButtonColor23.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor22
            // 
            this.ButtonColor22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ButtonColor22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor22.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor22.FlatAppearance.BorderSize = 0;
            this.ButtonColor22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor22.Location = new System.Drawing.Point(290, 60);
            this.ButtonColor22.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor22.Name = "ButtonColor22";
            this.ButtonColor22.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor22.TabIndex = 44;
            this.ButtonColor22.UseVisualStyleBackColor = false;
            this.ButtonColor22.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // LabelHeight
            // 
            this.LabelHeight.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeight.ForeColor = System.Drawing.Color.White;
            this.LabelHeight.Location = new System.Drawing.Point(175, 620);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(145, 40);
            this.LabelHeight.TabIndex = 43;
            this.LabelHeight.Text = "HEIGHT";
            this.LabelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWidht
            // 
            this.LabelWidht.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidht.ForeColor = System.Drawing.Color.White;
            this.LabelWidht.Location = new System.Drawing.Point(20, 620);
            this.LabelWidht.Name = "LabelWidht";
            this.LabelWidht.Size = new System.Drawing.Size(145, 40);
            this.LabelWidht.TabIndex = 42;
            this.LabelWidht.Text = "WIDHT";
            this.LabelWidht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PenSize
            // 
            this.PenSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.PenSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PenSize.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenSize.ForeColor = System.Drawing.Color.White;
            this.PenSize.Location = new System.Drawing.Point(222, 190);
            this.PenSize.MaxLength = 3;
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(75, 39);
            this.PenSize.TabIndex = 2;
            this.PenSize.Text = "5";
            this.PenSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PenSize.TextChanged += new System.EventHandler(this.PenWidthChanged);
            this.PenSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWriteSize);
            // 
            // CanvaHeight
            // 
            this.CanvaHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.CanvaHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CanvaHeight.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanvaHeight.ForeColor = System.Drawing.Color.White;
            this.CanvaHeight.Location = new System.Drawing.Point(175, 665);
            this.CanvaHeight.Name = "CanvaHeight";
            this.CanvaHeight.Size = new System.Drawing.Size(150, 39);
            this.CanvaHeight.TabIndex = 41;
            this.CanvaHeight.Text = "500";
            this.CanvaHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CanvaHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWriteSize);
            this.CanvaHeight.Leave += new System.EventHandler(this.CanvaSizeChanged);
            // 
            // BrushDown
            // 
            this.BrushDown.BackgroundImage = global::SimplePaint.Properties.Resources.arrow_left;
            this.BrushDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrushDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrushDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.BrushDown.FlatAppearance.BorderSize = 0;
            this.BrushDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrushDown.Location = new System.Drawing.Point(199, 190);
            this.BrushDown.Margin = new System.Windows.Forms.Padding(0);
            this.BrushDown.Name = "BrushDown";
            this.BrushDown.Size = new System.Drawing.Size(20, 39);
            this.BrushDown.TabIndex = 9;
            this.BrushDown.UseVisualStyleBackColor = false;
            this.BrushDown.Click += new System.EventHandler(this.BrushDown_Click);
            // 
            // CanvaWidht
            // 
            this.CanvaWidht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.CanvaWidht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CanvaWidht.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanvaWidht.ForeColor = System.Drawing.Color.White;
            this.CanvaWidht.Location = new System.Drawing.Point(15, 665);
            this.CanvaWidht.Name = "CanvaWidht";
            this.CanvaWidht.Size = new System.Drawing.Size(150, 39);
            this.CanvaWidht.TabIndex = 2;
            this.CanvaWidht.Text = "500";
            this.CanvaWidht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CanvaWidht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWriteSize);
            this.CanvaWidht.Leave += new System.EventHandler(this.CanvaSizeChanged);
            // 
            // BrushUp
            // 
            this.BrushUp.BackgroundImage = global::SimplePaint.Properties.Resources.arrow_right;
            this.BrushUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrushUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrushUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.BrushUp.FlatAppearance.BorderSize = 0;
            this.BrushUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrushUp.Location = new System.Drawing.Point(300, 190);
            this.BrushUp.Margin = new System.Windows.Forms.Padding(0);
            this.BrushUp.Name = "BrushUp";
            this.BrushUp.Size = new System.Drawing.Size(20, 39);
            this.BrushUp.TabIndex = 10;
            this.BrushUp.UseVisualStyleBackColor = false;
            this.BrushUp.Click += new System.EventHandler(this.BrushUp_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.UndoButton.BackgroundImage = global::SimplePaint.Properties.Resources.undo;
            this.UndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UndoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UndoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.UndoButton.FlatAppearance.BorderSize = 0;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Location = new System.Drawing.Point(120, 10);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(100, 40);
            this.UndoButton.TabIndex = 6;
            this.UndoButton.UseVisualStyleBackColor = false;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // LabelShapes
            // 
            this.LabelShapes.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShapes.ForeColor = System.Drawing.Color.White;
            this.LabelShapes.Location = new System.Drawing.Point(0, 430);
            this.LabelShapes.Name = "LabelShapes";
            this.LabelShapes.Size = new System.Drawing.Size(340, 42);
            this.LabelShapes.TabIndex = 40;
            this.LabelShapes.Text = "SHAPES";
            this.LabelShapes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SaveFileButton.BackgroundImage = global::SimplePaint.Properties.Resources.save;
            this.SaveFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SaveFileButton.FlatAppearance.BorderSize = 0;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Location = new System.Drawing.Point(10, 10);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(100, 40);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // ReduButton
            // 
            this.ReduButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ReduButton.BackgroundImage = global::SimplePaint.Properties.Resources.redu;
            this.ReduButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReduButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReduButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ReduButton.FlatAppearance.BorderSize = 0;
            this.ReduButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReduButton.Location = new System.Drawing.Point(230, 10);
            this.ReduButton.Name = "ReduButton";
            this.ReduButton.Size = new System.Drawing.Size(100, 40);
            this.ReduButton.TabIndex = 5;
            this.ReduButton.UseVisualStyleBackColor = false;
            this.ReduButton.Click += new System.EventHandler(this.ReduButton_Click);
            // 
            // LabelTools
            // 
            this.LabelTools.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTools.ForeColor = System.Drawing.Color.White;
            this.LabelTools.Location = new System.Drawing.Point(0, 260);
            this.LabelTools.Name = "LabelTools";
            this.LabelTools.Size = new System.Drawing.Size(340, 42);
            this.LabelTools.TabIndex = 2;
            this.LabelTools.Text = "TOOLS";
            this.LabelTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPicked
            // 
            this.ColorPicked.BackColor = System.Drawing.Color.Black;
            this.ColorPicked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ColorPicked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPicked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ColorPicked.FlatAppearance.BorderSize = 0;
            this.ColorPicked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPicked.Location = new System.Drawing.Point(20, 190);
            this.ColorPicked.Margin = new System.Windows.Forms.Padding(0);
            this.ColorPicked.Name = "ColorPicked";
            this.ColorPicked.Size = new System.Drawing.Size(140, 40);
            this.ColorPicked.TabIndex = 39;
            this.ColorPicked.UseVisualStyleBackColor = false;
            this.ColorPicked.BackColorChanged += new System.EventHandler(this.PenColorChanged);
            this.ColorPicked.Click += new System.EventHandler(this.ColorPicked_Click);
            // 
            // ButtonColor21
            // 
            this.ButtonColor21.BackColor = System.Drawing.Color.Blue;
            this.ButtonColor21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor21.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor21.FlatAppearance.BorderSize = 0;
            this.ButtonColor21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor21.Location = new System.Drawing.Point(250, 140);
            this.ButtonColor21.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor21.Name = "ButtonColor21";
            this.ButtonColor21.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor21.TabIndex = 38;
            this.ButtonColor21.UseVisualStyleBackColor = false;
            this.ButtonColor21.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor18
            // 
            this.ButtonColor18.BackColor = System.Drawing.Color.Aqua;
            this.ButtonColor18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor18.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor18.FlatAppearance.BorderSize = 0;
            this.ButtonColor18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor18.Location = new System.Drawing.Point(210, 140);
            this.ButtonColor18.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor18.Name = "ButtonColor18";
            this.ButtonColor18.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor18.TabIndex = 37;
            this.ButtonColor18.UseVisualStyleBackColor = false;
            this.ButtonColor18.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor15
            // 
            this.ButtonColor15.BackColor = System.Drawing.Color.Lime;
            this.ButtonColor15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor15.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor15.FlatAppearance.BorderSize = 0;
            this.ButtonColor15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor15.Location = new System.Drawing.Point(170, 140);
            this.ButtonColor15.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor15.Name = "ButtonColor15";
            this.ButtonColor15.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor15.TabIndex = 36;
            this.ButtonColor15.UseVisualStyleBackColor = false;
            this.ButtonColor15.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor12
            // 
            this.ButtonColor12.BackColor = System.Drawing.Color.Yellow;
            this.ButtonColor12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor12.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor12.FlatAppearance.BorderSize = 0;
            this.ButtonColor12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor12.Location = new System.Drawing.Point(130, 140);
            this.ButtonColor12.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor12.Name = "ButtonColor12";
            this.ButtonColor12.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor12.TabIndex = 35;
            this.ButtonColor12.UseVisualStyleBackColor = false;
            this.ButtonColor12.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor9
            // 
            this.ButtonColor9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonColor9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor9.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor9.FlatAppearance.BorderSize = 0;
            this.ButtonColor9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor9.Location = new System.Drawing.Point(90, 140);
            this.ButtonColor9.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor9.Name = "ButtonColor9";
            this.ButtonColor9.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor9.TabIndex = 34;
            this.ButtonColor9.UseVisualStyleBackColor = false;
            this.ButtonColor9.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor6
            // 
            this.ButtonColor6.BackColor = System.Drawing.Color.Red;
            this.ButtonColor6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor6.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor6.FlatAppearance.BorderSize = 0;
            this.ButtonColor6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor6.Location = new System.Drawing.Point(50, 140);
            this.ButtonColor6.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor6.Name = "ButtonColor6";
            this.ButtonColor6.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor6.TabIndex = 33;
            this.ButtonColor6.UseVisualStyleBackColor = false;
            this.ButtonColor6.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor3
            // 
            this.ButtonColor3.BackColor = System.Drawing.Color.Black;
            this.ButtonColor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor3.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor3.FlatAppearance.BorderSize = 0;
            this.ButtonColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor3.Location = new System.Drawing.Point(10, 140);
            this.ButtonColor3.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor3.Name = "ButtonColor3";
            this.ButtonColor3.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor3.TabIndex = 32;
            this.ButtonColor3.UseVisualStyleBackColor = false;
            this.ButtonColor3.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor20
            // 
            this.ButtonColor20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonColor20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor20.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor20.FlatAppearance.BorderSize = 0;
            this.ButtonColor20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor20.Location = new System.Drawing.Point(250, 100);
            this.ButtonColor20.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor20.Name = "ButtonColor20";
            this.ButtonColor20.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor20.TabIndex = 31;
            this.ButtonColor20.UseVisualStyleBackColor = false;
            this.ButtonColor20.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor17
            // 
            this.ButtonColor17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonColor17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor17.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor17.FlatAppearance.BorderSize = 0;
            this.ButtonColor17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor17.Location = new System.Drawing.Point(210, 100);
            this.ButtonColor17.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor17.Name = "ButtonColor17";
            this.ButtonColor17.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor17.TabIndex = 30;
            this.ButtonColor17.UseVisualStyleBackColor = false;
            this.ButtonColor17.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor14
            // 
            this.ButtonColor14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonColor14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor14.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor14.FlatAppearance.BorderSize = 0;
            this.ButtonColor14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor14.Location = new System.Drawing.Point(170, 100);
            this.ButtonColor14.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor14.Name = "ButtonColor14";
            this.ButtonColor14.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor14.TabIndex = 29;
            this.ButtonColor14.UseVisualStyleBackColor = false;
            this.ButtonColor14.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor11
            // 
            this.ButtonColor11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonColor11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor11.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor11.FlatAppearance.BorderSize = 0;
            this.ButtonColor11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor11.Location = new System.Drawing.Point(130, 100);
            this.ButtonColor11.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor11.Name = "ButtonColor11";
            this.ButtonColor11.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor11.TabIndex = 28;
            this.ButtonColor11.UseVisualStyleBackColor = false;
            this.ButtonColor11.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor8
            // 
            this.ButtonColor8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonColor8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor8.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor8.FlatAppearance.BorderSize = 0;
            this.ButtonColor8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor8.Location = new System.Drawing.Point(90, 100);
            this.ButtonColor8.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor8.Name = "ButtonColor8";
            this.ButtonColor8.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor8.TabIndex = 27;
            this.ButtonColor8.UseVisualStyleBackColor = false;
            this.ButtonColor8.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor5
            // 
            this.ButtonColor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonColor5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor5.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor5.FlatAppearance.BorderSize = 0;
            this.ButtonColor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor5.Location = new System.Drawing.Point(50, 100);
            this.ButtonColor5.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor5.Name = "ButtonColor5";
            this.ButtonColor5.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor5.TabIndex = 26;
            this.ButtonColor5.UseVisualStyleBackColor = false;
            this.ButtonColor5.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor2
            // 
            this.ButtonColor2.BackColor = System.Drawing.Color.Silver;
            this.ButtonColor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor2.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor2.FlatAppearance.BorderSize = 0;
            this.ButtonColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor2.Location = new System.Drawing.Point(10, 100);
            this.ButtonColor2.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor2.Name = "ButtonColor2";
            this.ButtonColor2.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor2.TabIndex = 25;
            this.ButtonColor2.UseVisualStyleBackColor = false;
            this.ButtonColor2.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor19
            // 
            this.ButtonColor19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ButtonColor19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor19.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor19.FlatAppearance.BorderSize = 0;
            this.ButtonColor19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor19.Location = new System.Drawing.Point(250, 60);
            this.ButtonColor19.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor19.Name = "ButtonColor19";
            this.ButtonColor19.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor19.TabIndex = 24;
            this.ButtonColor19.UseVisualStyleBackColor = false;
            this.ButtonColor19.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor16
            // 
            this.ButtonColor16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonColor16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor16.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor16.FlatAppearance.BorderSize = 0;
            this.ButtonColor16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor16.Location = new System.Drawing.Point(210, 60);
            this.ButtonColor16.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor16.Name = "ButtonColor16";
            this.ButtonColor16.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor16.TabIndex = 23;
            this.ButtonColor16.UseVisualStyleBackColor = false;
            this.ButtonColor16.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor13
            // 
            this.ButtonColor13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonColor13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor13.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor13.FlatAppearance.BorderSize = 0;
            this.ButtonColor13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor13.Location = new System.Drawing.Point(170, 60);
            this.ButtonColor13.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor13.Name = "ButtonColor13";
            this.ButtonColor13.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor13.TabIndex = 22;
            this.ButtonColor13.UseVisualStyleBackColor = false;
            this.ButtonColor13.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor10
            // 
            this.ButtonColor10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonColor10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor10.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor10.FlatAppearance.BorderSize = 0;
            this.ButtonColor10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor10.Location = new System.Drawing.Point(130, 60);
            this.ButtonColor10.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor10.Name = "ButtonColor10";
            this.ButtonColor10.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor10.TabIndex = 21;
            this.ButtonColor10.UseVisualStyleBackColor = false;
            this.ButtonColor10.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor7
            // 
            this.ButtonColor7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ButtonColor7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor7.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor7.FlatAppearance.BorderSize = 0;
            this.ButtonColor7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor7.Location = new System.Drawing.Point(90, 60);
            this.ButtonColor7.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor7.Name = "ButtonColor7";
            this.ButtonColor7.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor7.TabIndex = 20;
            this.ButtonColor7.UseVisualStyleBackColor = false;
            this.ButtonColor7.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor4
            // 
            this.ButtonColor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonColor4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor4.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor4.FlatAppearance.BorderSize = 0;
            this.ButtonColor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor4.Location = new System.Drawing.Point(50, 60);
            this.ButtonColor4.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor4.Name = "ButtonColor4";
            this.ButtonColor4.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor4.TabIndex = 19;
            this.ButtonColor4.UseVisualStyleBackColor = false;
            this.ButtonColor4.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColor1
            // 
            this.ButtonColor1.BackColor = System.Drawing.Color.White;
            this.ButtonColor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonColor1.ContextMenuStrip = this.ContextMenuStripColorFill;
            this.ButtonColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonColor1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ButtonColor1.FlatAppearance.BorderSize = 0;
            this.ButtonColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColor1.Location = new System.Drawing.Point(10, 60);
            this.ButtonColor1.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonColor1.Name = "ButtonColor1";
            this.ButtonColor1.Size = new System.Drawing.Size(40, 40);
            this.ButtonColor1.TabIndex = 18;
            this.ButtonColor1.UseVisualStyleBackColor = false;
            this.ButtonColor1.Click += new System.EventHandler(this.ButtonColor_Click);
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
            this.PanelCanva.Controls.Add(this.PanelCanvaScroll);
            this.PanelCanva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCanva.Location = new System.Drawing.Point(340, 40);
            this.PanelCanva.Name = "PanelCanva";
            this.PanelCanva.Padding = new System.Windows.Forms.Padding(20);
            this.PanelCanva.Size = new System.Drawing.Size(1154, 854);
            this.PanelCanva.TabIndex = 1;
            // 
            // PanelCanvaScroll
            // 
            this.PanelCanvaScroll.AutoScroll = true;
            this.PanelCanvaScroll.Controls.Add(this.Canva);
            this.PanelCanvaScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCanvaScroll.Location = new System.Drawing.Point(20, 20);
            this.PanelCanvaScroll.Name = "PanelCanvaScroll";
            this.PanelCanvaScroll.Padding = new System.Windows.Forms.Padding(20);
            this.PanelCanvaScroll.Size = new System.Drawing.Size(1114, 814);
            this.PanelCanvaScroll.TabIndex = 2;
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.Color.White;
            this.Canva.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canva.Location = new System.Drawing.Point(0, 0);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(100, 100);
            this.Canva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canva.TabIndex = 0;
            this.Canva.TabStop = false;
            this.Canva.Paint += new System.Windows.Forms.PaintEventHandler(this.Canva_Paint);
            this.Canva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseClick);
            this.Canva.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseDoubleClick);
            this.Canva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseDown);
            this.Canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseMove);
            this.Canva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseUp);
            // 
            // ColorDialog
            // 
            this.ColorDialog.FullOpen = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.ClientArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.ChromPanel.ResumeLayout(false);
            this.ChromPanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            this.ContextMenuStripColorFill.ResumeLayout(false);
            this.PanelShapes.ResumeLayout(false);
            this.PanelTools.ResumeLayout(false);
            this.ClientArea.ResumeLayout(false);
            this.PanelCanva.ResumeLayout(false);
            this.PanelCanvaScroll.ResumeLayout(false);
            this.PanelCanvaScroll.PerformLayout();
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
        private System.Windows.Forms.Button ButtonColor21;
        private System.Windows.Forms.Button ButtonColor18;
        private System.Windows.Forms.Button ButtonColor15;
        private System.Windows.Forms.Button ButtonColor12;
        private System.Windows.Forms.Button ButtonColor9;
        private System.Windows.Forms.Button ButtonColor6;
        private System.Windows.Forms.Button ButtonColor3;
        private System.Windows.Forms.Button ButtonColor20;
        private System.Windows.Forms.Button ButtonColor17;
        private System.Windows.Forms.Button ButtonColor14;
        private System.Windows.Forms.Button ButtonColor11;
        private System.Windows.Forms.Button ButtonColor8;
        private System.Windows.Forms.Button ButtonColor5;
        private System.Windows.Forms.Button ButtonColor2;
        private System.Windows.Forms.Button ButtonColor19;
        private System.Windows.Forms.Button ButtonColor16;
        private System.Windows.Forms.Button ButtonColor13;
        private System.Windows.Forms.Button ButtonColor10;
        private System.Windows.Forms.Button ButtonColor7;
        private System.Windows.Forms.Button ButtonColor4;
        private System.Windows.Forms.Button ButtonColor1;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button ReduButton;
        private System.Windows.Forms.Button BrushUp;
        private System.Windows.Forms.TextBox PenSize;
        private System.Windows.Forms.Button BrushDown;
        private System.Windows.Forms.Button ButtonDWEraser;
        private System.Windows.Forms.Panel ClientArea;
        private System.Windows.Forms.Button ColorPicked;
        private System.Windows.Forms.Label LabelShapes;
        private System.Windows.Forms.Label LabelTools;
        private System.Windows.Forms.TextBox CanvaWidht;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.Label LabelWidht;
        private System.Windows.Forms.TextBox CanvaHeight;
        private System.Windows.Forms.Panel PanelCanvaScroll;
        private System.Windows.Forms.PictureBox Canva;
        private System.Windows.Forms.Panel PanelCanva;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button ButtonDWPen;
        private System.Windows.Forms.Button ButtonDWFill;
        private System.Windows.Forms.FlowLayoutPanel PanelTools;
        private System.Windows.Forms.Button ButtonColor24;
        private System.Windows.Forms.Button ButtonColor23;
        private System.Windows.Forms.Button ButtonColor22;
        private System.Windows.Forms.Button ButtonDWPipette;
        private System.Windows.Forms.FlowLayoutPanel PanelShapes;
        private System.Windows.Forms.Button ButtonDWLine;
        private System.Windows.Forms.Button ButtonDWRectangle;
        private System.Windows.Forms.Button ButtonDWEllipse;
        private System.Windows.Forms.Button ButtonDWPolygon;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripColorFill;
        private System.Windows.Forms.ToolStripMenuItem fillUpToolStripMenuItem;
    }
}

