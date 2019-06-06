namespace SoHax_Code_Tool
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openACodeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveACodeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openAGSCFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAGSCFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimizeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deOptimizeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOptionsToolStripMenuItem,
            this.codeToolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileOptionsToolStripMenuItem
            // 
            this.fileOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openACodeFileToolStripMenuItem,
            this.saveACodeFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.openAGSCFileToolStripMenuItem,
            this.saveAGSCFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolToolStripMenuItem});
            this.fileOptionsToolStripMenuItem.Name = "fileOptionsToolStripMenuItem";
            this.fileOptionsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.fileOptionsToolStripMenuItem.Text = "File Options";
            // 
            // openACodeFileToolStripMenuItem
            // 
            this.openACodeFileToolStripMenuItem.Name = "openACodeFileToolStripMenuItem";
            this.openACodeFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openACodeFileToolStripMenuItem.Text = "Open a Code File";
            this.openACodeFileToolStripMenuItem.Click += new System.EventHandler(this.openACodeFileToolStripMenuItem_Click);
            // 
            // saveACodeFileToolStripMenuItem
            // 
            this.saveACodeFileToolStripMenuItem.Name = "saveACodeFileToolStripMenuItem";
            this.saveACodeFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveACodeFileToolStripMenuItem.Text = "Save a Code File";
            this.saveACodeFileToolStripMenuItem.Click += new System.EventHandler(this.saveACodeFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // openAGSCFileToolStripMenuItem
            // 
            this.openAGSCFileToolStripMenuItem.Name = "openAGSCFileToolStripMenuItem";
            this.openAGSCFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAGSCFileToolStripMenuItem.Text = "Open a GSC File";
            this.openAGSCFileToolStripMenuItem.Click += new System.EventHandler(this.openAGSCFileToolStripMenuItem_Click);
            // 
            // saveAGSCFileToolStripMenuItem
            // 
            this.saveAGSCFileToolStripMenuItem.Name = "saveAGSCFileToolStripMenuItem";
            this.saveAGSCFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAGSCFileToolStripMenuItem.Text = "Save a GSC File";
            this.saveAGSCFileToolStripMenuItem.Click += new System.EventHandler(this.saveAGSCFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolToolStripMenuItem
            // 
            this.exitToolToolStripMenuItem.Name = "exitToolToolStripMenuItem";
            this.exitToolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolToolStripMenuItem.Text = "Exit Tool";
            this.exitToolToolStripMenuItem.Click += new System.EventHandler(this.exitToolToolStripMenuItem_Click);
            // 
            // codeToolsToolStripMenuItem
            // 
            this.codeToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optimizeCodeToolStripMenuItem,
            this.deOptimizeCodeToolStripMenuItem});
            this.codeToolsToolStripMenuItem.Name = "codeToolsToolStripMenuItem";
            this.codeToolsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.codeToolsToolStripMenuItem.Text = "Code Tools";
            // 
            // optimizeCodeToolStripMenuItem
            // 
            this.optimizeCodeToolStripMenuItem.Name = "optimizeCodeToolStripMenuItem";
            this.optimizeCodeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.optimizeCodeToolStripMenuItem.Text = "Optimize Code";
            this.optimizeCodeToolStripMenuItem.Click += new System.EventHandler(this.optimizeCodeToolStripMenuItem_Click);
            // 
            // deOptimizeCodeToolStripMenuItem
            // 
            this.deOptimizeCodeToolStripMenuItem.Name = "deOptimizeCodeToolStripMenuItem";
            this.deOptimizeCodeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deOptimizeCodeToolStripMenuItem.Text = "De-Optimize Code";
            this.deOptimizeCodeToolStripMenuItem.Click += new System.EventHandler(this.deOptimizeCodeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel1.Text = "Copyright 2012 || SoHax";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.toolStripSeparator3,
            this.undoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 98);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(100, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(383, 504);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(226, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.youtube.com/user/consolelobbies";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Drop a Sub Here:";
            // 
            // CodeEditor
            // 
            this.CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeEditor.IsReadOnly = false;
            this.CodeEditor.Location = new System.Drawing.Point(0, 24);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.Size = new System.Drawing.Size(1028, 477);
            this.CodeEditor.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1028, 523);
            this.Controls.Add(this.CodeEditor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SoHax\'s Code Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openACodeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveACodeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openAGSCFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAGSCFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem codeToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optimizeCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deOptimizeCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private ICSharpCode.TextEditor.TextEditorControl CodeEditor;
    }
}

