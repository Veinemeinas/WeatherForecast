using Blazored.LocalStorage;

namespace WeatherForecast.Services
{
	public class FavoritePlacesService
	{
		private readonly ILocalStorageService _localStorageService;
		public FavoritePlacesService(ILocalStorageService localStorageService)
		{
			_localStorageService = localStorageService;
		}

		public async Task<List<string>> GetFavoritePlaces()
		{
			var myFavoritePlaces = await _localStorageService.GetItemAsync<List<string>>("MyFavoritePlaces");
			if (myFavoritePlaces == null)
			{
				return null;
			}
			return myFavoritePlaces.OrderByDescending(p => myFavoritePlaces.IndexOf(p)).ToList();
		}
	}
}
