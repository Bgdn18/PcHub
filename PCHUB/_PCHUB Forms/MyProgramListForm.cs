using System.Diagnostics;

namespace PCHUB
{
    public partial class MyProgramListForm : Form
    {
        private const string ProgramFolder = "PCHUB";
        private static readonly string SystemDrive = Path.GetPathRoot(Environment.SystemDirectory)!;
        private static readonly string SaveFilePath = Path.Combine(SystemDrive, ProgramFolder, "saved_programs.txt");

        public MyProgramListForm()
        {
            InitializeComponent();

            InitializeApplication();
        }

        private void InitializeApplication()
        {
            EnsureProgramFolderExists();
            LoadSavedPrograms();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            ListBoxMyProgram.KeyDown += (s, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        DeleteSelectedProgram();
                        break;
                    case Keys.Enter:
                        OpenSelectedProgram();
                        break;
                }
            };
        }

        private void EnsureProgramFolderExists()
        {
            string programPath = Path.Combine(SystemDrive, ProgramFolder);

            if (!Directory.Exists(programPath))
            {
                try
                {
                    Directory.CreateDirectory(programPath);
                }
                catch (Exception ex)
                {
                    MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Failed to create directory: {ex.Message}");
                }
            }
        }

        private void LoadSavedPrograms()
        {
            if (!File.Exists(SaveFilePath)) return;

            try
            {
                ListBoxMyProgram.Items.Clear();
                var programs = File.ReadAllLines(SaveFilePath)
                                 .Where(p => !string.IsNullOrWhiteSpace(p))
                                 .ToArray();

                ListBoxMyProgram.Items.AddRange(programs);
            }
            catch (Exception ex)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Failed to load programs: {ex.Message}");
                Close();
            }
        }

        private void SavePrograms()
        {
            try
            {
                var programs = ListBoxMyProgram.Items.Cast<string>().ToList();
                File.WriteAllLines(SaveFilePath, programs);
            }
            catch (Exception ex)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Failed to save programs: {ex.Message}");
            }
        }

        private void AddProgram()
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "Programs (*.exe)|*.exe|All files (*.*)|*.*",
                Title = "Select Program"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string selectedFile = openFileDialog.FileName;

            if (ListBoxMyProgram.Items.Cast<string>().Any(item =>
                string.Equals(item, selectedFile, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowWarningMessage("This program has already been added");
                return;
            }

            ListBoxMyProgram.Items.Add(selectedFile);
            SavePrograms();
        }

        private void DeleteSelectedProgram()
        {
            if (ListBoxMyProgram.SelectedIndex == -1)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage("Select a program to delete");
                return;
            }

            ListBoxMyProgram.Items.RemoveAt(ListBoxMyProgram.SelectedIndex);
            SavePrograms();
        }

        private void OpenSelectedProgram()
        {
            if (ListBoxMyProgram.SelectedIndex == -1)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage("Select a program to run");
                return;
            }

            string programPath = ListBoxMyProgram.SelectedItem!.ToString()!;

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = programPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Failed to start the program: {ex.Message}");
            }
        }

        private void OpenTextFile()
        {
            if (!File.Exists(SaveFilePath))
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowWarningMessage("The program list file was not found.");
                return;
            }

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "notepad",
                    Arguments = SaveFilePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Error opening file: {ex.Message}");
            }
        }


        #region Event Handlers
        private void btnAdd_Click(object sender, EventArgs e) => AddProgram();
        private void btnDelete_Click(object sender, EventArgs e) => DeleteSelectedProgram();
        private void btnOpen_Click(object sender, EventArgs e) => OpenSelectedProgram();
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void txtFileToolStripMenuItem_Click(object sender, EventArgs e) => OpenTextFile();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadSavedPrograms();
        #endregion
    }
}