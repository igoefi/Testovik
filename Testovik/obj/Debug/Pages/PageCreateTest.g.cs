﻿#pragma checksum "..\..\..\Pages\PageCreateTest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "961D7E5AFD70703496F146182B5E1BE118818CBB2C15EC08B182F33F18A445E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Testovik.Pages;


namespace Testovik.Pages {
    
    
    /// <summary>
    /// PageCreateTest
    /// </summary>
    public partial class PageCreateTest : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Pages\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBoxQuestions;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbQuestion;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBoxAnwsers;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Pages\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbAnswer;
        
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
            System.Uri resourceLocater = new System.Uri("/Testovik;component/pages/pagecreatetest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageCreateTest.xaml"
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
            
            #line 32 "..\..\..\Pages\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClickAddQuestion);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 36 "..\..\..\Pages\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClickDeleteQuestion);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbBoxQuestions = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\Pages\PageCreateTest.xaml"
            this.cmbBoxQuestions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbBoxQuestionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 57 "..\..\..\Pages\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClickAddAnswer);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 61 "..\..\..\Pages\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClickDeleteAnswer);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbBoxAnwsers = ((System.Windows.Controls.ComboBox)(target));
            
            #line 66 "..\..\..\Pages\PageCreateTest.xaml"
            this.cmbBoxAnwsers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbBoxAnswersChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txbAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 79 "..\..\..\Pages\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickEndDoing);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 86 "..\..\..\Pages\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

