using PCHUB._Main;
using PCHUB.About;
using PCHUB.ChoiceSpace;
using PCHUB.HostsSpace;
using PCHUB.LocalUserSpace;
using PCHUB.PowerSpace;
using PCHUB.WinLogonSpace;
using PCHUB.WinToolSpace;

namespace PCHUB._PCHUB_Forms._Main
{
    public partial class PCHubForm : Form
    {
        #region PCHubMenuItems

        /// <summary>
        /// Константы для пунктов меню
        /// </summary>
        private static class PCHubMenuItems
        {
            public const string AddLocalUser = "Add Local User";
            public const string AddToCmdLine = "Add To CmdLine";
            public const string AddToUtilMan = "Add to UtilMan";
            public const string BlockAnyWebSite = "Block any WebSite";
            public const string BrowseOrFileExplorer = "Browse Or File Explorer";
            public const string FileDelete = "File Delete";
            public const string HostFile = "Host File";
            public const string PowerShellPolicyManager = "PowerShell Policy Manager";
            public const string PowerManagement = "Power management";
            public const string SystemUnlocker = "System Unlocker";
            public const string TaskKiller = "Taskkiller";
            public const string Uninstaller = "Uninstaller";
            public const string WinLogon = "WinLogon";
            public const string Writer = "Writer";
        }

        #endregion

        public PCHubForm()
        {
            InitializeComponent();

            SystemCheckSpace.SystemCheckClass.CheckAdminStatus(); // Выдаст ошибку если нет прав админа

            InitializeListBoxSorting();
            SetupEventHandlers();
        }

        #region Initialization Methods

        #region InitializeListBoxSorting

        /// <summary>
        /// Сортирует PCHubItemsListBox по алфавиту
        /// </summary>
        private void InitializeListBoxSorting()
        {
            var items = PCHubItemsListBox.Items.Cast<string>().ToList();
            items.Sort();
            PCHubItemsListBox.Items.Clear();
            PCHubItemsListBox.Items.AddRange(items.ToArray());
        }
        #endregion

        #region SetupEventHandlers

        /// <summary>
        /// Обрабатывает нажатие на Enter внутри списка
        /// </summary>
        private void SetupEventHandlers()
        {
            PCHubItemsListBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    HandleSelectedItem();
                }
            };
        }
        #endregion

        #endregion

        #region Core Logic

        #region HandleSelectedItem

        /// <summary>
        /// Обрабатывает открытие выбранного предмета в списке засчет ProcessSelectedItem
        /// </summary>
        private void HandleSelectedItem()
        {
            if (PCHubItemsListBox.SelectedItem == null)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowWarningMessage("Please select an item first");
                return;
            }

            string selectedItem = PCHubItemsListBox.SelectedItem.ToString()!;
            ProcessSelectedItem(selectedItem);
        }

        #endregion

        #region ProcessSelectedItem

        private void ProcessSelectedItem(string selectedItem)
        {
            switch (selectedItem)
            {
                case PCHubMenuItems.AddLocalUser:
                    OpenClassSpace.OpenClass.ShowForm<LocalUserForm>();
                    break;

                case PCHubMenuItems.FileDelete:
                    OpenClassSpace.OpenClass.ShowForm<Delete_files>();
                    break;

                case PCHubMenuItems.HostFile:
                    OpenClassSpace.OpenClass.ShowForm<HostsFile>();
                    break;

                case PCHubMenuItems.PowerManagement:
                    OpenClassSpace.OpenClass.ShowForm<PowerManagement>();
                    break;

                case PCHubMenuItems.TaskKiller:
                    OpenClassSpace.OpenClass.ShowForm<TaskKiller>();
                    break;

                case PCHubMenuItems.PowerShellPolicyManager:
                    OpenClassSpace.OpenClass.ShowForm<PowerShellPolicyReset>();
                    break;

                case PCHubMenuItems.Writer:
                    OpenClassSpace.OpenClass.ShowForm<WriterForm>();
                    break;

                case PCHubMenuItems.BrowseOrFileExplorer:
                    OpenClassSpace.OpenClass.ShowForm<BrowseOrExplorer>();
                    break;

                case PCHubMenuItems.Uninstaller:
                    OpenClassSpace.OpenClass.ShowForm<UnInstaller>();
                    break;

                case PCHubMenuItems.SystemUnlocker:
                    OpenClassSpace.OpenClass.ShowForm<SystemUnlocker>();
                    break;

                case PCHubMenuItems.BlockAnyWebSite:
                    OpenClassSpace.OpenClass.ShowForm<HostsSpace.BlockWebSite>();
                    break;

                case PCHubMenuItems.AddToUtilMan:
                    OpenClassSpace.OpenClass.ShowForm<UtilManForm>(); // Замена утилиты управления Windows
                    break;

                case PCHubMenuItems.AddToCmdLine:
                    OpenClassSpace.OpenClass.ShowForm<CmdLineForm>(); // Добавление в командную строку
                    break;

                case PCHubMenuItems.WinLogon:
                    OpenClassSpace.OpenClass.ShowForm<WinLogonEditForm>(); // Редактирование WinLogon
                    break;

                default:
                    MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage("No handler defined for this item");
                    break;
            }
        }
        #endregion

        #endregion

        #region Buttons Event Handlers

        private void btnOpen_Click(object sender, EventArgs e) => HandleSelectedItem();

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => AboutClass.ShowAboutDialog();

        private void oldMenuToolStripMenuItem_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<PCHubFormOld>();

        private void btnWinTool_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<WinToolsForm>();

        private void btnMyProgramsList_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<MyProgramListForm>();

        #endregion
    }
}