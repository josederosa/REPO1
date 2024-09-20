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
}