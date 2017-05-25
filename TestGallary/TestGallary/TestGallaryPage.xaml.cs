using Xamarin.Forms;

namespace TestGallary
{
	public partial class TestGallaryPage : ContentPage
	{
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			//var item = await DisplayActionSheet("Add Expense here", "Cancel", null, "TAKE_PHOTO", "SELECT_LIBRARY", "CREATE_NEW_EXPENSE");
			var test = DependencyService.Get<OpenGallary>().openGallary();
		}

		public TestGallaryPage()
		{
			InitializeComponent();
		}
	}
}
