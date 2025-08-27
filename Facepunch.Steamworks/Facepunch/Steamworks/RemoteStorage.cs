namespace Facepunch.Steamworks;

public class RemoteStorage : IDisposable
{
	internal Client client; //Field offset: 0x10
	internal SteamRemoteStorage native; //Field offset: 0x18
	private bool _filesInvalid; //Field offset: 0x20
	private readonly List<RemoteFile> _files; //Field offset: 0x28

	internal RemoteStorage(Client c) { }

	public override void Dispose() { }

}

