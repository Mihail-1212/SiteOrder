using SiteOrder.db_context;
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
    /// Логика взаимодействия для EditSampleSiteContent.xaml
    /// </summary>
    public partial class EditSampleSiteContent : TabItemContentParent
    {
        private SampleSite sampleSite;
        private bool createFlag = false;

        public EditSampleSiteContent(TabItemParent mainTabItem, SampleSite sampleSite = null) : base(mainTabItem)
        {
            InitializeComponent();
            if (sampleSite == null)
            {
                sampleSite = new SampleSite();
                createFlag = true;
            }
            this.DataContext = this.sampleSite = sampleSite;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сохранить информацию о данном примерном сайте?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                StringBuilder errors = new StringBuilder();

                if (
                    String.IsNullOrWhiteSpace(siteURL.Text) 
                    )
                {
                    errors.AppendLine("Вы не заполнили одно или несколько важных полей!");
                }

                if (!Helper.IsValidURL(siteURL.Text))
                {
                    errors.AppendLine("Вы ввели неправильный сайт!");
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
                    SitesCreateEntities.GetContext().SampleSite.Add(sampleSite);
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
