namespace Assets.Scripts.ContestedTerritory;

public class ContestedTerritoryEconomy
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GuildInfo, String> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Refresh>b__13_0(GuildInfo x) { }

	}

	[CompilerGenerated]
	private static ContestedTerritoryEconomy <Instance>k__BackingField; //Field offset: 0x0
	private readonly Dictionary<String, ContestedTerritoryIncome> teamIncomes; //Field offset: 0x10
	private readonly Dictionary<String, ContestedTerritoryIncome> playerIncomes; //Field offset: 0x18

	private static Btd6CtSettings CtSettings
	{
		private get { } //Length: 138
	}

	private static ContestedTerritoryEconomy Instance
	{
		[CompilerGenerated]
		private get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	private static Dictionary<String, ContestedTerritoryIncome> PlayerIncomes
	{
		private get { } //Length: 68
	}

	private static Dictionary<String, ContestedTerritoryIncome> TeamIncomes
	{
		private get { } //Length: 68
	}

	public ContestedTerritoryEconomy() { }

	private static void ClearIncomes() { }

	private static Btd6CtSettings get_CtSettings() { }

	[CompilerGenerated]
	private static ContestedTerritoryEconomy get_Instance() { }

	private static Dictionary<String, ContestedTerritoryIncome> get_PlayerIncomes() { }

	private static Dictionary<String, ContestedTerritoryIncome> get_TeamIncomes() { }

	public static ContestedTerritoryIncome GetDetailedPlayerIncome(string playerId) { }

	public static ContestedTerritoryIncome GetDetailedTeamIncome(string teamId) { }

	public static ScoringSettings GetScoringSettingsForTileType(CtTileType tileType) { }

	public static string GetTotalTeamIncome(string teamId) { }

	private static bool IsIncrementingCtPoints(DateTime capturedAt, CtTileType tileType) { }

	public static void Refresh() { }

	public static void Reset() { }

	[CompilerGenerated]
	private static void set_Instance(ContestedTerritoryEconomy value) { }

}

