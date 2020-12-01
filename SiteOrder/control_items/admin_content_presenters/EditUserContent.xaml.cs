using SiteOrder.db_context;
using SiteOrder.dialog_windows;
using SiteOrder.helper;
using SiteOrder.overridden_controls;
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

namespace SiteOrder.control_items.admin_content_presenters
{
    /// <summary>
    /// Логика взаимодействия для EditUserContent.xaml
    /// </summary>
    public partial class EditUserContent : TabItemContentParent
    {
        private User user;
        private bool createFlag = false;

        public EditUserContent(TabItemParent mainTabItem, User user = null) : base(mainTabItem)
        {
            InitializeComponent();
            if (user == null)
            {
                user = new User();
                createFlag = true;
                buttonPasswordChange.Content = "Установить пароль";
            }
            this.DataContext = this.user = user;

            if (user.isAdministrator)
            {
                buttonPasswordChange.Visibility = Visibility.Hidden;
            }
        }

        public override void Update()
        {
           
        }

        private void buttonPasswordChange_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы хотите сменить пароль?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var dialogEnterNewPassword = new Dialog("Введите новый пароль");
                if (dialogEnterNewPassword.ShowDialog() == true)
                {
                    var newPassword = dialogEnterNewPassword.Answer;
                    StringBuilder errors = new StringBuilder();
                    if (!Helper.IsTextAllowed(newPassword) || newPassword.Length < 6)
                    {
                        errors.AppendLine("Введенный пароль не соответствует требованиям! Пароль должен состоять из английских букв, знака подчеркивания, тире и цифр, а также длина должна быть не меньше 6 символов!");
                    }
                    if (errors.Length != 0)
                    {
                        MessageBox.Show(errors.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    user.password = Helper.MD5Hash(newPassword);
                    MessageBox.Show("Пароль успешно задан!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сохранить информацию о данном пользователе?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                StringBuilder errors = new StringBuilder();

                if (
                    String.IsNullOrWhiteSpace(surname.Text) ||
                    String.IsNullOrWhiteSpace(name.Text) ||
                    String.IsNullOrWhiteSpace(login.Text)
                    )
                {
                    errors.AppendLine("Вы не заполнили одно или несколько важных полей!");
                }

                if (String.IsNullOrWhiteSpace(user.password))
                {
                    errors.AppendLine("Вы не создали пароль!");
                }

                if (errors.Length != 0)
                {
                    MessageBox.Show(
                        errors.ToString(),
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }


                if (createFlag)
                {
                    SitesCreateEntities.GetContext().User.Add(user);
                }

                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
                    MessageBox.Show(
                        "Данные успешно сохранены!",
                        "Success",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    MainTabItem.ExecuteShowPrevPage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }
    }
}
