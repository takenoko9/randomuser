using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;


namespace toshiapp
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GeneratorPage : ContentPage
	{
        public ListView listView;
        public List<results> results;

        public GeneratorPage ()
		{
			InitializeComponent ();

             listView = new ListView
            {
                RowHeight = 60
            };

            listView.ItemsSource = new String[] {
                "ダミーテキスト",
                "ダミーテキスト",
                "ダミーテキスト",
                "ダミーテキスト",
                "ダミーテキスト",
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };

            fetchArticles(new RandomAPI());
        }

        
        async void fetchArticles(RandomAPI api)
        {

            try
            {
                
                results = await api.AsyncGetWebAPIData();

                var items = new List<String>();
                foreach (results value in results)
                {
                    items.Add(value.name.title);
                }
                listView.ItemsSource = items;
            }
            
            catch (System.Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "OK");
            }

        }
	}
}