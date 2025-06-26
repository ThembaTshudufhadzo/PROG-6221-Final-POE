using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbotAppGUI
{
    internal class ConvertToAciiArt
    {
        public static string ConvertImageToASCII(string imagePath, int maxWidth = 60)
        {
            try
            {
                if (!File.Exists(imagePath))
                {
                    Console.WriteLine($"Error: Image file not found at {imagePath}");
                    return null;
                }

                Bitmap img = new Bitmap(imagePath);
                float ratio = (float)img.Height / img.Width;
                int newWidth = Math.Min(maxWidth, img.Width);
                int newHeight = (int)(newWidth * ratio);

                Bitmap resized = new Bitmap(newWidth, newHeight);
                using (Graphics g = Graphics.FromImage(resized))
                    g.DrawImage(img, 0, 0, newWidth, newHeight);

                StringBuilder sb = new StringBuilder();

                // Fixed: Added more ASCII characters to match the index range
                char[] asciiChars = { ' ', '.', ',', ':', '+', '*', '?', '@', '#' };

                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color c = resized.GetPixel(x, y);
                        int intensity = (int)(0.299 * c.R + 0.587 * c.G + 0.114 * c.B);

                        // Fixed: Ensure index is within bounds (0 to 8, matching asciiChars length)
                        int index = Math.Min(intensity * (asciiChars.Length - 1) / 255, asciiChars.Length - 1);
                        sb.Append(asciiChars[index]);
                    }
                    sb.AppendLine();
                }

                // Don't forget to dispose of the bitmaps
                img.Dispose();
                resized.Dispose();

                return sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting image: {ex.Message}");
                return null;
            }
        }
    }
}