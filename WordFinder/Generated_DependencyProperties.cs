
// ############################################################################
// #                                                                          #
// #        ---==>  T H I S  F I L E  I S   G E N E R A T E D  <==---         #
// #                                                                          #
// # This means that any edits to the .cs file will be lost when its          #
// # regenerated. Changes should instead be applied to the corresponding      #
// # template file (.tt)                                                      #
// ############################################################################





// ReSharper disable InconsistentNaming
// ReSharper disable InvocationIsSkipped
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantAssignment
// ReSharper disable RedundantUsingDirective

namespace WordFinder
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;

    using System.Windows;
    using System.Windows.Media;

    // ------------------------------------------------------------------------
    // CellElement
    // ------------------------------------------------------------------------
    partial class CellElement
    {
        #region Uninteresting generated code
        public static readonly DependencyProperty IndexProperty = DependencyProperty.Register (
            "Index",
            typeof (int),
            typeof (CellElement),
            new FrameworkPropertyMetadata (
                default (int),
                FrameworkPropertyMetadataOptions.None,
                Changed_Index,
                Coerce_Index          
            ));

        static void Changed_Index (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var instance = dependencyObject as CellElement;
            if (instance != null)
            {
                var oldValue = (int)eventArgs.OldValue;
                var newValue = (int)eventArgs.NewValue;

                instance.Changed_Index (oldValue, newValue);
            }
        }


        static object Coerce_Index (DependencyObject dependencyObject, object basevalue)
        {
            var instance = dependencyObject as CellElement;
            if (instance == null)
            {
                return basevalue;
            }
            var oldValue = (int)basevalue;
            var newValue = oldValue;

            instance.Coerce_Index (oldValue, ref newValue);


            return newValue;
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register (
            "Value",
            typeof (string),
            typeof (CellElement),
            new FrameworkPropertyMetadata (
                default (string),
                FrameworkPropertyMetadataOptions.None,
                Changed_Value,
                Coerce_Value          
            ));

        static void Changed_Value (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var instance = dependencyObject as CellElement;
            if (instance != null)
            {
                var oldValue = (string)eventArgs.OldValue;
                var newValue = (string)eventArgs.NewValue;

                instance.Changed_Value (oldValue, newValue);
            }
        }


        static object Coerce_Value (DependencyObject dependencyObject, object basevalue)
        {
            var instance = dependencyObject as CellElement;
            if (instance == null)
            {
                return basevalue;
            }
            var oldValue = (string)basevalue;
            var newValue = oldValue;

            instance.Coerce_Value (oldValue, ref newValue);


            return newValue;
        }

        #endregion

        // --------------------------------------------------------------------
        // Constructor
        // --------------------------------------------------------------------
        public CellElement ()
        {
            CoerceAllProperties ();
            Constructed__CellElement ();
        }
        // --------------------------------------------------------------------
        partial void Constructed__CellElement ();
        // --------------------------------------------------------------------
        void CoerceAllProperties ()
        {
            CoerceValue (IndexProperty);
            CoerceValue (ValueProperty);
        }


        // --------------------------------------------------------------------
        // Properties
        // --------------------------------------------------------------------

           
        // --------------------------------------------------------------------
        public int Index
        {
            get
            {
                return (int)GetValue (IndexProperty);
            }
            set
            {
                if (Index != value)
                {
                    SetValue (IndexProperty, value);
                }
            }
        }
        // --------------------------------------------------------------------
        partial void Coerce_Index (int value, ref int coercedValue);
        partial void Changed_Index (int oldValue, int newValue);
        // --------------------------------------------------------------------


           
        // --------------------------------------------------------------------
        public string Value
        {
            get
            {
                return (string)GetValue (ValueProperty);
            }
            set
            {
                if (Value != value)
                {
                    SetValue (ValueProperty, value);
                }
            }
        }
        // --------------------------------------------------------------------
        partial void Coerce_Value (string value, ref string coercedValue);
        partial void Changed_Value (string oldValue, string newValue);
        // --------------------------------------------------------------------


    }
    // ------------------------------------------------------------------------

    // ------------------------------------------------------------------------
    // MainWindow
    // ------------------------------------------------------------------------
    partial class MainWindow
    {
        #region Uninteresting generated code
        public static readonly DependencyProperty CellsProperty = DependencyProperty.Register (
            "Cells",
            typeof (CellElement[]),
            typeof (MainWindow),
            new FrameworkPropertyMetadata (
                default (CellElement[]),
                FrameworkPropertyMetadataOptions.None,
                Changed_Cells,
                Coerce_Cells          
            ));

        static void Changed_Cells (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var instance = dependencyObject as MainWindow;
            if (instance != null)
            {
                var oldValue = (CellElement[])eventArgs.OldValue;
                var newValue = (CellElement[])eventArgs.NewValue;

                instance.Changed_Cells (oldValue, newValue);
            }
        }


        static object Coerce_Cells (DependencyObject dependencyObject, object basevalue)
        {
            var instance = dependencyObject as MainWindow;
            if (instance == null)
            {
                return basevalue;
            }
            var oldValue = (CellElement[])basevalue;
            var newValue = oldValue;

            instance.Coerce_Cells (oldValue, ref newValue);


            return newValue;
        }

        #endregion

        // --------------------------------------------------------------------
        // Constructor
        // --------------------------------------------------------------------
        public MainWindow ()
        {
            CoerceAllProperties ();
            Constructed__MainWindow ();
        }
        // --------------------------------------------------------------------
        partial void Constructed__MainWindow ();
        // --------------------------------------------------------------------
        void CoerceAllProperties ()
        {
            CoerceValue (CellsProperty);
        }


        // --------------------------------------------------------------------
        // Properties
        // --------------------------------------------------------------------

           
        // --------------------------------------------------------------------
        public CellElement[] Cells
        {
            get
            {
                return (CellElement[])GetValue (CellsProperty);
            }
            set
            {
                if (Cells != value)
                {
                    SetValue (CellsProperty, value);
                }
            }
        }
        // --------------------------------------------------------------------
        partial void Coerce_Cells (CellElement[] value, ref CellElement[] coercedValue);
        partial void Changed_Cells (CellElement[] oldValue, CellElement[] newValue);
        // --------------------------------------------------------------------


    }
    // ------------------------------------------------------------------------

}



