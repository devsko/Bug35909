using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;

namespace ConsoleApp2
{
    class Program
    {
        private class Npc : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private string _value;
            public string Value
            {
                get => _value;
                set
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }

        }
        static void Main(string[] args)
        {
            using (WindowsXamlManager.InitializeForCurrentThread())
            {
                var npc = new Npc();
                var textBlock = new TextBlock();
                textBlock.SetBinding(TextBlock.TextProperty, new Binding() { Mode = BindingMode.OneWay, Path = new PropertyPath(nameof(Npc.Value)), Source = npc });

                npc.Value = "TEST";
            }
        }
    }
}