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

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using WordFinder.Source.Collections;
using WordFinder.Source.Extensions;

namespace WordFinder
{
    namespace Source.Collections
    {
        partial class TrieMap<TValue>
        {
            public Node Root
            {
                get { return m_root; }
            }

            public  partial class Node
            {
                
            }

        }
    }
    sealed class Cell
    {
        public readonly string Value;

        public bool Seen;

        public Cell(string value)
        {
            Value = value ?? "";
        }
    }

    sealed class Word
    {
        public readonly string Value;
        public readonly string Flag;

        public Word(string value, string flag)
        {
            Value = value ?? "";
            Flag = flag ?? "";
        }
    }

    sealed class Finder
    {
        readonly TrieMap<Word> m_words = new TrieMap<Word>();

        public Finder()
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var dictionary = executingAssembly
                .GetResourceString(@"WordFinder.Dictionary.sv_SE.dic")
                ;
            using (var stringReader = new StringReader(dictionary))
            {
                var lines = stringReader
                    .ReadLines()
                    .Skip(1)
                    .ToArray()
                    ;

                foreach (var line in lines)
                {
                    var word = GetWord(line);
                    if (word != null)
                    {
                        m_words.AddOrReplace(word.Value, word);
                    }
                }

                // m_words.Optimize();
            }
        }

        public HashSet<string> FindAllWords(Cell[] cells, int width, int height)
        {
            var result = new HashSet<string>();
            if (cells == null)
            {
                return result;
            }

            var count = width*height;
            if (cells.Length != count)
            {
                return result;
            }

            var nexts = Enumerable
                .Range(0, count)
                .Select(i => GetNext(i, width, height))
                .ToArray()
                ;

            for (var iter = 0; iter < count; ++iter)
            {
                FindWords(
                    result, 
                    m_words.Root,
                    nexts,
                    cells,
                    iter
                    );
            }

            return result;
        }

        void FindWords(
            HashSet<string> result,
            TrieMap<Word>.Node node,
            int[][] nexts,
            Cell[] cells,
            int iter
            )
        {
            var nextNode = node;

            var cell = cells[iter];
            if (cell.Seen)
            {
                return;
            }

            cell.Seen = true;
            try
            {

                var value = cell.Value;
                for (var index = 0; index < value.Length; index++)
                {
                    var ch = value[index];
                    nextNode = nextNode.FindEdge(ch);
                    if (nextNode == null)
                    {
                        return;
                    }

                    if (nextNode.Value != null && nextNode.Value.Value.Length >= 3)
                    {
                        result.Add(nextNode.Value.Value);
                    }
                }

                var next = nexts[iter];

                for (int index = 0; index < next.Length; index++)
                {
                    var off = next[index];

                    FindWords(
                        result,
                        nextNode,
                        nexts,
                        cells,
                        iter + off
                        );
                }
            }
            finally
            {
                cell.Seen = false;
            }
        }


        int[] GetNext(int i, int width, int height)
        {
            var x = i%width;
            var y = i/width;

            var next = new List<int>(8);
            if (y > 0)
            {
                if (x > 0)
                {
                    next.Add(-1 - width);
                }
                next.Add(-width);
                if (x < width - 1)
                {
                    next.Add(1 - width);
                }
            }

            if (x > 0)
            {
                next.Add(-1);
            }
            if (x < width - 1)
            {
                next.Add(1);
            }

            if (y < height - 1)
            {
                if (x > 0)
                {
                    next.Add(-1 + width);
                }
                next.Add(width);
                if (x < width - 1)
                {
                    next.Add(1 + width);
                }
            }

            return next.ToArray();
        }

        static Word GetWord(string line)
        {
            var ls = line.Split('/');
            if (ls.Length == 1)
            {
                return new Word(ls[0], "");
            }
            else if (ls.Length > 1)
            {
                return new Word(ls[0], ls[1]);
            }
            else
            {
                return null;
            }


        }
    }
}
