using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SiteOrder.overridden_controls
{
    public class TabItemParent : TabItem
    {
        private List<TabItemContentParent> childrenUserControls;

        private MainWindow mainWindow;

        public TabItemParent(MainWindow mainWindow) : base()
        {
            childrenUserControls = new List<TabItemContentParent>();
            this.mainWindow = mainWindow;
        }

        protected List<TabItemContentParent> ChildrenUserControls => childrenUserControls;

        public MainWindow MainWindow => mainWindow;

        protected void ShowPrevPage()
        {
            if (this.FindName("MainTabItemContentPresenter") != null && childrenUserControls.Count > 1)
            {
                childrenUserControls.RemoveAt(childrenUserControls.Count - 1);
                childrenUserControls.Last().Update();
                ((ContentPresenter)this.FindName("MainTabItemContentPresenter")).Content = childrenUserControls.Last();
            }
        }

        public bool AddChildUserControl(TabItemContentParent childUserControl)
        {
            if (this.FindName("MainTabItemContentPresenter") != null)
            {
                if (childrenUserControls.Contains(childUserControl))
                {
                    return false;
                }
                childrenUserControls.Add(childUserControl);
                ((ContentPresenter)this.FindName("MainTabItemContentPresenter")).Content = childUserControl;
                return true;
            }
            return false;
        }

        public void ExecuteShowPrevPage()
        {
            MainWindow.ExecutebackPage();
        }

        public void ExecuteLogout()
        {
            MainWindow.ExecuteLogout();
        }
    }
}
