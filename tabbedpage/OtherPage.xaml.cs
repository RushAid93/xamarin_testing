using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tabbedpage
{
    public partial class OtherPage : ContentPage
    {
        public OtherPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
