using SiteOrder.db_context;
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
    /// Логика взаимодействия для UserListContent.xaml
    /// </summary>
    public partial class UserListContent : TabItemContentParent
    {
        public UserListContent(TabItemParent mainTabItem) : base(mainTabItem)
        {
            InitializeComponent();
            Update();
        }

        public override void Update()
        {
            this.datagridUserList.ItemsSource = null;
            this.datagridUserList.ItemsSource = SitesCreateEntities.GetContext().User.ToList().Where(v => v.login != MainTabItem.MainWindow.User.login);
        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            MainTabItem.AddChildUserControl(new EditUserContent(MainTabItem));
        }

        private void buttonUserEdit_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = (User)((Button)sender).DataContext;
            MainTabItem.AddChildUserControl(new EditUserContent(MainTabItem, currentUser));
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            var deletedObjects = datagridUserList.SelectedItems.Cast<User>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {deletedObjects.Count()} элементов?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    SitesCreateEntities.GetContext().User.RemoveRange(deletedObjects);
                    SitesCreateEntities.GetContext().SaveChanges();
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
                    Update();
                }
            }
        }
    }
}
