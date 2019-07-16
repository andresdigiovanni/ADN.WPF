using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ADN.WPF.Controls
{
    /// <summary>
    /// Control that extends <see cref="TextBlock"/> functionality providing a bindable control.
    /// </summary>
    public class BindableTextBlock : TextBlock
    {
        /// <summary>
        /// Control content.
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// /* Create the control in your .xaml */
        /// 
        /// <![CDATA[<BindableTextBlock InlineList="{Binding Path=<your_property>}"/>]]>
        /// </code>
        /// </example>
        public ObservableCollection<Inline> InlineList
        {
            get
            {
                return (ObservableCollection<Inline>)GetValue(InlineListProperty);
            }
            set
            {
                SetValue(InlineListProperty, value);
            }
        }

        private static readonly DependencyProperty InlineListProperty =
            DependencyProperty.Register(
                "InlineList",
                typeof(ObservableCollection<Inline>),
                typeof(BindableTextBlock),
                new UIPropertyMetadata(null, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var textBlock = (BindableTextBlock)sender;
            textBlock.Inlines.Clear();
            if (e.NewValue != null)
            {
                textBlock.Inlines.AddRange((ObservableCollection<Inline>)e.NewValue);
            }
        }
    }
}
