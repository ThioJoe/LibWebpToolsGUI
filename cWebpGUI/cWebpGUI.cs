using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace cWebpGUI
{
    public partial class cWebpGUI : Form
    {
        public cWebpGUI()
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
                    outputFile = Path.Combine(directory, filenameWithoutExtension + ".webp");
                }
                else
                {
                    outputFile = outputFile.Trim('"');
                    if (!outputFile.EndsWith(".webp", StringComparison.OrdinalIgnoreCase))
                    {
                        outputFile += ".webp";
                    }
                    outputFile = Path.Combine(Path.GetDirectoryName(inputFile), outputFile);
                }

                string command = $"cwebp {options} \"{inputFile}\" -o \"{outputFile}\"";
                RunCommand(command);
            }
            else
            {
                MessageBox.Show("Input file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string BuildOptions()
        {
            string options = " -metadata icc";    // Make sure to preserve/copy ICC color profiles as they are important, without them final images WILL look wrong.

            if (chkLossless.Checked)
                options += " -lossless";

            if (chkMultiThreading.Checked)
                options += " -mt";

            if (chkLowMemory.Checked)
                options += " -low_memory";

            if (!string.IsNullOrWhiteSpace(txtQuality.Text))
                options += $" -q {txtQuality.Text}";

            if (!string.IsNullOrWhiteSpace(txtAlphaQuality.Text))
                options += $" -alpha_q {txtAlphaQuality.Text}";

            if (cmbPreset.SelectedIndex > 0)
                options += $" -preset {cmbPreset.SelectedItem}";

            if (cmbMethod.SelectedIndex > 0)
                options += $" -m {cmbMethod.SelectedItem}";

            return options;
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

            if (error.StartsWith("Error!"))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("Conversion completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Display the informational messages in a message box or log them
                MessageBox.Show(error, "Success - Conversion Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    outputFile = Path.Combine(directory, filenameWithoutExtension + ".webp");
                }
            }
            else
            {
                outputFile = outputFile.Trim('"');
                if (!outputFile.EndsWith(".webp", StringComparison.OrdinalIgnoreCase))
                {
                    outputFile += ".webp";
                }
                outputFile = Path.Combine(Path.GetDirectoryName(inputFile), outputFile);
            }

            string command = $"cwebp {options} \"{inputFile}\" -o \"{outputFile}\"";
            txtCommandPreview.Text = command;
        }



        private void txtInputFile_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void txtOutputFile_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void chkLossless_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void chkMultiThreading_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void chkLowMemory_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void txtQuality_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void txtAlphaQuality_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void cmbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }
    }
}
