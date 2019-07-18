using System;
using Allors.Excel;
using Allors.Workspace.Domain;
using Microsoft.Office.Tools.Ribbon;
using Nito.AsyncEx;

namespace ExcelAddIn
{
    public partial class Ribbon
    {
        private Commands Commands { get; set; }

        private Sheets Sheets { get; set; }

        private UserConfiguration UserConfiguration { get; set; }

        public void Init(Commands commands, Sheets sheets, Mediator mediator, UserConfiguration userConfiguration)
        {
            this.Sheets = sheets;
            this.Commands = commands;
            this.UserConfiguration = userConfiguration;

            this.HandleDisplays();

            mediator.StateChanged += this.MediatorOnStateChanged;
        }

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
        }
        
        private void MediatorOnStateChanged(object sender, EventArgs eventArgs)
        {
            var sheet = this.Sheets?.ActiveSheet;
            var existSheet = sheet != null;
            var isLoggedIn = Globals.ThisAddIn.AddInManager.IsLoggedIn;

            //this.saveButton.Enabled = existSheet && this.Commands.CanSave;
            this.refreshButton.Enabled = isLoggedIn && existSheet && this.Commands.CanRefresh;
            this.peopleButton.Enabled = isLoggedIn && (this.UserConfiguration.IsAdministrator);
        }

        private void EnsureAddInManager()
        {
            AsyncContext.Run(
                async () =>
                {
                    if (Globals.ThisAddIn.AddInManager == null || Globals.ThisAddIn.AddInManager.IsLoggedIn == false)
                    {
                        Globals.ThisAddIn.InitAddInManager();
                    }
                });
        }

        private void ButtonLogoff_Click(object sender, RibbonControlEventArgs eventArgs)
        {
            try
            {
                if (Globals.ThisAddIn.AddInManager == null)
                {
                    this.EnsureAddInManager();

                    this.labelUser.Label = Globals.ThisAddIn.AddInManager.CurrentUserName;
                    this.buttonLogoff.Label = "Logoff";
                }
                else
                {
                    AsyncContext.Run(
                        async () =>
                        {
                            if (Globals.ThisAddIn.AddInManager.IsLoggedIn)
                            {
                                await Globals.ThisAddIn.AddInManager.Logoff();
                            }
                            else
                            {
                                await Globals.ThisAddIn.AddInManager.Login();
                            }
                        });

                    this.MediatorOnStateChanged(this, EventArgs.Empty);
                }
            }
            catch (Exception e)
            {
                e.Handle();
            }
            finally
            {
                this.HandleDisplays();
            }
        }

        private void HandleDisplays()
        {
            if (Globals.ThisAddIn?.AddInManager?.IsLoggedIn == true)
            {
                this.labelUser.Label = Globals.ThisAddIn.AddInManager.CurrentUserName;
                this.buttonLogoff.Label = "Logoff";
            }
            else
            {
                this.labelUser.Label = "Not Logged in.";
                this.buttonLogoff.Label = "Login";
            }

            this.RibbonUI.ActivateTab(this.customTab.ControlId.ToString());
        }

        private void RefreshButton_Click(object sender, RibbonControlEventArgs eventArgs)
        {
            try
            {
                this.EnsureAddInManager();

                AsyncContext.Run(
                    async () =>
                    {

                        if (this.Commands != null)
                        {
                            await this.Commands.Refresh();
                        }
                    });
            }
            catch (Exception e)
            {
                e.Handle();
            }
        }

        private void PeopleInitializeButton_Click(object sender, RibbonControlEventArgs eventArgs)
        {
            try
            {
                AsyncContext.Run(
                    async () =>
                    {
                        if (this.Commands != null)
                        {
                            await this.Commands.PeopleNew();
                        }
                    });
            }
            catch (Exception e)
            {
                e.Handle();
            }
            finally
            {
                this.HandleDisplays();
            }
        }
    }
}
