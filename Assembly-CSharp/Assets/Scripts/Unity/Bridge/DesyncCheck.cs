namespace Assets.Scripts.Unity.Bridge;

public class DesyncCheck : IBtd6MessageType
{
	private struct TowerInfo
	{
		public ObjectId id; //Field offset: 0x0
		public float worth; //Field offset: 0x4
		public long damageDealt; //Field offset: 0x8
		public int path1Tier; //Field offset: 0x10
		public int path2Tier; //Field offset: 0x14
		public int path3Tier; //Field offset: 0x18

		public static double CreateHash(TowerInfo t) { }

	}

	public int step; //Field offset: 0x10
	private double hash; //Field offset: 0x18

	public DesyncCheck(int step, double hash) { }

	public DesyncCheck(Simulation sim) { }

	private static double CreateHash(ObjectId idNext, int nextRNG, float health, int currentRound, bool gameWon, bool matchJustWon, bool gameLost, double totalCash, IEnumerable<TowerInfo> towerInfos) { }

	private static TowerInfo CreateTowerInfo(Tower tower) { }

	public static DesyncCheck Decode(BinaryReader reader) { }

	public static void Encode(BinaryWriter writer, DesyncCheck desyncChkr) { }

	public bool IsEqualTo(DesyncCheck b) { }

}

