using System.Drawing;

namespace SimpleDrawer
{
    public class HoleInfo
    {
        public float holeXCoordinate { get; set; }
        public float holeYCoordinate { get; set; }
        public float holeDiameter { get; set; }
        public float holeXEscape { get; set; }
        public float holeYEscape { get; set; }
        public Color holeColor { get; set; }

        public HoleInfo(float holeXCoordinate, float holeYCoordinate, float holeDiameter, float holeXEscape, float holeYEscape, Color holeColor)
        {
            this.holeXCoordinate = holeXCoordinate;
            this.holeYCoordinate = holeYCoordinate;
            this.holeDiameter = holeDiameter;
            this.holeXEscape = holeXEscape;
            this.holeYEscape = holeYEscape;
            this.holeColor = holeColor;
        }
    }
}