using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ShaderListForm : Form
    {
        public ShaderListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("shaders"))
            {
                DirectoryInfo info = new DirectoryInfo("shaders");
                foreach (var shader in info.GetFiles("*.hlsl"))
                {
                    try
                    {
                        ListViewItem item = new ListViewItem
                        {
                            Name = shader.Name,
                            Text = Path.GetFileNameWithoutExtension(shader.Name),
                            ImageIndex = 0
                        };
                        
                        using (StreamReader sr = new StreamReader(shader.FullName))
                            item.Tag = sr.ReadToEnd();
                        shadersList.Items.Add(item);
                    }
                    catch
                    { }
                }
            }
            else
                Directory.CreateDirectory("shaders");
        }

        private void shadersList_DoubleClick(object sender, EventArgs e)
        {
            if (shadersList.SelectedItems.Count == 0)
                return;
            ShaderRenderForm renderForm = new ShaderRenderForm((string)shadersList.SelectedItems[0].Tag);
            renderForm.Show();
        }
    }
}
