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

namespace WordFinder
{
    public partial class MainWindow
    {
        readonly Finder m_finder;
        readonly Cell[] m_cells;

        public MainWindow()
        {
            InitializeComponent();

            m_finder = new Finder();
            m_cells = new[]
                          {
                              "D",
                              "D",
                              "A",
                              "E",
                              "R",
                              "R",
                              "ST",
                              "N",
                              "G",
                              "A",
                              "M",
                              "I",
                              "A",
                              "Y",
                              "K",
                              "D",
                          }
                .Select(v => new Cell(v))
                .ToArray()
                ;

            var words = m_finder
                .FindAllWords(m_cells, 4, 4)
                .OrderByDescending(c => c.Length)
                .ToArray()
                ;

            Trace.WriteLine(words.Length);
        }
    }
}
