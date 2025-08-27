namespace Assets.Scripts.Data.ContestedTerritory;

public class ContestedTerritoryData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TileData, Boolean> <>9__11_0; //Field offset: 0x8
		public static Func<TileData, Boolean> <>9__13_0; //Field offset: 0x10
		public static Func<TileData, Boolean> <>9__15_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <get_BannerTile>b__15_0(TileData x) { }

		internal bool <get_DefaultTile>b__11_0(TileData x) { }

		internal bool <get_RelicTile>b__13_0(TileData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public EventName eventName; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <GetPrefabForEvent>b__0(IslandTheme x) { }

	}

	public PrefabReference contestedTerritoryPrefab; //Field offset: 0x18
	public PrefabReference contestedTerritoryTitleScreenPrefab; //Field offset: 0x20
	public MapSizing mapSizing; //Field offset: 0x28
	public PrefabReference emptyHomeTile; //Field offset: 0x30
	public IslandTheme[] islandThemes; //Field offset: 0x38
	public IslandTheme[] teamIslandThemes; //Field offset: 0x40
	public IslandTheme[] distantIslandThemes; //Field offset: 0x48
	public TeamDetail[] teamDetails; //Field offset: 0x50
	public MapGeneration mapGeneration; //Field offset: 0x58
	public ExtraAssets extraAssets; //Field offset: 0x60

	public PrefabReference BannerTile
	{
		 get { } //Length: 276
	}

	public PrefabReference DefaultTile
	{
		 get { } //Length: 276
	}

	public PrefabReference RelicTile
	{
		 get { } //Length: 276
	}

	public ContestedTerritoryData() { }

	public PrefabReference get_BannerTile() { }

	public PrefabReference get_DefaultTile() { }

	public PrefabReference get_RelicTile() { }

	public PrefabReference GetDistantIslandPrefab(EventName eventName) { }

	public PrefabReference GetIslandPrefab(EventName eventName) { }

	private static PrefabReference GetPrefabForEvent(IslandTheme[] themes, EventName eventName) { }

	public TeamDetail GetTeamDetails(int teamIndex) { }

	public PrefabReference GetTeamIslandPrefab(EventName eventName) { }

}

