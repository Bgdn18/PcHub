using Microsoft.Win32;
using PCHUB.OpenClassSpace;

namespace PCHUB.WinLogonSpace
{
    public partial class WinLogonEditForm : Form
    {
        // Путь в реестре, где хранится процесс входа
        private const string RegistryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
        private const string ValueName = "Shell";

        public WinLogonEditForm()
        {
            InitializeComponent();

            LoadCurrentShell();
        }

        /// <summary>
        /// Загружает данные из файла Shell в Winlogon
        /// </summary>
        private void LoadCurrentShell()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegistryPath)!)
                {
                    if (key != null)
                    {
                        string currentShell = key.GetValue(ValueName)?.ToString() ?? "explorer.exe";
                        TextBoxLogon.Text = currentShell;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Error reading registry: {ex.Message}");
            }
        }

        /// <summary>
        /// Сохраняет в Shell из TextBoxLogon
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegistryPath, true)!)
                {
                    if (key != null)
                    {
                        key.SetValue(ValueName, TextBoxLogon.Text.Trim());
                        MessageBox.Show("Changes saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Error writing to registry: {ex.Message}");
            }
        }

        /// <summary>
        /// Выставляет дефолтное значение explorer.exe в Shell
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegistryPath, true)!)
                {
                    if (key != null)
                    {
                        key.SetValue(ValueName, "explorer.exe");
                        MessageBoxClassSpace.MessageBoxShowClass.ShowInfoMessage("Changes saved");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Error writing to registry: {ex.Message}");
            }
        }

        /// <summary>
        /// Открывает быстрое меню выбора
        /// </summary>
        private void ThreeDot_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                // Показываем диалог и проверяем результат
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;

                        string fileContent = File.ReadAllText(filePath);

                        TextBoxLogon.Text = filePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Error reading file: {ex.Message}");
                    }
                }
            }
        }

        #region Buttons Event Handlers

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void regEditToolStripMenuItem_Click(object sender, EventArgs e) => OpenClass.ProcessRun("regedit");

        #endregion
    }
}
