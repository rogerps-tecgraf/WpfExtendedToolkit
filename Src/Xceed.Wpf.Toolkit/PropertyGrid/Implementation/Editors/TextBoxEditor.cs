﻿/*************************************************************************************
   
   Toolkit for WPF

   Copyright (C) 2007-2018 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus Edition at https://xceed.com/xceed-toolkit-plus-for-wpf/

   Stay informed: follow @datagrid on Twitter or Like http://facebook.com/datagrids

  ***********************************************************************************/

using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;
#if !VS2008
using System.ComponentModel.DataAnnotations;
#endif

namespace Xceed.Wpf.Toolkit.PropertyGrid.Editors
{
  public class TextBoxEditor : TypeEditor<WatermarkTextBox>
  {
    protected override WatermarkTextBox CreateEditor()
    {
      return new PropertyGridEditorTextBox();
    }

#if !VS2008
    protected override void SetControlProperties( PropertyItem propertyItem )
    {
      var displayAttribute = PropertyGridUtilities.GetAttribute<DisplayAttribute>( propertyItem.PropertyDescriptor );
      if( displayAttribute != null )
      {
        this.Editor.Watermark = displayAttribute.GetPrompt();
      }
    }
#endif

    protected override void SetValueDependencyProperty()
    {
      ValueProperty = TextBox.TextProperty;
    }

    protected override void ResolveValueBinding(PropertyItem propertyItem)
    {
      var _binding = new Binding("Value");
      _binding.Source = propertyItem;
      _binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
      _binding.Mode = propertyItem.IsReadOnly ? BindingMode.OneWay : BindingMode.TwoWay;
      _binding.Converter = CreateValueConverter();
      BindingOperations.SetBinding(Editor, ValueProperty, _binding);
    }
  }

  public class PropertyGridEditorTextBox : WatermarkTextBox
  {
    static PropertyGridEditorTextBox()
    {
      DefaultStyleKeyProperty.OverrideMetadata( typeof( PropertyGridEditorTextBox ), new FrameworkPropertyMetadata( typeof( PropertyGridEditorTextBox ) ) );
    }
  }
}
