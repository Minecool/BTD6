namespace Facepunch.Steamworks;

public class User : IDisposable
{
	internal Client client; //Field offset: 0x10
	internal Dictionary<String, String> richPresence; //Field offset: 0x18

	internal User(Client c) { }

	public override void Dispose() { }

	public string GetUserDataFolder() { }

	public bool SetRichPresence(string key, string value) { }

}

