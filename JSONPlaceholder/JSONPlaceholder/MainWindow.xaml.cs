using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ApiDataApp
{
	public partial class MainWindow : Window
	{
		private static readonly HttpClient client = new HttpClient();
		private DispatcherTimer timer;

		public MainWindow()
		{
			InitializeComponent();
			InitializeTimer();
			FetchData(); // Uygulama başlarken veriyi yükle
		}

		// API'den veri çeken metod
		private async Task<List<Post>> FetchPostsFromApi()
		{
			try
			{
				var response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
				StatusText.Text = $"API Response Length: {response.Length}"; // Yanıt uzunluğunu göster
				var posts = JsonConvert.DeserializeObject<List<Post>>(response);
				return posts;
			}
			catch (Exception ex)
			{
				StatusText.Text = $"Error: {ex.Message}";
				return null;
			}
		}


		private async 

		Task
FetchData()
		{
			StatusText.Text = "Status: Fetching data...";
			var posts = await FetchPostsFromApi();
			if (posts != null)
			{
				PostsListView.ItemsSource = posts; // Listeyi güncelle
				StatusText.Text = $"Status: {posts.Count} posts loaded.";
			}
			else
			{
				StatusText.Text = "Status: No data retrieved.";
			}
		}




		// Butona basıldığında çağrılan metod
		private void RefreshData_Click(object sender, RoutedEventArgs e)
		{
			FetchData();
		}

		// DispatcherTimer ile belirli aralıklarla veriyi güncelle
		private void InitializeTimer()
		{
			timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(30); // Her 30 saniyede bir veri çek
			timer.Tick += async (s, e) => await FetchData(); // FetchData() metodunu async olarak çağırıyoruz
			timer.Start();
		}




	}

	// API'den çekilecek veri modeli
	public class Post
	{
		public int id { get; set; }
		public string title { get; set; }
		public string body { get; set; }
	}
}
