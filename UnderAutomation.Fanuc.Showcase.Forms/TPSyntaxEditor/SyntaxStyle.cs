﻿using System.Drawing;

namespace UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor
{
    public class SyntaxStyle
    {
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public Color Color { get; set; }

        public SyntaxStyle(Color color, bool bold, bool italic)
        {
            Color = color;
            Bold = bold;
            Italic = italic;
        }

        public SyntaxStyle(Color color)
            : this(color, false, false)
        {
        }
    }
}
