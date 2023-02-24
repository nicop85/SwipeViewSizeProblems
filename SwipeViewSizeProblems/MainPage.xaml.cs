namespace SwipeViewSizeProblems;

public partial class MainPage : ContentPage
{
    private bool isOpen = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        if (isOpen)
        {
            swipeControl.Close();
            isOpen = false;
        }
        else
        {
            swipeControl.Open(OpenSwipeItem.RightItems);
            isOpen = true;
        }
    }
}

