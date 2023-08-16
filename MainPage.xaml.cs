using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupStyle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPopup1_Clicked(object sender, EventArgs e)
        {
            var popup1 = new Popup1();
            Shell.Current.ShowPopup(popup1);
        }
    }
}