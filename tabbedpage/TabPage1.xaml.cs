using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tabbedpage
{
    public partial class TabPage1 : ContentPage
    {
        public TabPage1()
        {
            InitializeComponent();
        }

        public void OnPickupTapped(object sender, FocusEventArgs args)
        {
            var lbl = (Entry)sender;
            Navigation.PushAsync(new OtherPage());
        }
    }
}
