using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MuxServerGUI
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            XML_T.MouseDoubleClick += XML_T_MouseDoubleClick;
            MUX_M.MouseDoubleClick += MUX_M_MouseDoubleClick;

            MUX_M.Text = Properties.Settings.Default.LastOpenedFilePath;
        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void XML_T_MouseDoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open ProjectDefinition.xml file";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "ProjectDefinition.xml (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XML_T.Text = openFileDialog.FileName;
            }
        }

        private void MUX_M_MouseDoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open UHD/MuxRemotingServer.exe path";
            openFileDialog.InitialDirectory = @"C:\Program Files (x86)\Scenarist\Scenarist BD\MUXRemotingServer";
            openFileDialog.Filter = "UHD/MuxRemotingServer.exe (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MUX_M.Text = openFileDialog.FileName;

                Properties.Settings.Default.LastOpenedFilePath = openFileDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private async void Execute_Click(object sender, EventArgs e)
        {
            Execute.Enabled = false;

            if (string.IsNullOrWhiteSpace(XML_T.Text))
            {
                MessageBox.Show("‘Open Project’ have content place blanks with.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Execute.Enabled = true;
                return;
            }

            if (!File.Exists(MUX_M.Text))
            {
                MessageBox.Show("UHD/MuxRemotingServer.exe File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Execute.Enabled = true;
                return;
            }

            try
            {
                string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MuxServerHelper", "MuxServerHelper.exe");

                if (!File.Exists(exePath))
                {
                    MessageBox.Show($"MuxServerHelper.exe file not found: {exePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Execute.Enabled = true;
                    return;
                }

                Process process = new Process();
                process.StartInfo.FileName = exePath;
                string arguments = $"--project \"{XML_T.Text}\" --clip {CLIP_T.Text} --server \"{MUX_M.Text}\" --port {PORT_T.Text} --wait {WAIT_T.Text}";
                process.StartInfo.Arguments = arguments;

                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.EnableRaisingEvents = true;

                process.OutputDataReceived += (procSender, args) => Console.WriteLine(args.Data);
                process.ErrorDataReceived += (procSender, args) => Console.WriteLine(args.Data);

                await Task.Run(() =>
                {
                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Execute.Enabled = true;
            }
        }
    }
}