using MauiApp2.Models;
using Contact = MauiApp2.Models.Contact;

namespace MauiApp2.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		lvwContacts.ItemsSource = ContactsRepository.GetAllContacts();
	}
	
    private void lvwContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		lvwContacts.SelectedItem = null;
    }

    private async void lvwContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if (lvwContacts.SelectedItem is not null)
		{
			Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)lvwContacts.SelectedItem).Id}");
        }
	}
}