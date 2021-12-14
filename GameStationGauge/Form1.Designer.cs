
namespace GameStationGauge
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TemperatureLabel = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2VProgressBar1 = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.siToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.cada1SegundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cada3SegundosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cada5SegundosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cada10SegundosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cada30SegundosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 20;
            this.Form_Elipse.TargetControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 98);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salirToolStripMenuItem.Text = "Transparencia";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "100%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "75%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "50%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "25%";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TemperatureLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(45, 0);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(110, 138);
            this.TemperatureLabel.TabIndex = 6;
            this.TemperatureLabel.Text = "Temperature:\r\n10°c";
            this.TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2VProgressBar1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::GameStationGauge.Properties.Resources.left_48px;
            this.guna2PictureBox1.Location = new System.Drawing.Point(30, -2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(25, 20);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2VProgressBar1
            // 
            this.guna2VProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2VProgressBar1.BackgroundImage = global::GameStationGauge.Properties.Resources.image__1_;
            this.guna2VProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2VProgressBar1.ContextMenuStrip = this.contextMenuStrip1;
            this.guna2VProgressBar1.FillColor = System.Drawing.Color.Empty;
            this.guna2VProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2VProgressBar1.Location = new System.Drawing.Point(1, 1);
            this.guna2VProgressBar1.Maximum = 200;
            this.guna2VProgressBar1.Name = "guna2VProgressBar1";
            this.guna2VProgressBar1.ProgressColor = System.Drawing.Color.Black;
            this.guna2VProgressBar1.ProgressColor2 = System.Drawing.Color.Empty;
            this.guna2VProgressBar1.ShadowDecoration.Parent = this.guna2VProgressBar1;
            this.guna2VProgressBar1.Size = new System.Drawing.Size(41, 134);
            this.guna2VProgressBar1.TabIndex = 7;
            this.guna2VProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siToolStripMenuItem,
            this.noToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem1.Text = "Siempre al frente";
            // 
            // siToolStripMenuItem
            // 
            this.siToolStripMenuItem.Name = "siToolStripMenuItem";
            this.siToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siToolStripMenuItem.Text = "Si";
            this.siToolStripMenuItem.Click += new System.EventHandler(this.siToolStripMenuItem_Click);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cada1SegundoToolStripMenuItem,
            this.cada3SegundosToolStripMenuItem,
            this.cada5SegundosToolStripMenuItem,
            this.cada10SegundosToolStripMenuItem,
            this.cada30SegundosToolStripMenuItem});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem7.Text = "Tasa de actualización";
            // 
            // cada1SegundoToolStripMenuItem
            // 
            this.cada1SegundoToolStripMenuItem.Name = "cada1SegundoToolStripMenuItem";
            this.cada1SegundoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cada1SegundoToolStripMenuItem.Text = "Cada 1 segundo";
            this.cada1SegundoToolStripMenuItem.Click += new System.EventHandler(this.cada1SegundoToolStripMenuItem_Click);
            // 
            // cada3SegundosToolStripMenuItem
            // 
            this.cada3SegundosToolStripMenuItem.Name = "cada3SegundosToolStripMenuItem";
            this.cada3SegundosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cada3SegundosToolStripMenuItem.Text = "Cada 3 segundos";
            this.cada3SegundosToolStripMenuItem.Click += new System.EventHandler(this.cada3SegundosToolStripMenuItem_Click);
            // 
            // cada5SegundosToolStripMenuItem
            // 
            this.cada5SegundosToolStripMenuItem.Name = "cada5SegundosToolStripMenuItem";
            this.cada5SegundosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cada5SegundosToolStripMenuItem.Text = "Cada 5 segundos";
            this.cada5SegundosToolStripMenuItem.Click += new System.EventHandler(this.cada5SegundosToolStripMenuItem_Click);
            // 
            // cada10SegundosToolStripMenuItem
            // 
            this.cada10SegundosToolStripMenuItem.Name = "cada10SegundosToolStripMenuItem";
            this.cada10SegundosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cada10SegundosToolStripMenuItem.Text = "Cada 10 segundos";
            this.cada10SegundosToolStripMenuItem.Click += new System.EventHandler(this.cada10SegundosToolStripMenuItem_Click);
            // 
            // cada30SegundosToolStripMenuItem
            // 
            this.cada30SegundosToolStripMenuItem.Name = "cada30SegundosToolStripMenuItem";
            this.cada30SegundosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cada30SegundosToolStripMenuItem.Text = "cada 30 segundos";
            this.cada30SegundosToolStripMenuItem.Click += new System.EventHandler(this.cada30SegundosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(155, 138);
            this.ControlBox = false;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2VProgressBar1);
            this.Controls.Add(this.TemperatureLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI.WinForms.GunaLabel TemperatureLabel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2VProgressBar1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem siToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem cada1SegundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cada3SegundosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cada5SegundosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cada10SegundosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cada30SegundosToolStripMenuItem;
    }
}

