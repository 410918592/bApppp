namespace bApppp
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            List<Fruit> list = new List<Fruit>();
            {
                new Fruit() { Name = "Apple", ImageUrl = "apple.png", Description = "This is an apple" };
                new Fruit() { Name = "Orange", ImageUrl = "orange.png", Description = "This is a orange" };
                new Fruit() { Name = "Banana", ImageUrl = "banana.png", Description = "This is a banana" };
                new Fruit() { Name = "Kiwi", ImageUrl = "kiwi.png", Description = "This is a kiwi" };
                new Fruit() { Name = "Strawberry", ImageUrl = "strawberry.png", Description = "This is an strawberry" };
                new Fruit() { Name = "Pineapple", ImageUrl = "pineapple.png", Description = "This is a pineapple" };
                new Fruit() { Name = "Watermelom", ImageUrl = "watermelom.png", Description = "This is a watermelom" };
                new Fruit() { Name = "Grape", ImageUrl = "grape.png", Description = "This is a  grape" };
            }
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.ImageUrl, selectedItem.Description));
        }
    }
}
