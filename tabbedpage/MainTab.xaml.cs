using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace tabbedpage
{
    public partial class MainTab : TabbedPage
    {
        public MainTab()
        {
            InitializeComponent();
            Children.Add(new TabPage1());
            Children.Add(new TabPage2());
            Children.Add(new TabPage3());   
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            string currentPage = CurrentPage.Title;
            Debug.WriteLine("\nTab Page changed: " + currentPage);

            if (currentPage.Equals("Page 1"))
            { NavigationPage.SetHasNavigationBar(this, false); Title = "Page 1"; }
            else if (currentPage.Equals("Page 2"))
            { NavigationPage.SetHasNavigationBar(this, true); Title = "Page 2"; }
            else if (currentPage.Equals("Page 3"))
            { NavigationPage.SetHasNavigationBar(this, true); Title = "Page 3"; }
        }
    }
}
