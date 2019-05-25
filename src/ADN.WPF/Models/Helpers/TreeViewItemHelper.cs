using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ADN.WPF.Helpers
{
    /// <summary>
    /// Provides utilities to <see cref="TreeView"/> control.
    /// </summary>
    public static class TreeViewItemHelper
    {
        /// <summary>
        /// Expands the clicked item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <example>
        /// <code>
        /// /* Add the property in your TreeView (.xaml) */
        /// 
        /// <![CDATA[<TreeView TreeViewItem.Selected="TreeViewItem_ExpandOnClick">]]>
        /// 
        /// /* In your .xaml.cs */
        /// 
        /// private void TreeViewItem_ExpandOnClick(object sender, RoutedEventArgs e)
        /// {
        ///     TreeViewItemHelper.TreeViewItem_ExpandOnClick(sender, e);
        /// }
        /// </code>
        /// </example>
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
