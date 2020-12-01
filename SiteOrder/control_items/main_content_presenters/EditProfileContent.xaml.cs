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

namespace SiteOrder.control_items.main_content_presenters
{
    /// <summary>
    /// Логика взаимодействия для ProfileEditContent.xaml
    /// </summary>
    public partial class EditProfileContent : TabItemContentParent
    {
        private User user;

        public EditProfileContent(TabItemParent mainTabItem) : base(mainTabItem)
        {
            InitializeComponent();
            if (MainTabItem.MainWindow.User == null)
            {
                throw new NullReferenceException("User is not authenticated");
            }
            this.DataContext = this.user = MainTabItem.MainWindow.User;
        }

        private void photo_Click(object sender, RoutedEventArgs e)
        {
            var currentButton = (Button)sender;
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == true)
            {
                string fileName = dlg.FileName;
                user.Photo = fileName;
            }
        }

        // Логин сменить нельзя!
       /* private void buttonLoginChange_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы хотите сменить логин?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var dialogEnterLogin = new Dialog("Введите существующий логин");
                if (dialogEnterLogin.ShowDialog() == true)
                {
                    if (dialogEnterLogin.Answer != user.login)
                    {
                        MessageBox.Show("Вы ввели неверный логин", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    var dialogEnterNewLogin = new Dialog("Введите новый логин");
                    if (dialogEnterNewLogin.ShowDialog() == true)
                    {
                        var newLogin = dialogEnterNewLogin.Answer;
                        StringBuilder errors = new StringBuilder();
                        if (!Helper.IsTextAllowed(newLogin) || newLogin.Length < 6)
                        {
                            errors.AppendLine("Введенный логин не соответствует требованиям! Логин должен состоять из английских букв, знака подчеркивания, тире и цифр, а также длина должна быть не меньше 6 символов!");
                        }
                        if (SitesCreateEntities.GetContext().User.ToList().Where(v => v.login == newLogin).Count() != 0)
                        {
                            errors.AppendLine("Пользователь с данным логином уже существует!");
                        }
                        if (errors.Length != 0)
                        {
                            MessageBox.Show(errors.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        try
                        {
                            user.login = newLogin;
                            SitesCreateEntities.GetContext().SaveChanges();
                            MessageBox.Show(
                                "Логин успешно изменен!",
                                "Success",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                ex.Message,
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                        }
                        finally
                        {
                            SitesCreateEntities.GetContext().ClearStateAndReloadAll();
                            MainTabItem.ExecuteShowPrevPage();
                        }
                    }
                }
            }
        }*/

        private void buttonPasswordChange_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы хотите сменить пароль?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var dialogEnterPassword = new Dialog("Введите существующий пароль");
                if (dialogEnterPassword.ShowDialog() == true)
                {
                    if (Helper.MD5Hash(dialogEnterPassword.Answer) != user.password)
                    {
                        MessageBox.Show("Вы ввели неверный пароль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
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
                        try
                        {
                            user.password = Helper.MD5Hash(newPassword);
                            SitesCreateEntities.GetContext().SaveChanges();
                            MessageBox.Show(
                                "Пароль успешно изменен!",
                                "Success",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                ex.Message,
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                        }
                        finally
                        {
                            SitesCreateEntities.GetContext().ClearStateAndReloadAll();
                            MainTabItem.ExecuteShowPrevPage();
                        }
                    }
                }
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (
                String.IsNullOrWhiteSpace(surname.Text) ||
                String.IsNullOrWhiteSpace(name.Text)
                )
            {
                errors.AppendLine("Вы не заполнили одно или несколько важных полей!");
            }
            if (!String.IsNullOrWhiteSpace(email.Text) && !Helper.IsEmailValid(email.Text))
            {
                errors.AppendLine("Email не правильный!");
            }

            if (errors.Length != 0)
            {
                MessageBox.Show(errors.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                SitesCreateEntities.GetContext().SaveChanges();
                MessageBox.Show(
                    "Данные успешно изменены!",
                    "Success",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                SitesCreateEntities.GetContext().ClearStateAndReloadAll();
                MainTabItem.ExecuteShowPrevPage();
                MainTabItem.MainWindow.ReloadUser();
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show( "Вы уверены, что хотите удалить данного пользователя?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes )
            {
                try
                {
                    SitesCreateEntities.GetContext().User.Remove(user);
                    SitesCreateEntities.GetContext().SaveChanges();
                    MessageBox.Show(
                        "Пользователь успешно удален!",
                        "Success",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    MainTabItem.ExecuteLogout();
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
