# ADN.WPF

# Content

- [Controls.BindableTextBlock](#T:ADN.WPF.Controls.BindableTextBlock)

  - [.InlineList](#P:ADN.WPF.Controls.BindableTextBlock.InlineList)

- [Helpers.TreeViewItemHelper](#T:ADN.WPF.Helpers.TreeViewItemHelper)

  - [TreeViewItem_ExpandOnClick(sender, e)](#Helpers.TreeViewItemHelper.TreeViewItem_ExpandOnClick(sender,e))

<a name='T:ADN.WPF.Controls.BindableTextBlock'></a>


## Controls.BindableTextBlock

Control that extends functionality providing a bindable control.

<a name='P:ADN.WPF.Controls.BindableTextBlock.InlineList'></a>


### .InlineList

Control content.


#### Example

```csharp
/* Create the control in your .xaml */

<BindableTextBlock InlineList="{Binding Path=<your_property>}"/>```

<a name='T:ADN.WPF.Helpers.TreeViewItemHelper'></a>


## Helpers.TreeViewItemHelper

Provides utilities to control.

<a name='Helpers.TreeViewItemHelper.TreeViewItem_ExpandOnClick(sender,e)'></a>


### TreeViewItem_ExpandOnClick(sender, e)

Expands the clicked item.


#### Parameters

| Name | Description |
| ---- | ----------- |
| sender | *System.Object*<br> |

#### Parameters

| e | *System.Windows.RoutedEventArgs*<br> |


#### Example

```csharp
/* Add the property in your TreeView (.xaml) */

<TreeView TreeViewItem.Selected="TreeViewItem_ExpandOnClick">

/* In your .xaml.cs */

private void TreeViewItem_ExpandOnClick(object sender, RoutedEventArgs e)
{
TreeViewItemHelper.TreeViewItem_ExpandOnClick(sender, e);
}
```

