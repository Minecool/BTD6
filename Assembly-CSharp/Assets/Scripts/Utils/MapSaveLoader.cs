namespace Assets.Scripts.Utils;

[Extension]
public static class MapSaveLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Tower, ObjectId> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ObjectId <CreateMapSaveData>b__1_0(Tower t) { }

	}

	private const int LatestVersion = 7; //Field offset: 0x0

	public static MapSaveDataModel CreateMapSaveData(string mapSaveDataID, Nullable<Int32> gameId, int attemptId, int continuesUsed, Simulation sim, Dictionary<Int32, String> heroes, int round, string dailyChallengeEventID, int tileID, Dictionary<String, String> currentGameMetaData, ActiveKnowledge activeKnowledge = null, Replay replayRecorder = null) { }

	private static ProjectileModel GetGeraldoProjectileModel(Simulation sim, string projectileId, int owner) { }

	private static List<LoanSaveDataModel> GetImfLoans(Simulation sim) { }

	private static Dictionary<String, List`1<MutatorSaveDataModel>> GetMutatorSaveData(Simulation sim) { }

	private static Dictionary<Int32, PlayerSaveData> GetPlayerSaveData(Simulation sim, Dictionary<Int32, String> heroes) { }

	[Extension]
	public static void LoadMapSaveData(Simulation sim, MapSaveDataModel mapData) { }

	private static void OldMapDataVersionCheck(MapSaveDataModel mapData) { }

	private static void SetImfLoanInfo(Simulation sim, List<LoanSaveDataModel> loans) { }

	private static void SetMutatorSaveData(Simulation sim, MapSaveDataModel mapSaveDataModel) { }

}

