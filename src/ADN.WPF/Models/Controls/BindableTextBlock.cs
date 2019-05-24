﻿using System;
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
    public class BindableTextBlock : TextBlock
    {
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

        public static readonly DependencyProperty InlineListProperty =
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
