using System.ComponentModel.Design;

namespace MauiApp2.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Contact> contactList = new List<Contact>()
		{new Contact(){Name="Jose",Email="jose@pepe.com"},
		 new Contact(){Name="Daniel",Email="daneil@pepe.com"}};

		lvwContacts.ItemsSource = contactList;
	}

	class Contact
	{
        public string Name { get; set; }	
		public string Email{ get; set; }
    }

    private void lvwContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		lvwContacts.SelectedItem = null;
    }

    private async void lvwContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if (lvwContacts.SelectedItem is not null)
		{
            var a = await DisplayAlert("Alerta", "Ud. tocó un listviewitem !", "Ok", "Cancel");
            if (a)
                DisplayAlert("Alerta", "Tocó OK", "Ok");
            else
                DisplayAlert("Alerta", "Tocó Cancel", "Ok");
        }
	}
}