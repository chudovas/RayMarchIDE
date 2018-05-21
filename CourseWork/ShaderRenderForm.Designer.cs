namespace CourseWork
{
    partial class ShaderRenderForm
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
            this.codeRichBox = new SyntaxHighlighter.SyntaxRichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileAndRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpBox = new System.Windows.Forms.TextBox();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.renderCanvas = new OpenTK.GLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeRichBox
            // 
            this.codeRichBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.codeRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeRichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeRichBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeRichBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.codeRichBox.Location = new System.Drawing.Point(490, 3);
            this.codeRichBox.Name = "codeRichBox";
            this.layoutPanel.SetRowSpan(this.codeRichBox, 2);
            this.codeRichBox.Size = new System.Drawing.Size(667, 686);
            this.codeRichBox.TabIndex = 0;
            this.codeRichBox.Text = "";
            this.codeRichBox.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.runToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileAndRunToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // compileAndRunToolStripMenuItem
            // 
            this.compileAndRunToolStripMenuItem.Name = "compileAndRunToolStripMenuItem";
            this.compileAndRunToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.compileAndRunToolStripMenuItem.Text = "Compile and run";
            this.compileAndRunToolStripMenuItem.Click += new System.EventHandler(this.compileAndRunToolStripMenuItem_Click);
            // 
            // helpBox
            // 
            this.helpBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpBox.Location = new System.Drawing.Point(3, 483);
            this.helpBox.Multiline = true;
            this.helpBox.Name = "helpBox";
            this.helpBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.helpBox.Size = new System.Drawing.Size(481, 206);
            this.helpBox.TabIndex = 3;
            this.helpBox.Text = "Help:\\n* * *";
            this.helpBox.WordWrap = false;
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.98944F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.01056F));
            this.layoutPanel.Controls.Add(this.renderCanvas, 0, 0);
            this.layoutPanel.Controls.Add(this.helpBox, 0, 1);
            this.layoutPanel.Controls.Add(this.codeRichBox, 1, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 33);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 2;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.50867F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.49133F));
            this.layoutPanel.Size = new System.Drawing.Size(1160, 692);
            this.layoutPanel.TabIndex = 5;
            // 
            // renderCanvas
            // 
            this.renderCanvas.BackColor = System.Drawing.Color.Black;
            this.renderCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderCanvas.Location = new System.Drawing.Point(4, 5);
            this.renderCanvas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renderCanvas.Name = "renderCanvas";
            this.renderCanvas.Size = new System.Drawing.Size(479, 470);
            this.renderCanvas.TabIndex = 4;
            this.renderCanvas.VSync = false;
            this.renderCanvas.Load += new System.EventHandler(this.renderCanvas_Load);
            this.renderCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.renderCanvas_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // ShaderRenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 725);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShaderRenderForm";
            this.Text = "ShaderRenderForm";
            this.Load += new System.EventHandler(this.ShaderRenderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SyntaxHighlighter.SyntaxRichTextBox codeRichBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.TextBox helpBox;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private OpenTK.GLControl renderCanvas;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileAndRunToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}