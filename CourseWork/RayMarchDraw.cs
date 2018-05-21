using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK.Graphics.OpenGL;
using Utils;

namespace CourseWork
{
    class RayMarchDraw
    {
        private bool canDraw = false;
        private int program;
        private int nVertices;

        public RayMarchDraw()
        {
        }

        public string GetSimpleMap()
        {
            return Properties.Resources.SimpleOfMap;
        }

        private int InitVertexBuffers()
        {
            float[] vertices = new float[] { 1f, 1f, -1f, 1f, -1f, -1f, 1f, 1f, -1f, -1f, 1f, -1f };

            GL.GenBuffers(1, out int vertexBuffer);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vertexBuffer);

            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

            int a_Position = GL.GetAttribLocation(program, "a_Position");
            if (a_Position < 0)
            {
                Logger.Append("Failed to get the storage location of a_Position");
                return -1;
            }

            GL.VertexAttribPointer(a_Position, 2, VertexAttribPointerType.Float, false, 0, 0);

            GL.EnableVertexAttribArray(a_Position);
            return vertices.Length / 2;
        }

        public void Compile(string renderCode, OpenTK.GLControl control)
        {
            Logger.ClearLog();

            string vShaderSource = Properties.Resources.VertexShader;
            string fShaderBegin = Properties.Resources.RayMarchBegin;
            string fShaderEnd = Properties.Resources.RayMarchMain;

            string fShaderSource = fShaderBegin + Environment.NewLine + renderCode + Environment.NewLine + fShaderEnd;

            if (vShaderSource == null)
            {
                Logger.Append("Failed load shaders from files");
                return;
            }

            if (!ShaderLoader.InitShaders(vShaderSource, fShaderSource, out program))
            {
                Logger.Append("Failed to initialize the shaders");
                return;
            }

            ShaderLoader.UpdateUniforms(program, control.Width, control.Height);

            nVertices = InitVertexBuffers();
            if (nVertices <= 0)
            {
                Logger.Append("Failed to write the positions of vertices to a vertex shader");
                return;
            }

            GL.ClearColor(Color.DarkSlateBlue);
            canDraw = true;
        }

        public void Paint(OpenTK.GLControl control)
        {
            GL.Viewport(0, 0, control.Width, control.Height);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            ShaderLoader.UpdateUniforms(program, control.Width, control.Height);

            if (canDraw)
            {
                GL.DrawArrays(PrimitiveType.Triangles, 0, nVertices);
            }

            GL.Flush();
            control.SwapBuffers();
        }
    }
}
