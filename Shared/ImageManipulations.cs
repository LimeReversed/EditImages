using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Shared
{
    public class ImageManipulations
    {
        /// <summary>
        /// Returns a grayscale version of the original as a new Bitmap object.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap MakeGray(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    byte red = bitmap.GetPixel(x, y).R;
                    byte green = bitmap.GetPixel(x, y).G;
                    byte blue = bitmap.GetPixel(x, y).B;

                    // För att kunna addera färgerna med varandra kunde jag inte forsätta använda byte.
                    int calculatedGray = (red + green + blue) / 3;
                    Color gray = Color.FromArgb(calculatedGray, calculatedGray, calculatedGray);

                    result.SetPixel(x, y, gray);
                }
            }
            return result;
        }

        /// <summary>
        /// Returns a blurred version of the original as a new Bitmap object.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap MakeBlurry(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            // Denna externa dubbel-loop går igenom alla pixlar i bilden en och en. 
            for (int externalY = 0; externalY < bitmap.Height; externalY++)
            {
                for (int externalX = 0; externalX < bitmap.Width; externalX++)
                {
                    int sumOfPixles = 0;
                    int sumOfRed = 0;
                    int sumOfGreen = 0;
                    int sumOfBlue = 0;

                    /* Den interna dubbel-loopen nedan kollar värdet av den aktuella pixeln och alla pixlar som är
                       i direkt anslutning till den aktuella pixeln. Om den aktuella pixeln är längst upp
                       i vänstra hörnet ska bara fyra pixlar kollas. Om den aktuella pixeln inte är för nära en
                       kant, så ska 9 pixlar kollas. Då kan man se det som att man skapar en array av 3*3 pixlar
                       där den aktuella pixeln är i mitten och sedan loopar man igenom denna array för att kolla 
                       pixlarnas värden.
                    */
                    #region
                    /*
                       För egen del vill jag påminna mig om hur detta ska läsas. Om den aktuella pixeln är 
                       längst upp i bild, så kolla inte efter pixlar ovanför, utan börja från den högsta pixeln:
                       (0). Om det finns plats ovan den aktuella pixeln, då börja där (externalY - 1).
                       När startpunkten är satt är det bara att fortsätta loopa igenom arrayen av 3 * 3 pixlar. 
                       
                       Om den aktuella pixeln är i slutet av bilden (externalY == bitmap.Height - 1)
                       Så låt inte den interna loopen gå längre än positionen för den aktuella 
                       pixeln (internalY <= externalY). Annars gå ett steg längre än den aktuella pixeln: 
                       (internalY <= externalY + 1). Innan hade jag internalY < externaY , men så gör man 
                       ju bara om man jämför exempelvis position med count, inte när man jämför position 
                       med position. Sorry för den långa kommentaren, men jag behöver detta för att kunna
                       gå tillbaka och förstå hur jag tänkt. 
                    
                       "int internalX = externalX < 2 ? 0 : externalX - 2 är samma som  int internalX = Math.Max(0, externalX - 2)"
                       Jag vet hur Max() fungerar men jag lyckas ännu inte förstå på vilket sätt dessa är samma. Därmed är
                       nuvarande kod mer läsbart för mig personligen. Men kom ihåg detta för framtiden. 
                    */
                    #endregion

                    for (int internalY = externalY < 1 ? 0 : externalY - 1;
                        externalY == bitmap.Height - 1 ? internalY <= externalY : internalY <= externalY + 1;
                        internalY++)
                    {
                        for (int internalX = externalX < 1 ? 0 : externalX - 1;
                            externalX == bitmap.Width - 1 ? internalX <= externalX : internalX <= externalX + 1;
                            internalX++)
                        {
                            sumOfRed += (int)bitmap.GetPixel(internalX, internalY).R;
                            sumOfGreen += (int)bitmap.GetPixel(internalX, internalY).G;
                            sumOfBlue += (int)bitmap.GetPixel(internalX, internalY).B;
                            sumOfPixles++;
                        }
                    }

                    int calculatedRed = sumOfRed / sumOfPixles;
                    int calculatedGreen = sumOfGreen / sumOfPixles;
                    int calculatedBlue = sumOfBlue / sumOfPixles;
                    Color pixelColor = Color.FromArgb(calculatedRed, calculatedGreen, calculatedBlue);

                    result.SetPixel(externalX, externalY, pixelColor);
                }
            }

            return result;
        }

        /// <summary>
        /// Returns an inverted version of the original as a new Bitmap object.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap MakeNegative(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    byte red = bitmap.GetPixel(x, y).R;
                    byte green = bitmap.GetPixel(x, y).G;
                    byte blue = bitmap.GetPixel(x, y).B;

                    int calculatedRed = 255 - red;
                    int calculatedGreen = 255 - green;
                    int calculatedBlue = 255 - blue;
                    Color negativeColor = Color.FromArgb(calculatedRed, calculatedGreen, calculatedBlue);

                    result.SetPixel(x, y, negativeColor);
                }
            }
            return result;
        }

        /// <summary>
        /// Returns a blurrier version of the original as a new Bitmap object.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap MakeExtraBlurry(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            for (int externalY = 0; externalY < bitmap.Height; externalY++)
            {
                for (int externalX = 0; externalX < bitmap.Width; externalX++)
                {
                    int sumOfPixles = 0;
                    int sumOfRed = 0;
                    int sumOfGreen = 0;
                    int sumOfBlue = 0;

                    #region
                    /*
                     * Den här kommentaren är också för egen del... Om den aktuella pixeln är mindre än
                     * två steg från vänsterkanten så går det inte att starta vid den aktuella - 2, Utan
                     * då behöver vi börja från kanten (Position 0). Sedan om det är exakt ett (eller mindre 
                     * än ett) steg kvar till kanten: (externalY >= bitmap.Height - 2) så gå bara så långt 
                     * som kanten är: (internalZ < bitmap.Width). Annars fortsätt två steg förbi den aktuella 
                     * pixeln.
                     */
                    #endregion
                    // Den här algoritmen är jag stolt över. Det är den svåraste gruppen loopar jag någonsin
                    // har gjort. Men jag lyckades och den rör sig genom bilderna exakt som jag vill att den
                    // gör. Nästa steg hade varit att inkludera en parameter så att användaren själv skulle
                    // kunna trycka in hur stor effekt de vill ha av algorithmen. Men jag stannar här... 
                    // Det går alltid att vidareutvecka saker. 

                    for (int internalY = externalY < 2 ? 0 : externalY - 2;
                        externalY >= bitmap.Height - 2 ? internalY < bitmap.Height : internalY <= externalY + 2;
                        internalY++)
                    {
                        for (int internalX = externalX < 2 ? 0 : externalX - 2;
                            externalX >= bitmap.Width - 2 ? internalX < bitmap.Width : internalX <= externalX + 2;
                            internalX++)
                        {
                            sumOfRed += (int)bitmap.GetPixel(internalX, internalY).R;
                            sumOfGreen += (int)bitmap.GetPixel(internalX, internalY).G;
                            sumOfBlue += (int)bitmap.GetPixel(internalX, internalY).B;
                            sumOfPixles++;
                        }
                    }

                    int calculatedRed = sumOfRed / sumOfPixles;
                    int calculatedGreen = sumOfGreen / sumOfPixles;
                    int calculatedBlue = sumOfBlue / sumOfPixles;
                    Color pixelColor = Color.FromArgb(calculatedRed, calculatedGreen, calculatedBlue);

                    result.SetPixel(externalX, externalY, pixelColor);
                }
            }

            return result;
        }

    }
}
