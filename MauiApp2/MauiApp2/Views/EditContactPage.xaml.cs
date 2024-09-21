using MauiApp2.Models;
using Contact = MauiApp2.Models.Contact;

namespace MauiApp2.Views;

[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContactPage : ContentPage
{

	public EditContactPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

    public int ContactId
	{
		set 
		{ 
			lblContactName.Text= ContactsRepository.GetContactsById(value)!.Name;
            lblContactMail.Text = ContactsRepository.GetContactsById(value)!.Email;
        }
	}
 
}