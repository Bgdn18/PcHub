using System.Diagnostics;

namespace PCHUB
{
    public partial class MyProgramList : Form
    {
        private const string ProgramFolder = "PCHUB"; // Название папки на системном диске
        private static readonly string? SystemDrive = Path.GetPathRoot(Environment.SystemDirectory);
        private static readonly string SaveFilePath = Path.Combine(
            SystemDrive!,
            ProgramFolder,
            "saved_programs.txt"
        );

        public MyProgramList()
        {
            InitializeComponent();
            EnsureProgramFolderExists();
            LoadSavedPrograms();
        }

        private void EnsureProgramFolderExists()
        {
            string programPath = Path.Combine(SystemDrive!, ProgramFolder);
            if (!Directory.Exists(programPath))
            {
                try
                {
                    Directory.CreateDirectory(programPath);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show(
                        "No write access to the system drive. Run as Administrator or choose another location.",
                        "Access Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Failed to create directory: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void LoadSavedPrograms()
        {
            if (File.Exists(SaveFilePath))
            {
                try
                {
                    string[] programs = File.ReadAllLines(SaveFilePath);
                    listBox1.Items.AddRange(programs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Failed to load programs: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void SavePrograms()
        {
            try
            {
                List<string> programs = new List<string>();
                foreach (var item in listBox1.Items)
                {
                    programs.Add(item.ToString()!);
                }
                File.WriteAllLines(SaveFilePath, programs);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "No permission to save. Run as Administrator or choose another location.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to save programs: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Programs (*.exe)|*.exe|All files (*.*)|*.*",
                Title = "Explorer"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                if (!listBox1.Items.Contains(selectedFile))
                {
                    listBox1.Items.Add(selectedFile);
                    SavePrograms();
                }
                else
                {
                    MessageBox.Show("This program has already been added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Удаление выбранной программы
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                SavePrograms();
            }
            else
            {
                MessageBox.Show("Select a program to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Запуск выбранной программы
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string programPath = listBox1.SelectedItem!.ToString()!;
                try
                {
                    Process.Start(programPath!);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to start the program: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a program to run", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (File.Exists(SaveFilePath))
                {
                    // Открываем файл в блокноте
                    Process.Start("notepad.exe", SaveFilePath);
                }
                else
                {
                    MessageBox.Show("The program list file was not found.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
