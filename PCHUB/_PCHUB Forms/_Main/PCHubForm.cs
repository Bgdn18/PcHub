using System.Windows.Forms;
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
        public PCHubForm()
        {
            InitializeComponent();

            PCHubItemsListBox.KeyDown += (s, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        btnOpen_Click(null!, null!);
                        break;
                }

                switch (e.KeyCode)
                {
                    case Keys.OemPeriod:
                        OpenClassSpace.OpenClass.ShowForm<HelpForm>();
                        break;
                }
            };


            var items = PCHubItemsListBox.Items.Cast<string>().ToList();
            items.Sort();
            PCHubItemsListBox.Items.Clear();
            PCHubItemsListBox.Items.AddRange(items.ToArray());
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (PCHubItemsListBox.SelectedItem == null)
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowWarningMessage("Please select an item first");
                return;
            }

            string selectedItem = PCHubItemsListBox.SelectedItem.ToString()!;

            switch (selectedItem)
            {
                case "Add Local User":
                    OpenClassSpace.OpenClass.ShowForm<LocalUserForm>();
                    break;

                case "File Delete":
                    OpenClassSpace.OpenClass.ShowForm<Delete_files>();
                    break;

                case "Host File":
                    OpenClassSpace.OpenClass.ShowForm<HostsFile>();
                    break;

                case "Power management":
                    OpenClassSpace.OpenClass.ShowForm<PowerManagement>();
                    break;

                case "Taskkiller":
                    OpenClassSpace.OpenClass.ShowForm<TaskKiller>();
                    break;

                case "PowerShell Policy Manager":
                    OpenClassSpace.OpenClass.ShowForm<PowerShellPolicyReset>();
                    break;

                case "Writer":
                    OpenClassSpace.OpenClass.ShowForm<WriterForm>();
                    break;

                case "Taskmgr Or Resmon":
                    OpenClassSpace.OpenClass.ShowForm<ResmonOrTaskmgr>();
                    break;

                case "Browse Or File Explorer":
                    OpenClassSpace.OpenClass.ShowForm<BrowseOrExplorer>();
                    break;

                case "Uninstaller":
                    OpenClassSpace.OpenClass.ShowForm<UnInstaller>();
                    break;

                case "System Unlocker":
                    OpenClassSpace.OpenClass.ShowForm<SystemUnlocker>();
                    break;

                case "Block any WebSite":
                    OpenClassSpace.OpenClass.ShowForm<HostsSpace.BlockWebSite>();
                    break;

                case "Add to UtilMan":
                    OpenClassSpace.OpenClass.ShowForm<UtilManForm>();
                    break;

                case "Add To CmdLine WinLogon":
                    OpenClassSpace.OpenClass.ShowForm<WinLogonEditForm>();
                    break;

                default:
                    MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage("No handler defined for this item");
                    break;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => AboutClass.ShowAboutDialog();

        private void customProgramsToolStripMenuItem_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<MyProgramListForm>();

        private void winToolsToolStripMenuItem_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<WinToolsForm>();

        private void oldMenuToolStripMenuItem_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<PCHubFormOld>();
    }
}
