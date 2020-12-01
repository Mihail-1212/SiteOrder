using SiteOrder.tab_items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SiteOrder.overridden_controls
{
    public class TabItemContentParent : UserControl
    {
        private TabItemParent mainTabItem;

        public TabItemContentParent(TabItemParent mainTabItem) : base()
        {
            this.mainTabItem = mainTabItem;
        }

        public TabItemParent MainTabItem => mainTabItem;


        public  virtual void Update()
        {
            throw new NotImplementedException();
        }
    }
}
