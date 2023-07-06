/// <summary>
/// A class for holding an openGL unit cube properties
/// </summary>
namespace LearnOpenTK
{
    public class Cube
    {
        private readonly float[] _vertices =
{
            // Position         Texture coordinates
             0.5f,  0.5f, -0.5f, 1.0f, 1.0f,    // top right front             (0)
             0.5f, -0.5f, -0.5f, 1.0f, 0.0f,    // bottom right front          (1)
            -0.5f, -0.5f, -0.5f, 0.0f, 0.0f,    // bottom left front           (2)
            -0.5f,  0.5f, -0.5f, 0.0f, 1.0f,    // top left front              (3)

             0.5f,  0.5f, 0.5f, 1.0f, 1.0f,     // top right back               (4)
             0.5f, -0.5f, 0.5f, 1.0f, 0.0f,     // bottom right back            (5)
            -0.5f, -0.5f, 0.5f, 0.0f, 0.0f,     // bottom left back             (6)
            -0.5f,  0.5f, 0.5f, 0.0f, 1.0f      // top left back                (7)
        };

        private readonly uint[] _indices =
        {
            0, 1, 3,    // front
            1, 2, 3,    // front

            4, 5, 7,    // back
            5, 6, 7,    // back

            7, 6, 0,    // right
            6, 1, 0,    // right

            3, 0, 4,     // left
            0, 5, 4,     // left

            7, 5, 4,     // top
            0, 3, 4,     // top

            1, 6, 2,     // bottom
            6, 5, 2,     // bottom
        };
    }
}
