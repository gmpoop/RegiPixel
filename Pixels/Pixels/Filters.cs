using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixels
{
    public class Filters
    {
        private int filterValue;

        public Filters()
        {

        }
        public Bitmap Invert(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    img.SetPixel(i, j, Color.FromArgb(B, G, R));//We put the colors in the inverted channel
                }
            }

            return img;
        }
        public Bitmap GrayScale(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = color.R;
                    int G = color.G;
                    int B = color.B;
                    int Gray = (R + G + B) / 3;

                    img.SetPixel(i, j, Color.FromArgb(Gray, Gray, Gray));
                }
            }

            return img;
        }
        public Bitmap Negative(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = Math.Abs(color.R - 255);
                    int G = Math.Abs(color.G - 255);
                    int B = Math.Abs(color.B - 255);

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return img;
        }
        public Bitmap Contrast(Bitmap img)
        {
            //int contrastIntensity = 40;

            float Contrast = (100.0f + filterValue) / 100.0f;
            Contrast *= Contrast;

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    float R = ((((color.R / 255.0f) - 0.5f) * Contrast) + 0.5f) * 255;
                    if (R > 255) R = 255;
                    if (R < 0) R = 0;
                    float G = ((((color.G / 255.0f) - 0.5f) * Contrast) + 0.5f) * 255;
                    if (G > 255) G = 255;
                    if (G < 0) G = 0;
                    float B = ((((color.B / 255.0f) - 0.5f) * Contrast) + 0.5f) * 255;
                    if (B > 255) B = 255;
                    if (B < 0) B = 0;

                    img.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }


            return img;
        }
        public Bitmap HeatMap(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);
                    int intensity = (color.R + color.G + color.B) / 3;

                    int R = intensity > 128 ? 255 : intensity * 2;
                    if (R > 255) R = 255;
                    if (R < 0) R = 0;
                    int G = intensity > 128 ? (255 - intensity) * 2 : 0;
                    if (G > 255) G = 255;
                    if (G < 0) G = 0;
                    int B = intensity < 128 ? 255 : (255 - intensity) * 2;
                    if (B > 255) B = 255;
                    if (B < 0) B = 0;

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return img;
        }
        public Bitmap Posterize(Bitmap img)
        {
            //int levels = 4;
            int factor = 255 / (filterValue - 1);

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = (color.R / factor) * factor;
                    int G = (color.G / factor) * factor;
                    int B = (color.B / factor) * factor;

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return img;
        }
        public Bitmap Emboss(Bitmap img)
        {
            for (int j = 0; j < img.Height - 2; j++)
            {
                for (int i = 0; i < img.Width - 2; i++)
                {
                    Color color = img.GetPixel(i, j);
                    Color color2 = img.GetPixel(i + 2, j + 2);

                    int R = Math.Clamp(128 + (color.R - color2.R), 0, 255);
                    int G = Math.Clamp(128 + (color.G - color2.G), 0, 255);
                    int B = Math.Clamp(128 + (color.B - color2.B), 0, 255);

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return img;
        }
        public Bitmap Comic(Bitmap img)
        {
            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    Color color = img.GetPixel(i, j);

                    int R = (color.R > 128) ? 255 : 0;
                    int G = (color.G > 128) ? 255 : 0;
                    int B = (color.B > 128) ? 255 : 0;

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return img;
        }
        public Bitmap Pixel(Bitmap img)
        {
            //int Pixel = 10;//pizel size
            int iPixel, jPixel;
            int sumR, sumG, sumB;

            for (int i = 0; i < img.Width - filterValue; i += filterValue)
            {
                for (int j = 0; j < img.Height - filterValue; j += filterValue)
                {
                    sumR = 0;
                    sumG = 0;
                    sumB = 0;

                    for (iPixel = i; iPixel < (i + filterValue); iPixel++)//Sums the value of a particular set of pixels depending of the Pixel size (gets the Pixel color)
                    {
                        for (jPixel = j; jPixel < (j + filterValue); jPixel++)
                        {
                            Color color = img.GetPixel(iPixel, jPixel);

                            sumR += color.R;
                            sumG += color.G;
                            sumB += color.B;
                        }
                    }

                    int R = sumR / (filterValue * filterValue);
                    int G = sumG / (filterValue * filterValue);
                    int B = sumB / (filterValue * filterValue);

                    Color colorM = Color.FromArgb(R, G, B);

                    for (iPixel = i; iPixel < (i + filterValue); iPixel++)
                    {
                        for (jPixel = j; jPixel < (j + filterValue); jPixel++)
                        {
                            img.SetPixel(iPixel, jPixel, colorM);
                        }
                    }
                }
            }

            return img;
        }
        public Bitmap Glitch(Bitmap img)
        {
            Random rnd = new Random();

            for (int j = 0; j < img.Height; j++)
            {
                int glitchShift = rnd.Next(-2, 2);

                for (int i = 0; i < img.Width; i++)
                {
                    if (i + glitchShift >= 0 && i + glitchShift < img.Width)
                    {
                        Color color = img.GetPixel(i, j);

                        int R = Math.Clamp(color.R + rnd.Next(-20, 20), 0, 255);
                        int G = Math.Clamp(color.G + rnd.Next(-20, 20), 0, 255);
                        int B = Math.Clamp(color.B + rnd.Next(-20, 20), 0, 255);

                        img.SetPixel(i + glitchShift, j, Color.FromArgb(R, G, B));
                    }
                }
                if (rnd.NextDouble() > 0.98)
                {
                    for (int i = 0; i < img.Width; i++)
                    {
                        int R = rnd.Next(0, 256);
                        int G = rnd.Next(0, 256);
                        int B = rnd.Next(0, 256);

                        img.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                }
            }

            return img;
        }
        public Bitmap Glitch_1(Bitmap img)
        {
            //int filterValue = 8;
            int R, G, B;

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    G = img.GetPixel(i, j).G;

                    if (i + filterValue < img.Width)
                    {
                        R = img.GetPixel(i + filterValue, j).R;
                    }
                    else
                    {
                        R = 0;
                    }

                    if (i - filterValue >= 0)
                    {
                        B = img.GetPixel(i - filterValue, j).B;
                    }
                    else
                    {
                        B = 0;
                    }

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return img;
        }
        public Bitmap Glitch_2(Bitmap img)
        {
            int filterValue = 8;
            int R, G, B;

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    R = img.GetPixel(i, j).R;

                    if (i + filterValue < img.Width)
                    {
                        B = img.GetPixel(i + filterValue, j).B;
                    }
                    else
                    {
                        B = 0;
                    }

                    if (i - filterValue >= 0)
                    {
                        G = img.GetPixel(i - filterValue, j).G;
                    }
                    else
                    {
                        G = 0;
                    }

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return img;
        }
        public Bitmap Glitch_3(Bitmap img)
        {
            int filterValue = 8;
            int R, G, B;

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    B = img.GetPixel(i, j).B;

                    if (i + filterValue < img.Width)
                    {
                        G = img.GetPixel(i + filterValue, j).G;
                    }
                    else
                    {
                        G = 0;
                    }

                    if (i - filterValue >= 0)
                    {
                        R = img.GetPixel(i - filterValue, j).R;
                    }
                    else
                    {
                        R = 0;
                    }

                    img.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return img;
        }
    }
}
