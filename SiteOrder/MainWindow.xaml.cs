using SiteOrder.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SiteOrder.custom_uielements;
using SiteOrder.db_context;
using SiteOrder.helper;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls.Primitives;
using SiteOrder.control_items;
using SiteOrder.tab_items;
using SiteOrder.control_items.main_content_presenters;

namespace SiteOrder
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : CustomWindow
    {
        private string _count_sites;    // количество сайтов
        private User user;

        public MainWindow()
        {
            InitializeComponent();
            this.CommandBindingLogout.Executed += CommandBindingLogout_Executed;
            this.CommandBindingProfileCheck.Executed += CommandBindingProfileCheck_Executed;
            this.CommandBindingProfileAuthorization.Executed += CommandBindingProfileAuthorization_Executed;
            this.CommandBindingProfileRegistration.Executed += CommandBindingProfileRegistration_Executed;
            this.CommandBindingGoToAuthOrReg.Executed += CommandBindingGoToAuthOrReg_Executed;

            this.CommandBindingBackPage.Executed += CommandBindingBackPage_Executed;
            Update();
            UpdateMainTabControl();
            // this.CommandBindingBackPage.Executed += (s, e) => MessageBox.Show("asda");   // go to back button
        }

        /// <summary>
        /// Executed => NotifyPropertyChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBindingBackPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NotifyPropertyChanged();
        }

        public User User
        {
            get => user;
            private set
            {
                user = value;
                UpdateMainTabControl();
                NotifyPropertyChanged();
            }
        }

        public void ReloadUser()
        {
            var nullUser = User;
            User = null;
            User = nullUser;
        }

        public string Count_Sites
        {
            get => _count_sites;
            set
            {
                _count_sites = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Updating all page
        /// </summary>
        private void Update()
        {
            // MainLayoutTemplates -> update
            //  Count_Sites = SitesCreateEntities.GetContext().Site.Count().ToString();
        }

        private void UpdateMainTabControl()
        {
            MainTabControl.Items.Clear();
            MainTabControl.Items.Add(new MainTabItem(this));
            if (User != null)
            {
                MainTabControl.Items.Add(new YourOrdersTabItem(this));
                MainTabControl.Items.Add(new ExecutorTabItem(this));    //  add executor tabitem
                if (User.isAdministrator)   //  add admin panel
                {
                    MainTabControl.Items.Add(new AdminTabItem(this));
                }
            }
            MainTabControl.UpdateLayout();
            if (MainTabControl.Items.Count != 0)
                MainTabControl.SelectedIndex = 0;
        }

        /// <summary>
        /// UserPopup Authorization click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBindingProfileAuthorization_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Authorization();
        }

        /// <summary>
        /// Go to authotization or registration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBindingGoToAuthOrReg_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (this.PopupControl is Authorization)
            {
                this.PopupControl = new Registration();
            }
            else    // if is Registration
            {
                this.PopupControl = new Authorization();
            }
        }

        /// <summary>
        /// Registration click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBindingProfileRegistration_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var loginBox = (TextBox)this.PopupControl.FindName("loginBox");
            var passwordBox = (TextBox)this.PopupControl.FindName("passwordBox");
            var passwordRepeatBox = (TextBox)this.PopupControl.FindName("passwordRepeatBox");
            StringBuilder errors = new StringBuilder();
            if( loginBox.Text.Length < 6  || passwordBox.Text.Length < 6 )
            {
                errors.AppendLine("Логин и пароль не могут быть меньше 6-ти символов!");
            }

            if (passwordBox.Text != passwordRepeatBox.Text)
            {
                errors.AppendLine("Пароли не совпадают!");
            }

            if (SitesCreateEntities.GetContext().User.ToList().Where(v => v.login == loginBox.Text).Count() != 0)
            {
                errors.AppendLine("Такой логин существует в базе данных!");
            }

            if (errors.Length != 0)
            {
                MessageBox.Show(errors.ToString(), "Errors", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                var newUser = new User();
                newUser.login = loginBox.Text;
                newUser.password = Helper.MD5Hash(passwordBox.Text);
                newUser.surname = "New";
                newUser.name = "User";
                SitesCreateEntities.GetContext().User.Add(newUser);
                SitesCreateEntities.GetContext().SaveChanges();
                CommandBindingGoToAuthOrReg_Executed(null, null);
                MessageBox.Show("Вы успешно зарегистрировались!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                SitesCreateEntities.GetContext().ClearStateAndReloadAll();
            }
        }

        private void Authorization()
        {
            var loginBox = (TextBox)this.PopupControl.FindName("loginBox");
            var passwordBox = (PasswordBox)this.PopupControl.FindName("passwordBox");
            // && v.password == Helper.MD5Hash(passwordBox.Password)
            var userList = SitesCreateEntities.GetContext().User.ToList().Where(v => v.login == loginBox.Text && v.password == Helper.MD5Hash(passwordBox.Password));
            if ( userList.Count() != 0 )
            {
                User = userList.First();
                this.PopupControl = new UserPopup();
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CommandBindingProfileCheck_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //  MessageBox.Show("Чек профиля");
            var mainTabItem = this.MainTabControl.Items.OfType<MainTabItem>().ToList().FirstOrDefault();
            if (mainTabItem != null)    // if isset MainTabItem
            {
                this.MainTabControl.SelectedItem = mainTabItem;
                if (!(mainTabItem.MainTabItemContentPresenter.Content is EditProfileContent))   // if profile is not open
                {
                    mainTabItem.AddChildUserControl(new EditProfileContent(mainTabItem));
                }
            }
        }

        private void CommandBindingLogout_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.PopupControl = new Authorization();
            User = null;
        }

        /// <summary>
        /// Проверка - выбран ли данный tabitem
        /// </summary>
        /// <param name="tabItem"></param>
        /// <returns></returns>
        public bool IsTabItemActive(TabItem tabItem)
        {
            return MainTabControl.SelectedItem == tabItem;
        }
    }
}
