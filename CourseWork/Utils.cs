using System;
using OpenTK.Graphics.OpenGL;
using System.IO;
using System.Reflection;

namespace Utils
{
    public class ShaderLoader
    {
        public static bool InitShaders(string vShaderSource, string fShaderSource, out int program)
        {
            program = CreateProgram(vShaderSource, fShaderSource);
            if (program == 0)
            {
                Logger.Append("Failed to create program");
                return false;
            }

            GL.UseProgram(program);

            return true;
        }

        public static void UpdateUniforms(int program, int W, int H)
        {
            int timeLocation = GL.GetUniformLocation(program, "iTime");
            GL.Uniform1(timeLocation, (int)DateTime.Now.Ticks);

            int resLocation = GL.GetUniformLocation(program, "iResolution");
            GL.Uniform2(resLocation, (float)W, (float)H);
        }

        private static int CreateProgram(string vShader, string fShader)
        {
            int vertexShader = LoadShader(ShaderType.VertexShader, vShader);
            int fragmentShader = LoadShader(ShaderType.FragmentShader, fShader);

            if (vertexShader == 0 || fragmentShader == 0)
                return 0;

            int program = GL.CreateProgram();

            if (program == 0)
                return 0;

            GL.AttachShader(program, vertexShader);
            GL.AttachShader(program, fragmentShader);

            GL.LinkProgram(program);

            GL.GetProgram(program, GetProgramParameterName.LinkStatus, out int status);
            if (status == 0)
            {
                string errorString = string.Format("Failed to link program: {0}" + Environment.NewLine, GL.GetProgramInfoLog(program));
                Logger.Append(errorString);
                GL.DeleteProgram(program);
                GL.DeleteShader(vertexShader);
                GL.DeleteShader(fragmentShader);
                return 0;
            }

            return program;
        }

        private static int LoadShader(ShaderType shaderType, string shaderSource)
        {
            int shader = GL.CreateShader(shaderType);
            if (shader == 0)
            {
                Logger.Append("Unable to create shader");
                return 0;
            }

            GL.ShaderSource(shader, shaderSource);

            GL.CompileShader(shader);

            int status;
            GL.GetShader(shader, ShaderParameter.CompileStatus, out status);
            if (status == 0)
            {
                string errorString = string.Format("Failed to compile {0} shader: {1}", shaderType.ToString(), GL.GetShaderInfoLog(shader));
                Logger.Append(errorString);
                GL.DeleteShader(shader);
                return 0;
            }

            return shader;
        }
    }

    public class Logger
    {
        private static string _log = "";

        public static void Append(string message)
        {
            _log += message + Environment.NewLine;
        }

        public static void ClearLog()
        {
            _log = "";
        }

        public static string GetLog()
        {
            return _log;
        }
    }
}