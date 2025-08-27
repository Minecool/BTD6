namespace Assets.Scripts.Unity.Network;

[Extension]
public static class PlayerInfoExtensions
{
	private static readonly String[] numbers; //Field offset: 0x0
	private static readonly String[] letters; //Field offset: 0x8

	private static JsonSerializerSettings SerialisationSettings
	{
		private get { } //Length: 94
	}

	private static PlayerInfoExtensions() { }

	[Extension]
	public static PlayerInfo CreatePlayerInfo(Btd6Player player) { }

	private static string CreateRandomName() { }

	[Extension]
	public static PlayerInfo DeserialisePlayerInfo(string json) { }

	private static JsonSerializerSettings get_SerialisationSettings() { }

	[Extension]
	private static string Random(String[] array) { }

	[Extension]
	public static string Serialise(PlayerInfo playerInfo) { }

}

