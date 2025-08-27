namespace NinjaKiwi.LiNK.Client;

public class PlayerStoragePaths
{
	private const string LINK_FOLDER = "link"; //Field offset: 0x0
	private const string CURRENT_FOLDER = "current"; //Field offset: 0x0
	private readonly string rootPath; //Field offset: 0x10
	private readonly Environments environment; //Field offset: 0x18

	public string GetLiNKFolder
	{
		 get { } //Length: 11
	}

	public PlayerStoragePaths(string rootPath, Environments environment) { }

	private static string File(string rootPath, Environments environment, string fileName, AuthenticationProviderToken token = null) { }

	public string get_GetLiNKFolder() { }

	public string GetFile(string fileName, AuthenticationProviderToken token = null) { }

	public static string GetFilePath(string rootPath, Environments environment, string fileName, AuthenticationProviderToken token = null) { }

	private static string GetFolderNameFromToken(AuthenticationProviderToken token) { }

	public static string GetLiNKFolderPath(string rootPath) { }

	private static string LiNKFolder(string rootPath) { }

	private static string PlayerFolder(string rootPath, Environments environment, AuthenticationProviderToken token = null) { }

}

