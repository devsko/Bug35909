using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WindowsXamlManager.InitializeForCurrentThread())
            {
                var data = new ObservableCollection<object>();
                var list = new ListBox();
                list.ItemsSource = data;
                data.Add(new object());
            }
        }
    }
}