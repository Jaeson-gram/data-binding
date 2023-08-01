using System.Diagnostics;
using Person = DataBinding.Models.Person;

namespace DataBinding;

public partial class MainPage : ContentPage
{
    //Binding 4.1 - define the object on a more global scale..
    Person person = new();

    public MainPage()
	{
		InitializeComponent();

        //for INotifyPropertyChanged Interface
        //4.2 Instantiate the object in the constructor
        person = new Person()
		{
			Name = "Jason",
			Phone = "2348075458454",
			Address = "Somplace in Africa"
		};

        BindingContext = person;
    }

	/*
	 * 
	 * 
    //Binding 1.0
    private void OnCounterClicked(object sender, EventArgs e)
	{
		// 1.1 create an object of what you want to bind
		var person = new Person
		{
			Name = "Jason",
			Phone = "2348075458454",
			Address = "Somplace			in Africa"
		};

		//1.2 create an instance of binding class
		Binding personBinding = new Binding();

		//1.3 provide source of the binding, and particular path to bind, to the Binding object
		personBinding.Source = person;
		personBinding.Path = "Name";

		//1.4 bind the object to the recieving control
		textLabel.SetBinding(Label.TextProperty, personBinding);
	}


	//Binding 2.0
	// Data Binding assigning more than just one property

	private void CounterBtn2_Clicked(object sender, EventArgs e)
	{
		//2.1 define and instantiate the objecr
        var person = new Person
        {
            Name = "Richard",
            Phone = "2348075458454",
            Address = "Somplace in Africa"
        };


		//2.3 so instead of the above method, we can use the BindingContext then we
		//assign the whole object to it, then use whichever property we want

		textLabel.BindingContext = person;
		textLabel.SetBinding(Label.TextProperty, "Name");

        // textLabel.SetBinding(Label.TextColorProperty, "something else");
    }


	//Binding 3.0
	//Data Binding assigning the whole object..
	private void CounterBtn2_Clicked_1(object sender, EventArgs e)
	{
		var person = new Person
		{
			Name = "Jesus",
			Phone = "Prayer",
			Address = "My Heart"
		};

		//now all we have to do is use the BindingContext class and pass the 'person' object, 
		//and the whole code will have access to the object, and we'll just need to bind whatever we need from xaml.. :)

		BindingContext = person;
	}

	*/


    //Binging 4.0
    //we can also bind objects to properties using the INotiifyPropertyChanged Interface..
    //this way, the whole object details will change, and because the xaml code is binding with the object itself, it changes in the UI
    private void inotifyPropChanged_Clicked(object sender, EventArgs e)
    {
        //4.3 on the event handler, change the properties like so: 
        person = new Person
        {
            Name = "New Name",
            Phone = "0000x00",
			Address = "Some Adress"
        };

		BindingContext = person;


		//Note, the person is not defined, just it's properties changed, because it's already defined in the constructor


		//... next, go to the object class (Person.cs) and implement the INotifyPpropertyChanged Interface, appropriately!
	}

}

