﻿#pragma checksum "..\..\RentPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4AA963D40E263FA72DE1AC3492B6B4C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Financial_Calculator;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Financial_Calculator {
    
    
    /// <summary>
    /// RentPage
    /// </summary>
    public partial class RentPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalculate;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbM;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbN;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbP;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbS;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbA;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbI;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbR;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbPost;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbPre;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbP;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\RentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbM;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Financial Calculator;component/rentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RentPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\RentPage.xaml"
            ((Financial_Calculator.RentPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCalculate = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\RentPage.xaml"
            this.btnCalculate.Click += new System.Windows.RoutedEventHandler(this.btnCalculate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbM = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbS = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbI = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbR = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.rbPost = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.rbPre = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.cbP = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\RentPage.xaml"
            this.cbP.Checked += new System.Windows.RoutedEventHandler(this.cbP_Checked);
            
            #line default
            #line hidden
            
            #line 38 "..\..\RentPage.xaml"
            this.cbP.Unchecked += new System.Windows.RoutedEventHandler(this.cbP_Unchecked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.cbM = ((System.Windows.Controls.CheckBox)(target));
            
            #line 41 "..\..\RentPage.xaml"
            this.cbM.Unchecked += new System.Windows.RoutedEventHandler(this.cbM_Unchecked);
            
            #line default
            #line hidden
            
            #line 41 "..\..\RentPage.xaml"
            this.cbM.Checked += new System.Windows.RoutedEventHandler(this.cbM_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

