namespace Facepunch.Steamworks;

public class ServerList : IDisposable
{
	internal class Server
	{
		public Action<Boolean> OnReceivedRules; //Field offset: 0x10
		public Dictionary<String, String> Rules; //Field offset: 0x18
		internal SourceServerQuery RulesRequest; //Field offset: 0x20

		internal void OnServerRulesReceiveFinished(Dictionary<String, String> rules, bool Success) { }

	}

	internal Client client; //Field offset: 0x10
	private HashSet<UInt64> FavouriteHash; //Field offset: 0x18
	private HashSet<UInt64> HistoryHash; //Field offset: 0x20

	internal ServerList(Client client) { }

	public override void Dispose() { }

	internal void UpdateFavouriteList() { }

}

