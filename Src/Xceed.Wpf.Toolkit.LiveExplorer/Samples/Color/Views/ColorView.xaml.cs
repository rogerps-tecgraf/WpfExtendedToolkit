﻿/*************************************************************************************

   Toolkit for WPF

   Copyright (C) 2007-2018 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus Edition at https://xceed.com/xceed-toolkit-plus-for-wpf/

   Stay informed: follow @datagrid on Twitter or Like http://facebook.com/datagrids

  ***********************************************************************************/

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Xceed.Wpf.Toolkit.LiveExplorer.Samples.Color.Views
{
  /// <summary>
  /// Interaction logic for ColorView.xaml
  /// </summary>
  public partial class ColorView : DemoView
  {
    public ColorView()
    {
      InitializeComponent();
    }

        private void button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _colorPicker.SelectedColor = null;
        }
    }
}
