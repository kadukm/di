﻿using System.Drawing;
using System.Drawing.Imaging;

namespace TagCloud.Core.Settings
{
    public class VisualizingSettings : ISettings
    {
        public int Width { get; set; } = 800;
        public int Height { get; set; } = 600;
        public ImageFormat Format { get; set; } = ImageFormat.Png;
        public string FontName { get; set; } = "arial";
        public float MinFontSize { get; set; } = 15;
        public float MaxFontSize { get; set; } = 35;

        public Font DefaultFont => new Font(FontName, (MaxFontSize + MinFontSize) / 2);
    }
}