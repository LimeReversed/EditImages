using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace EditImages_Form
{
    public partial class ImageEditForm : Form
    {
        public ImageEditForm()
        {
            InitializeComponent();
            
        }

        // Skapar nödvändiga variabler.
        string pathToImage;
        string pathToDirectory;
        string currentManipulation = "_original";
        bool manipulationMade = false;
        Bitmap original;
        Bitmap manipulated;

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            // Accepterade format. 
            // "All files" tillagt som alternativ så att jag inte missar format som programmet skulle klara. 
            openFileDialogue.Filter = "Bitmap files (*.bmp; *.png; *.jpg)|*.bmp; *.png; *.jpg|All files (*.*)|*.*";
            openFileDialogue.FileName = "";

            if (openFileDialogue.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                try
                {
                    // Kolla om filen är en bildfil.
                    original = new Bitmap(openFileDialogue.FileName);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("File is not an acceptable format", "EditImages",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (original.Width >= 5000 || original.Height >= 5000)
                {
                    MessageBox.Show("The image cannot be over 5000 pixels in height or width", "EditImages",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Visa tillagd bild och göm eventuell bild i manipulationsfältet. 
                pbOriginal.Image = original;
                pbManipulated.Image = null;

                pathToImage = openFileDialogue.FileName;
                pathToDirectory = openFileDialogue.InitialDirectory;

                // Det ska inte gå att starta någon manipulationsalgoritm om ingen bild lagts till.
                btnGray.Enabled = true;
                btnNegative.Enabled = true;
                btnBlurred.Enabled = true;
                btnExtraBlurry.Enabled = true;
                btnSave.Enabled = true;
                manipulationMade = false;
            }
        }
        
        private void BtnGray_Click(object sender, EventArgs e)
        {
            manipulated = ImageManipulations.MakeGray(original);
            currentManipulation = "_grayscale";
            pbManipulated.Image = manipulated;
            manipulationMade = true;
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            manipulated = ImageManipulations.MakeNegative(original);
            currentManipulation = "_negative";
            pbManipulated.Image = manipulated;
            manipulationMade = true;
        }

        private void BtnBlurred_Click(object sender, EventArgs e)
        {
            manipulated = ImageManipulations.MakeBlurry(original);
            currentManipulation = "_blurry";
            pbManipulated.Image = manipulated;
            manipulationMade = true;
        }

        private void BtnExtraBlurry_Click(object sender, EventArgs e)
        {
            manipulated = ImageManipulations.MakeExtraBlurry(original);
            currentManipulation = "_extra_blurry";
            pbManipulated.Image = manipulated;
            manipulationMade = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Starta i mappen som filen låg i och föreslå namn och format på den nya filen.
            string fileName = Path.GetFileName(pathToImage);
            saveFileDialogue.FileName = PathManipulations.EditFileName(fileName, currentManipulation);
            saveFileDialogue.InitialDirectory = pathToDirectory;
            saveFileDialogue.DefaultExt = ".png";
            saveFileDialogue.Filter = "PNG | *.png | JPG |*.jpg";

            if (manipulationMade == false)
            {
                MessageBox.Show("You are trying to save the image without manipulating it first. Why would you " +
                                "do that? What's wrong with you? I mean... insert nice error message here.", "EditImages",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (saveFileDialogue.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                manipulated.Save(saveFileDialogue.FileName);
            }
        }

        
    }
}
