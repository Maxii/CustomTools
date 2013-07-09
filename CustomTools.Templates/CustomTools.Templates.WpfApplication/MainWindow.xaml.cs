﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.xaml.cs
// COMMENT - one line to give a brief idea of what this file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

#define DEBUG_LOG
#define DEBUG_LEVEL_WARN
#define DEBUG_LEVEL_ERROR

namespace $safeprojectname$ {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    using CodeEnv.Master.Common;
    using CodeEnv.Master.Common.LocalResources;


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            // InitializeComponent() is defined within the generated MainWindow.g.cs file.
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            // a Windows.Loaded event has arrived
            // STUB
            // In XAML, <Grid Loaded=Window_Loaded> specifying the handler for 'Grid' loaded event
        }
        ///<summary>
        ///Initializes event handlers for the WPF Components defined in the attached XAML.
        /// </summary>
        private void InitializeEventHandlers() {
            // the lambda event handler w/anonomous method
            bottomButton.Click += (sender, eventArgs) =>
            {
                ClassDerivedFromBase derivedObj = new ClassDerivedFromBase();
                textArea.Text = derivedObj.ToString();
            };

            //  the anonomous method, no arguments event handler
            bottomButton.KeyDown += delegate {
                // code here that DOESN'T require the event args
            };
            // the anonomous method with arguments event handler
            bottomButton.LostFocus += delegate(object sender, RoutedEventArgs e) {
                // code here that DOES require the event args
            };

            // most common approach
            bottomButton.Loaded += new RoutedEventHandler(HandleButtonLoaded);
            // the short cut for the common one immediately above
            bottomButton.DragOver += HandleButtonDragOver;

        }

        private void HandleButtonLoaded(object sender, RoutedEventArgs e) {
            // handling event here
        }

        private void HandleButtonDragOver(object sender, RoutedEventArgs e) {
            // handle event here
        }


        // the alternative method auto generated by the Designer and bound from XAML
        private void bottomButton_Click(object sender, RoutedEventArgs e) {
            // handle event here
        }


        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }
    }
}
