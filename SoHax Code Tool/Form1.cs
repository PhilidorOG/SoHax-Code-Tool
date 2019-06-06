using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;
using ICSharpCode.TextEditor.Actions;
using System.IO;

namespace SoHax_Code_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openACodeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openMyFile();
        }

        public void openMyFile()
        {
            Stream stream = null;
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Code Doc (*.cd)|*.cd|Text Doc (*.txt)|*.txt|SoHax File (*.sh)|*.sh",
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stream = dialog.OpenFile();
                    if (stream != null)
                    {
                        this.CodeEditor.LoadFile(dialog.FileName);
                        string startupPath = Application.StartupPath;
                        if (Directory.Exists(startupPath))
                        {
                            FileSyntaxModeProvider syntaxModeFileProvider = new FileSyntaxModeProvider(startupPath);
                            HighlightingManager.Manager.AddSyntaxModeFileProvider(syntaxModeFileProvider);
                            this.CodeEditor.SetHighlighting("GSC");
                        }
                        using (stream)
                        {
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message ?? "");
                }
            }
        }

        private void CodeEditor_Load(object sender, EventArgs e)
        {

        }

        private void saveACodeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CodeEditor.Text == "")
            {
                MessageBox.Show("{Error} Code Editor is blank, Please Fix This.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (this.CodeEditor.Text != "")
            {
                this.saveMyFile();
            }
        }

        public void saveMyFile()
        {

            SaveFileDialog dialog = new SaveFileDialog();
            try
            {
                this.saveFileDialog1.Filter = "Code Doc (*.cd)|*.cd|Text Doc (*.txt)|*.txt|SoHax File (*.sh)|*.sh";
                this.saveFileDialog1.Title = "Save your New Code xD";
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(this.saveFileDialog1.FileName, this.CodeEditor.Text);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                if (dialog != null)
                {
                    dialog.Dispose();
                }
            }
        }

        private void openAGSCFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openMyGSC();
        }

        public void openMyGSC()
        {
            Stream stream = null;
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "RawFile(*.gsc)|*.gsc",
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stream = dialog.OpenFile();
                    if (stream != null)
                    {
                        this.CodeEditor.LoadFile(dialog.FileName);
                        string startupPath = Application.StartupPath;
                        if (Directory.Exists(startupPath))
                        {
                            FileSyntaxModeProvider syntaxModeFileProvider = new FileSyntaxModeProvider(startupPath);
                            HighlightingManager.Manager.AddSyntaxModeFileProvider(syntaxModeFileProvider);
                            this.CodeEditor.SetHighlighting("GSC");
                        }
                        using (stream)
                        {
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message ?? "");
                }
            }
        }
        

        private void saveAGSCFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CodeEditor.Text == "")
            {
                MessageBox.Show("{Error} Code Editor is blank, Please Fix This.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (this.CodeEditor.Text != "")
            {
                this.saveMyGSC();
            }
        }

        public void saveMyGSC()
        {

            SaveFileDialog dialog = new SaveFileDialog();
            try
            {
                this.saveFileDialog1.Filter = "RawFile(*.gsc)|*.gsc";
                this.saveFileDialog1.Title = "Save your RawFile";
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(this.saveFileDialog1.FileName, this.CodeEditor.Text);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                if (dialog != null)
                {
                    dialog.Dispose();
                }
            }

        }

        private void exitToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void optimizeCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CodeEditor.Text == "")
            {
                MessageBox.Show("{Error} Code Editor is blank, Please Fix This.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (this.CodeEditor.Text != null)
            {
                string str = this.CodeEditor.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
                this.CodeEditor.Text = str;
                MessageBox.Show("Code Optimized Successfully xD", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.CodeEditor.Refresh();
            }
        }

        private void deOptimizeCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CodeEditor.Text == "")
            {
                MessageBox.Show("{Error} Code Editor is blank, Please Fix This.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (this.CodeEditor.Text != null)
            {
                string str = this.CodeEditor.Text.Replace("{", "\r\n {\r\n").Replace("}", " }\r\n").Replace("(;;)", "(;;)\r\n").Replace(");", ");\r\n");
                this.CodeEditor.Text = str;
                MessageBox.Show("Code De-Optimized Successfully xD", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.CodeEditor.Refresh();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SoHax's Code Tool \nCreated by: SoHax \nBuild: 1.0.0", "About");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeEditor.Undo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }


    }
}
