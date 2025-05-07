using Microsoft.Win32;

namespace PCHUB
{
    public partial class CmdLineForm : Form
    {
        private const string RegPath = @"SYSTEM\Setup";
        private const string CmdLineValue = "CmdLine";
        private const string SetupTypeValue = "SetupType";

        public CmdLineForm()
        {
            InitializeComponent();

            LoadRegistryValues(); // Загружаем значения при старте
        }

        // Метод для загрузки текущих значений из реестра
        private void LoadRegistryValues()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegPath)!)
                {
                    if (key != null)
                    {
                        // Загружаем значение CmdLine или пустую строку если нет значения
                        TextBoxCmdLine.Text = key.GetValue(CmdLineValue, "").ToString();

                        // Загружаем значение SetupType или "0" если нет значения
                        TextBoxSetupType.Text = key.GetValue(SetupTypeValue, "0").ToString();
                    }
                    else
                    {
                        TextBoxCmdLine.Text = "";
                        TextBoxSetupType.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading registry: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем путь к себе как значение по умолчанию
                string exePath = TextBoxCmdLine.Text;

                // Парсим SetupType из TextBox или используем 1 по умолчанию
                if (!int.TryParse(TextBoxSetupType.Text, out int setupType))
                {
                    setupType = 1;
                }

                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegPath, true)!)
                {
                    if (key == null)
                    {
                        using (RegistryKey newKey = Registry.LocalMachine.CreateSubKey(RegPath))
                        {
                            newKey.SetValue(CmdLineValue, exePath, RegistryValueKind.ExpandString);
                            newKey.SetValue(SetupTypeValue, setupType, RegistryValueKind.DWord);
                        }
                    }
                    else
                    {
                        key.SetValue(CmdLineValue, exePath, RegistryValueKind.ExpandString);
                        key.SetValue(SetupTypeValue, setupType, RegistryValueKind.DWord);
                    }

                    MessageBox.Show("Parameters successfully added to registry",
                                   "Success",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                    LoadRegistryValues(); // Обновляем значения после изменения
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegPath, true)!)
                {
                    if (key == null)
                    {
                        MessageBoxClassSpace.MessageBoxShowClass.ShowInfoMessage("Registry key not found");
                        return;
                    }

                    if (key.GetValue(CmdLineValue) != null)
                    {
                        key.DeleteValue(CmdLineValue, false);
                    }

                    key.SetValue(SetupTypeValue, 0, RegistryValueKind.DWord);

                    MessageBoxClassSpace.MessageBoxShowClass.ShowInfoMessage("Parameters successfully removed from registry");

                    LoadRegistryValues(); // Обновляем значения после изменения
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void regeditToolStripMenuItem_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ProcessRun("regedit");

        private void btnDotDotDot_Click(object sender, EventArgs e)
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

                        TextBoxCmdLine.Text = filePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage($"Error reading file: {ex.Message}");
                    }
                }
            }
        }

        private void btnOne_Click(object sender, EventArgs e) => TextBoxSetupType.Text = "0";

        private void btnTwo_Click(object sender, EventArgs e) => TextBoxSetupType.Text = "1";
    }
}