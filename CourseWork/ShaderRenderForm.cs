using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using OpenTK.Graphics.OpenGL;
using Utils;

namespace CourseWork
{
    public partial class ShaderRenderForm : Form
    {
        private RayMarchDraw rayMarch;

        private string[] keyWordsArr =
        {
            "if", "else", "for", "while",
            "bool", "int", "float", "double"
        };
        public ShaderRenderForm()
        {
            InitializeComponent();
            rayMarch = new RayMarchDraw();
            codeRichBox.Text = rayMarch.GetSimpleMap();
            codeRichBox.ProcessAllLines();
        }

        public ShaderRenderForm(string code)
        {
            InitializeComponent();
            rayMarch = new RayMarchDraw();

            codeRichBox.Text = code;
            codeRichBox.ProcessAllLines();
            codeRichBox.Update();
        }

        private void ShaderRenderForm_Load(object sender, EventArgs e)
        {
            foreach (string w in keyWordsArr)
                codeRichBox.Settings.Keywords.Add(w);

            codeRichBox.Settings.Comment = "//";

            codeRichBox.Settings.KeywordColor = Color.DarkBlue;
            codeRichBox.Settings.CommentColor = Color.DarkGreen;
            codeRichBox.Settings.StringColor = Color.Maroon;
            codeRichBox.Settings.IntegerColor = Color.SaddleBrown;

            codeRichBox.Settings.EnableStrings = true;
            codeRichBox.Settings.EnableIntegers = true;

            codeRichBox.CompileKeywords();
            codeRichBox.ProcessAllLines();
            codeRichBox.Update();
        }

        private void renderCanvas_Load(object sender, EventArgs e)
        {
        }

        private void renderCanvas_Paint(object sender, PaintEventArgs e)
        {
            rayMarch.Paint(renderCanvas);
            helpBox.Text = Logger.GetLog();
        }

        private void compileAndRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rayMarch.Compile(codeRichBox.Text, renderCanvas);    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            renderCanvas_Paint(sender, null);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "glsl files (*.glsl)|*.glsl",
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFile.FileName, codeRichBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFile = new OpenFileDialog
            {
                Filter = "glsl files (*.glsl)|*.glsl",
            };

            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader reader = new StreamReader(loadFile.FileName);
                    codeRichBox.Text = reader.ReadToEnd();
                    codeRichBox.ProcessAllLines();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
            }
        }
    }
}
