using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BugDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            UpdateItemsSource();
        }

        private void UpdateItemsSource()
        {
            list.ItemsSource = null;
            list.ItemsSource = new List<ViewModel>
            {
                new ViewModel { Group = "Group A", Content = "Content A1" },
                new ViewModel { Group = "Group A", Content = "Content A2" },
                new ViewModel { Group = "Group B", Content = "Content B1" },
                new ViewModel { Group = "Group B", Content = "Content B2" },
            };
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            UpdateItemsSource();
        }
    }

    public class ViewModel
    {
        public string Content { get; set; }
        public string Group { get; set; }
    }
}
