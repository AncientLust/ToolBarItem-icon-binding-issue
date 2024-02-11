using CommunityToolkit.Mvvm.ComponentModel;

namespace ToolBarItem_icon_binding_issue
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            BindingContext = new MainPageVM();
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
