using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AppMenu
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            Type pageType;
            pageType = typeof(PageView.BlankPage1);
            //switch (tag)
            //{
            //    case "discovery":
            //        pageType = typeof(BlankPage1);
            //        break;
            //    case "tag":
            //        pageType = typeof(BlankPage2);
            //        break;
            //    case "mine":
            //        pageType = typeof(BlankPage3);
            //        break;
            //    case "grid":
            //        pageType = typeof(BlankPageGrid);
            //        break;
            //    case "RelativePanel":
            //        pageType = typeof(BlankPageRelativePanel);
            //        break;
            //    case "bind":
            //        pageType = typeof(BlankPageBind);
            //        break;
            //    case "net":
            //        pageType = typeof(BlankPageNetwork);
            //        break;
            //}
            
            contentFrame.Navigate(pageType);
        }

        

        private void home_Click(object sender, RoutedEventArgs e)
        {
            var btnname = e.OriginalSource;
            Type pageType;
            pageType = typeof(PageView.BlankPage1);
            
            contentFrame.Navigate(pageType);
        }

        private void app_Click(object sender, RoutedEventArgs e)
        {
            var btnname = e.OriginalSource;
            Type pageType;
            pageType = typeof(PageView.BlankPage2);

            contentFrame.Navigate(pageType);
        }

        private void game_Click(object sender, RoutedEventArgs e)
        {

        }

        private void setting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void setting_Click_1(object sender, RoutedEventArgs e)
        {

        }


        private async void menuListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item =(ListViewItem)e.AddedItems[0];
            Type pageType;
            pageType = typeof(PageView.BlankPage1);
            switch (item.Tag)
            {
                case "discovery":
                    pageType = typeof(PageView.PageDiscovery);
                    
                    contentFrame.NavigateToType(pageType, null, null);
                    break;
                case "tag":
                    pageType = typeof(PageView.PageTag);
                    contentFrame.NavigateToType(pageType, null, null);
                    break;
                case "mine":
                    pageType = typeof(PageView.PageMine);
                    contentFrame.NavigateToType(pageType, null, null);
                    break;
                case "setting":
                    pageType = typeof(PageView.PageSetting);
                    contentFrame.NavigateToType(pageType, null, null);
                    break;
                //case "help":
                //     await dialog1.ShowAsync();
                //    break;
                
            }
            
        }

        private void menuListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var sel = e.OriginalSource;//
            Console.WriteLine(sel);
        }

        private void menuListView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //string sel = e.OriginalSource;
            // //sel.Parent.Content = "";
            // if(sel == "discovery")
            //{

            //}
            //var tbtext = sel;
            //Console.WriteLine(sel);
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sel=e.OriginalSource;
        }
    }
}
