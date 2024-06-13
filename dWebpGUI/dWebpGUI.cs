using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace dWebpGUI
{
    public partial class dWebpGUI : Form
    {
        public dWebpGUI()
        {
            InitializeComponent();
            UpdateCommandPreview();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputFile = txtInputFile.Text;
            string outputFile = txtOutputFile.Text;
            string options = BuildOptions();

            inputFile = inputFile.Trim('"');

            if (File.Exists(inputFile))
            {
                if (string.IsNullOrWhiteSpace(outputFile))
                {
                    string directory = Path.GetDirectoryName(inputFile);
                    string filenameWithoutExtension = Path.GetFileNameWithoutExtension(inputFile);
                    outputFile = Path.Combine(directory, filenameWithoutExtension + GetOutputExtension());
                }
                else
                {
                    outputFile = outputFile.Trim('"');
                    outputFile = Path.Combine(Path.GetDirectoryName(inputFile), outputFile);
                }

                string command = $"dwebp {options} \"{inputFile}\" -o \"{outputFile}\"";
                RunCommand(command);
            }
            else
            {
                MessageBox.Show("Input file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuildOptions()
        {
            string options = "";

            if (chkMultiThreading.Checked)
                options += " -mt";

            if (!string.IsNullOrWhiteSpace(txtResizeWidth.Text) && !string.IsNullOrWhiteSpace(txtResizeHeight.Text))
                options += $" -resize {txtResizeWidth.Text} {txtResizeHeight.Text}";

            // Check which radio button is selected and append the corresponding option
            if (rbBMP.Checked)
                options += " -bmp";
            else if (rbTIFF.Checked)
                options += " -tiff";
            else if (rbPAM.Checked)
                options += " -pam";
            else if (rbPPM.Checked)
                options += " -ppm";
            else if (rbPGM.Checked)
                options += " -pgm";
            else if (rbYUV.Checked)
                options += " -yuv";
            // No need to append anything for PNG as it's the default format

            return options;
        }

        private string GetOutputExtension()
        {
            if (rbBMP.Checked) return ".bmp";
            if (rbTIFF.Checked) return ".tiff";
            if (rbPAM.Checked) return ".pam";
            if (rbPPM.Checked) return ".ppm";
            if (rbPGM.Checked) return ".pgm";
            if (rbYUV.Checked) return ".yuv";
            return ".png"; // default to PNG if no option is selected or PNG is selected
        }

        private void RunCommand(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            // Check if the error output contains the word "Error"
            if (!string.IsNullOrEmpty(error) && error.ToLowerInvariant().Contains("error"))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(output))
            {
                MessageBox.Show(output, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrEmpty(error)) // Handle non-error but stderr output case
            {
                MessageBox.Show(error, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateCommandPreview()
        {
            string inputFile = txtInputFile.Text;
            string outputFile = txtOutputFile.Text;
            string options = BuildOptions();

            inputFile = inputFile.Trim('"');

            if (string.IsNullOrWhiteSpace(outputFile))
            {
                if (!string.IsNullOrWhiteSpace(inputFile))
                {
                    string directory = Path.GetDirectoryName(inputFile);
                    string filenameWithoutExtension = Path.GetFileNameWithoutExtension(inputFile);
                    outputFile = Path.Combine(directory, filenameWithoutExtension + GetOutputExtension());
                }
            }
            else
            {
                outputFile = outputFile.Trim('"');
                outputFile = Path.Combine(Path.GetDirectoryName(inputFile), outputFile);
            }

            string command = $"dwebp {options} \"{inputFile}\" -o \"{outputFile}\"";
            txtCommandPreview.Text = command;
        }

        private void txtInputFile_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void txtOutputFile_TextChanged(object sender, EventArgs e)
        {
            // This prevents a crash if we type in this box before selecting an input
            if (txtInputFile.Text == "" && txtOutputFile.Text != string.Empty)
            {
                txtOutputFile.Text = string.Empty;
                MessageBox.Show("You must select an input file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Automatically update the radio buttons based on what we chose here
            string extension = Path.GetExtension(txtOutputFile.Text);
            switch (extension.ToLower())
            {
                case ".png":
                    rbPNG.Checked = true; break;
                case ".tif":
                    rbTIFF.Checked = true; break;
                case ".pam":
                    rbPAM.Checked = true; break;
                case ".ppm":
                    rbPPM.Checked = true; break;
                case ".pgm":
                    rbPGM.Checked = true; break;
                case ".yuv":
                    rbYUV.Checked = true; break;
                case ".bmp":
                    rbBMP.Checked = true; break;
            }
            UpdateCommandPreview();
        }

        private void chkMultiThreading_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void OutputFormat_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();

            // update the extension in the output field
            if (!string.IsNullOrWhiteSpace(txtOutputFile.Text))
            {
                string directory = Path.GetDirectoryName(txtOutputFile.Text);
                string filenameWithoutExtension = Path.GetFileNameWithoutExtension(txtOutputFile.Text);
                txtOutputFile.Text = Path.Combine(directory, filenameWithoutExtension + GetOutputExtension());
            }
        }

        private void txtResizeWidth_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void txtResizeHeight_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtInputFile.Text = openFileDialog.FileName;
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            if (txtInputFile.Text == "")
            {
                MessageBox.Show("You must select an input file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK || saveFileDialog.FileName != "")
            {
                txtOutputFile.Text = saveFileDialog.FileName;

                // Automatically update the radio buttons based on what we chose here
                string extension = Path.GetExtension(txtOutputFile.Text);
                switch (extension.ToLower())
                {
                    case ".png":
                        rbPNG.Checked = true; break;
                    case ".tif":
                        rbTIFF.Checked = true; break;
                    case ".pam":
                        rbPAM.Checked = true; break;
                    case ".ppm":
                        rbPPM.Checked = true; break;
                    case ".pgm":
                        rbPGM.Checked = true; break;
                    case ".yuv":
                        rbYUV.Checked = true; break;
                    case ".bmp":
                        rbBMP.Checked = true; break;
                }
            }
            
        }
    }
}
