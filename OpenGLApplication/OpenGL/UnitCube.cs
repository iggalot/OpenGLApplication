using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Windowing.Desktop;

/// <summary>
/// A class for holding an openGL unit cube properties
/// </summary>
namespace OpenGLProject
{
    public class Cube
    {
        // Base unit cube centered at 0,0,0
        public readonly float[] _vertices =
{
            // Position         Texture coordinates
             0.5f,  0.5f, 0.5f, 1.0f, 1.0f,    // top right front             (0)
             0.5f, -0.5f, 0.5f, 1.0f, 0.0f,    // bottom right front          (1)
            -0.5f, -0.5f, 0.5f, 0.0f, 0.0f,    // bottom left front           (2)
            -0.5f,  0.5f, 0.5f, 0.0f, 1.0f,    // top left front              (3)

             0.5f,  0.5f, -0.5f, 1.0f, 1.0f,     // top right back               (4)
             0.5f, -0.5f, -0.5f, 1.0f, 0.0f,     // bottom right back            (5)
            -0.5f, -0.5f, -0.5f, 0.0f, 0.0f,     // bottom left back             (6)
            -0.5f,  0.5f, -0.5f, 0.0f, 1.0f      // top left back                (7)
        };

        public readonly uint[] _indices =
        {
            0, 1, 3,    // front
            1, 2, 3,    // front

            4, 5, 0,    // right
            5, 1, 0,    // right

            7, 6, 4,    // back
            6, 5, 4,    // back

            3, 2, 7,     // left
            2, 6, 7,     // left

            4, 0, 7,     // top
            0, 3, 7,     // top

            1, 5, 2,     // bottom
            5, 6, 2,     // bottom
        };

        public int _elementBufferObject;

        public int _vertexBufferObject;

        public int _vertexArrayObject;

        public Shader _shader;

        public Texture _texture;

        public Texture _texture2;

        /// <summary>
        /// Constructor for a generic unit cube
        /// </summary>
        /// <param name="x">x-coord insertion point at middle of cube</param>
        /// <param name="y">y-coord insertion point at middle of cube</param>
        /// <param name="z">x-coord insertion point at middle of cube</param>
        public Cube(float x, float y, float z, float scale_x=1.0f, float scale_y=1.0f, float scale_z=1.0f)
        {
            for (int i = 0; i < 8; i++)
            {
                _vertices[5 * i + 0] = (_vertices[5 * i + 0] * scale_x + x);                        // shift all vertices by x distance
                _vertices[5 * i + 1] = (_vertices[5 * i + 1] * scale_y + y);                // shift all vertices by y distance
                _vertices[5 * i + 2] = (_vertices[5 * i + 2] * scale_z + z);                // shift all vertices by z distance
            }
        }
    }
}
