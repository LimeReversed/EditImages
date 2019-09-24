using NUnit.Framework;
using System;
using Shared;
using System.Drawing;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EditFileNameWorks()
        {
            string path = "C:\\Users\\Name\\Desktop\\name.png";
            string insertText = "_inserted";
            Assert.AreEqual("C:\\Users\\Name\\Desktop\\name_inserted.png",
                            PathManipulations.EditFileName(path, insertText));
        }

        [Test]
        public void NegativeWorks()
        {
            // Color.Red skapar HEX8-koden FFFF0000 medan Color.FromArgb(255, 0, 0) skapar
            // HEX-koden FF0000. I manipulationsalgoritmerna använder jag Color.FromArgb() för att
            // sätta ihop uträkningarna av R, G och B till en färg. Därför måste jag
            // skapa färgerna nedan istället för att exempelvis använda Color.Red. Annars är koderna
            // inte jämförbara.

            Color red = Color.FromArgb(255, 0, 0);
            Color green = Color.FromArgb(0, 255, 0);
            Color blue = Color.FromArgb(0, 0, 255);
            Color white = Color.FromArgb(255, 255, 255);

            Color cyan = Color.FromArgb(0, 255, 255);
            Color magenta = Color.FromArgb(255, 0, 255);
            Color yellow = Color.FromArgb(255, 255, 0);
            Color black = Color.FromArgb(0, 0, 0);

            Color[,] originalColors =
            {
                { red,  green },
                { blue, white }
            };

            Color[,] negativeColors =
            {
                { cyan,   magenta },
                { yellow, black }
            };

            Bitmap original = CreateImage(2, 2, originalColors);
            Bitmap expected = CreateImage(2, 2, negativeColors);
            Bitmap actual = ImageManipulations.MakeNegative(original);

            // Bilden består av 4 pixlar vardera, så nedan kollas varenda pixel av båda bilderna. 
            bool check = expected.GetPixel(0, 0).Name == actual.GetPixel(0, 0).Name &&
                         expected.GetPixel(0, 1).Name == actual.GetPixel(0, 1).Name &&
                         expected.GetPixel(1, 0).Name == actual.GetPixel(1, 0).Name &&
                         expected.GetPixel(1, 1).Name == actual.GetPixel(1, 1).Name;

            Assert.IsTrue(check);
        }

        [Test]
        public void GrayscaleWorks()
        {
            Color red = Color.FromArgb(255, 0, 0);
            Color green = Color.FromArgb(0, 255, 0);
            Color blue = Color.FromArgb(0, 0, 255);
            Color white = Color.FromArgb(255, 255, 255);

            Color[,] originalColors =
            {
                { red,  green },
                { blue, white }
            };

            Bitmap original = CreateImage(2, 2, originalColors);
            Bitmap actual = ImageManipulations.MakeGray(original);
            bool isGray = false;

            for (int y = 0; y < actual.Height; y++)
            {
                for (int x = 0; x < actual.Width; x++)
                {
                    // Om värdena för R, G och B hos en pixel har samma värde ska den anses vara grå. 
                    if (actual.GetPixel(x, y).R == actual.GetPixel(x, y).G &&
                        actual.GetPixel(x, y).R == actual.GetPixel(x, y).B)
                    {
                        isGray = true;
                    }
                    else
                    {
                        Assert.Fail();
                    }

                }
            }
            Assert.IsTrue(isGray);
        }

        [Test]
        public void BlurryWorks()
        {
            Color white = Color.FromArgb(255, 255, 255);
            Color black = Color.FromArgb(0, 0, 0);

            Color[,] assignColors =
            {
                { white, black, white },
                { white, black, white },
                { white, black, white }
            };

            Bitmap original = CreateImage(3, 3, assignColors);
            Bitmap actual = ImageManipulations.MakeBlurry(original);

            // Om suddalgoritmen ovan har fungerat, så ska det inte finnas en enda pixel i testbilden
            // som är helt svart eller helt vit. Loopen nedan testar detta. 
            for (int y = 0; y < actual.Height; y++)
            {
                for (int x = 0; x < actual.Width; x++)
                {
                    int colorSum = actual.GetPixel(x, y).R + actual.GetPixel(x, y).G + actual.GetPixel(x, y).B;

                    // En helt vit pixel är 255 * 3 = 765, medan en helt svart är 0.
                    if (colorSum == 0 || colorSum == 765)
                    {
                        Assert.Fail();
                    }
                }

            }
            Assert.Pass();
        }

        [Test]
        public void ExtraBlurryWorks()
        {
            Color white = Color.FromArgb(255, 255, 255);
            Color black = Color.FromArgb(0, 0, 0);

            Color[,] assignColors =
            {
                { white, white, black, white, white },
                { white, white, black, white, white },
                { white, white, black, white, white },
                { white, white, black, white, white },
                { white, white, black, white, white }
            };

            Bitmap original = CreateImage(5, 5, assignColors);
            Bitmap actual = ImageManipulations.MakeExtraBlurry(original);

            for (int y = 0; y < actual.Height; y++)
            {
                for (int x = 0; x < actual.Width; x++)
                {
                    int colorSum = actual.GetPixel(x, y).R + actual.GetPixel(x, y).G + actual.GetPixel(x, y).B;

                    if (colorSum > 0 && colorSum < 765)
                    {

                    }
                    else
                    {

                        Assert.Fail();
                    }
                }

            }
            Assert.Pass();
        }

        // Här är plats för metoderna som behövs i fler än ett test.
        internal Bitmap CreateImage(byte width, byte height, Color[,] colors)
        {
            Bitmap bitmap = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bitmap.SetPixel(x, y, colors[x, y]);
                }
            }
            return bitmap;
        }

    }
}