// ----------------------------------------------------------------------------------------------
// Copyright (c) Mårten Rånge.
// ----------------------------------------------------------------------------------------------
// This source code is subject to terms and conditions of the Microsoft Public License. A 
// copy of the license can be found in the License.html file at the root of this distribution. 
// If you cannot locate the  Microsoft Public License, please send an email to 
// dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
//  by the terms of the Microsoft Public License.
// ----------------------------------------------------------------------------------------------
// You must not remove this notice, or any other, from this software.
// ----------------------------------------------------------------------------------------------

using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WordFinder
{
    public partial class CellElement : DependencyObject
    {

        partial void Coerce_Value(string value, ref string coercedValue)
        {
            coercedValue = (value ?? "").ToUpper();
        }

    }

    partial class MainWindow
    {
        Finder m_finder;

        partial void Constructed__MainWindow()
        {
            InitializeComponent();

            m_finder = new Finder();

            Cells = Enumerable
                .Range(0, 16)
                .Select(i => new CellElement {Index = i})
                .ToArray()
                ;
        }

        void Click_FindWords(object sender, RoutedEventArgs e)
        {
        }

        void KeyUp_TextBox(object sender, KeyEventArgs e)
        {
            var tb = e.OriginalSource as TextBox;
            if (tb == null)
            {
                return;
            }

            if (e.Key == Key.Return || e.Key == Key.Enter)
            {
                var req = new TraversalRequest(FocusNavigationDirection.Next);
                tb.MoveFocus(req);
            }
        }                      

    }
}
