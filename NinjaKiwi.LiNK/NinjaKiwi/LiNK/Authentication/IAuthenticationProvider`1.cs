namespace NinjaKiwi.LiNK.Authentication;

public interface IAuthenticationProvider
{

	public Task<T> AskForAuthToken() { }

	public string GetIdWithProviderPrefixIfAuthenticated() { }

}

