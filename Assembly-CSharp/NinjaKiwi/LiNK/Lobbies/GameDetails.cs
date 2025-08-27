namespace NinjaKiwi.LiNK.Lobbies;

public class GameDetails
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Player, Byte> <>9__3_0; //Field offset: 0x8
		public static Func<Player, String> <>9__3_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal byte <.ctor>b__3_0(Player p) { }

		internal string <.ctor>b__3_1(Player p) { }

	}

	public ConnectionDetails ConnectionDetails; //Field offset: 0x10
	public Dictionary<Byte, String> Players; //Field offset: 0x18

	[JsonConstructor]
	public GameDetails() { }

	public GameDetails(ConnectionDetails connectionDetails, IEnumerable<Player> players) { }

}

