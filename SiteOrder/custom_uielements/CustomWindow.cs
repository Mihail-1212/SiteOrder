using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SiteOrder.custom_uielements;

namespace SiteOrder.templates
{
    public class CustomWindow : Window, INotifyPropertyChanged
    {
        public static RoutedCommand logoutCommand = new RoutedCommand();

        public static RoutedCommand profileCheckCommand = new RoutedCommand();

        public static RoutedCommand profileAuthorization = new RoutedCommand();

        public static RoutedCommand profileRegistration = new RoutedCommand();

        public static RoutedCommand goToAuthOrReg = new RoutedCommand();

        public static RoutedCommand backPage = new RoutedCommand();

        public static void ExecutebackPage()
        {
            backPage.Execute(null, null);
        }

        public static void ExecuteLogout()
        {
            logoutCommand.Execute(null, null);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private UserControl popupControl;

        public  UserControl PopupControl
        {
            get
            {
                if (popupControl == null)
                    popupControl = new Authorization();
                return popupControl;
            }
            set
            {
                popupControl = value;
                NotifyPropertyChanged();
            }
        }

        private CommandBinding commandBindingBackPage;

        public CommandBinding CommandBindingBackPage
        {
            get
            {
                if (commandBindingBackPage == null)
                {
                    commandBindingBackPage = new CommandBinding();
                    commandBindingBackPage.Command = CustomWindow.backPage;
                    commandBindingBackPage.CanExecute += (sender, e) => e.CanExecute = true;
                    this.CommandBindings.Add(commandBindingBackPage);
                }
                return commandBindingBackPage;
            }
            set
            {
                
                commandBindingBackPage = value;
            }
        }

        private CommandBinding commandBindingProfileAuthorization;

        public CommandBinding CommandBindingProfileAuthorization
        {
            get
            {
                if (commandBindingProfileAuthorization == null)
                {
                    commandBindingProfileAuthorization = new CommandBinding();
                    commandBindingProfileAuthorization.Command = CustomWindow.profileAuthorization;
                    commandBindingProfileAuthorization.CanExecute += (sender, e) => e.CanExecute = true;
                    this.CommandBindings.Add(commandBindingProfileAuthorization);
                }
                return commandBindingProfileAuthorization;
            }
            private set
            {
                commandBindingProfileAuthorization = value;
            }
        }

        //  profileRegistration
        private CommandBinding commandBindingProfileRegistration;

        public CommandBinding CommandBindingProfileRegistration
        {
            get
            {
                if (commandBindingProfileRegistration == null)
                {
                    commandBindingProfileRegistration = new CommandBinding();
                    commandBindingProfileRegistration.Command = CustomWindow.profileRegistration;
                    commandBindingProfileRegistration.CanExecute += (sender, e) => e.CanExecute = true;
                    this.CommandBindings.Add(commandBindingProfileRegistration);
                }
                return commandBindingProfileRegistration;
            }
            private set
            {
                commandBindingProfileRegistration = value;
            }
        }

        //  goToAuthOrReg

        private CommandBinding commandBindingGoToAuthOrReg;

        public CommandBinding CommandBindingGoToAuthOrReg
        {
            get
            {
                if (commandBindingGoToAuthOrReg == null)
                {
                    commandBindingGoToAuthOrReg = new CommandBinding();
                    commandBindingGoToAuthOrReg.Command = CustomWindow.goToAuthOrReg;
                    commandBindingGoToAuthOrReg.CanExecute += (sender, e) => e.CanExecute = true;
                    this.CommandBindings.Add(commandBindingGoToAuthOrReg);
                }
                return commandBindingGoToAuthOrReg;
            }
            private set
            {
                commandBindingGoToAuthOrReg = value;
            }
        }


        private CommandBinding commandBindingProfileCheck;

        public CommandBinding CommandBindingProfileCheck
        {
            get
            {
                if (commandBindingProfileCheck == null)
                {
                    commandBindingProfileCheck = new CommandBinding();
                    commandBindingProfileCheck.Command = CustomWindow.profileCheckCommand;
                    commandBindingProfileCheck.CanExecute += CommandBindingLogout_CanExecute;
                    this.CommandBindings.Add(commandBindingProfileCheck);
                }
                return commandBindingProfileCheck;
            }
            private set
            {
                commandBindingProfileCheck = value;
            }
        }

        private CommandBinding commandBindingLogout;

        public CommandBinding CommandBindingLogout
        {
            get
            {
                if (commandBindingLogout == null)
                {
                    commandBindingLogout = new CommandBinding();
                    commandBindingLogout.Command = CustomWindow.logoutCommand;
                    commandBindingLogout.CanExecute += CommandBindingLogout_CanExecute;
                    this.CommandBindings.Add(commandBindingLogout);
                }
                return commandBindingLogout;
            }
            private set
            {
                commandBindingLogout = value;
            }
        }

        private void CommandBindingLogout_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public CustomWindow()
        {
            CommandBinding commandBindingClose = new CommandBinding();

            commandBindingClose.Command = SystemCommands.CloseWindowCommand;
            commandBindingClose.CanExecute += CommandBinding_CanExecute;
            commandBindingClose.Executed += CommandBinding_Executed;

            this.CommandBindings.Add(commandBindingClose);

            CommandBinding commandBindingMaximize = new CommandBinding();

            commandBindingMaximize.Command = SystemCommands.MaximizeWindowCommand;
            commandBindingMaximize.CanExecute += CommandBinding_CanExecute;
            commandBindingMaximize.Executed += CommandBinding_Executed_1;

            this.CommandBindings.Add(commandBindingMaximize);

            CommandBinding commandBindingRestore = new CommandBinding();

            commandBindingRestore.Command = SystemCommands.RestoreWindowCommand;
            commandBindingRestore.CanExecute += CommandBinding_CanExecute;
            commandBindingRestore.Executed += CommandBinding_Executed_2;

            this.CommandBindings.Add(commandBindingRestore);

            CommandBinding commandBindingMinimize = new CommandBinding();

            commandBindingMinimize.Command = SystemCommands.MinimizeWindowCommand;
            commandBindingMinimize.CanExecute += CommandBinding_CanExecute;
            commandBindingMinimize.Executed += CommandBinding_Executed_3;

            this.CommandBindings.Add(commandBindingMinimize);

            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);

        }

        private void CommandBinding_Executed_2(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
        }

        private void CommandBinding_Executed_3(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
    }
}
