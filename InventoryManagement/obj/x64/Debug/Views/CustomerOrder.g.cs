﻿#pragma checksum "C:\Users\Vinh\Desktop\DOTNET DELIVERY\InventoryManagement\InventoryManagement\Views\CustomerOrder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C1346B65FEFF9CD95298506178EFDB76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagement.Views
{
    partial class CustomerOrder : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\CustomerOrder.xaml line 14
                {
                    this.PrintButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PrintButton).Click += this.PrintButton_Click;
                }
                break;
            case 3: // Views\CustomerOrder.xaml line 15
                {
                    this.Canvas1 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 4: // Views\CustomerOrder.xaml line 91
                {
                    this.BackBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackBtn).Click += this.BackBtn_Click;
                }
                break;
            case 5: // Views\CustomerOrder.xaml line 92
                {
                    this.ErrorMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\CustomerOrder.xaml line 16
                {
                    this.dataGrid1 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 7: // Views\CustomerOrder.xaml line 71
                {
                    this.Name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\CustomerOrder.xaml line 74
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\CustomerOrder.xaml line 76
                {
                    this.cId = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Views\CustomerOrder.xaml line 77
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\CustomerOrder.xaml line 87
                {
                    this.dateText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

