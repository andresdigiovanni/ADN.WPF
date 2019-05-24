using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ADN.WPF.Helpers
{
    public static class TreeViewItemHelper
    {
        public static void TreeViewItem_ExpandOnClick(object sender, RoutedEventArgs e)
        {
            var tvi = e.OriginalSource as TreeViewItem;

            if (tvi == null || e.Handled) return;

            tvi.IsExpanded = !tvi.IsExpanded;
            tvi.IsSelected = false;
            e.Handled = true;
        }
    }
}
