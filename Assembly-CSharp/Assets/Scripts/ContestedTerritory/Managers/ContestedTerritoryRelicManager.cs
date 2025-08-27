namespace Assets.Scripts.ContestedTerritory.Managers;

public static class ContestedTerritoryRelicManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TeamsStoreItem, Boolean> <>9__4_0; //Field offset: 0x8
		public static Func<TeamsStoreItem, Boolean> <>9__5_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GenerateDailyRelics>b__5_0(TeamsStoreItem x) { }

		internal bool <GenerateEventRelics>b__4_0(TeamsStoreItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public List<ContestedTerritoryRelicType> availableRelicsList; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetAvailableSelectedRelics>b__0(ContestedTerritoryRelicType x) { }

	}

	public const int kMaxSelectableRelics = 4; //Field offset: 0x0

	private static ContestedTerritorySettings CtSkuSettings
	{
		private get { } //Length: 147
	}

	public static ContestedTerritoryRelicType[] GenerateDailyRelics(CtEvent ctEvent) { }

	public static ContestedTerritoryRelicType[] GenerateEventRelics(CtEvent ctEvent) { }

	private static ContestedTerritorySettings get_CtSkuSettings() { }

	public static List<ContestedTerritoryRelicType> GetAvailableSelectedRelics(IEnumerable<ContestedTerritoryRelicType> selectedRelics, IEnumerable<ContestedTerritoryRelicType> availableRelics) { }

}

