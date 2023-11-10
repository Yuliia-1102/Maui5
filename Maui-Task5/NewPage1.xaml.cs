using System.Collections.ObjectModel;

namespace Maui_Task5;

public partial class NewPage1 : ContentPage
{
    private ObservableCollection<Item> itemsCollection;
    public NewPage1()
    {
        InitializeComponent();
        listView.ItemsSource = new List<Item>
        {
           new Products {Name = "Milk", Price = "83", Country = "Syria", Date = "2022", Description = "contain vitamins A, C, D", ExpirationDate = "21.09.24", Number = 21, Unit = "12 kg"},
           new Books {Name = "Cold Heart", Price = "340", Country = "Ukraine", Date = "10.02.2023", Description = "story about Cold War", NumberOfPages = 234, PublishingHouse = "Halamaga", Author = "T. Shevchenko"},
           new Products {Name = "Apple", Price = "34", Country = "Italy", Date = "19.05.2022", Description = "no specific info", ExpirationDate = "10.12.25", Number = 3, Unit = "10 kg"},
           new Books {Name = "Again 13", Price = "701", Country = "Bulgaria", Date = "2006", Description = "about a very sick girl", NumberOfPages = 290, PublishingHouse = "Eneida", Author = "O. Omelchuk"},
           new Products {Name = "Bread", Price = "42", Country = "France", Date = "15.11.2022", Description = "from Ukraine's grain", ExpirationDate = "11.01.27", Number = 38, Unit = "1 kg"},
           new Books {Name = "Save & Sound", Price = "302", Country = "Ukraine", Date = "02.08.2022", Description = "no specific info", NumberOfPages = 1084, PublishingHouse = "Dadalaro", Author = "K. Deborai"},
        };

        itemsCollection = new ObservableCollection<Item>();
        ChosenListView.ItemsSource = itemsCollection;
    }

    private void AddButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        Item item = (Item)button.BindingContext;
        if (!itemsCollection.Contains(item))
        {
            itemsCollection.Add(item);
        }
        else
        {
            DisplayAlert("Message", $"The item '{item.Name}' is already in the basket.", "OK");
        }
    }

    private void DeleteButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        Item item = (Item)button.BindingContext;
        if (itemsCollection.Contains(item))
        {
            itemsCollection.Remove(item);
        }
    }

    public class Item
    {
        public string Price { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }

    public class Products : Item
    {
        public string ExpirationDate { get; set; }
        public double Number { get; set; }
        public string Unit { get; set; }
    }

    public class Books : Item
    {
        public int NumberOfPages { get; set; }
        public string PublishingHouse { get; set; }
        public string Author { get; set; }
    }
}