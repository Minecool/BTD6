namespace Assets.Scripts.Unity.UI_New.InGame;

public class BossGameData
{
	public static readonly Int32[] DefaultSpawnRounds; //Field offset: 0x0
	public static readonly IReadOnlyCollection<Int32> DefaultCheckpointRounds; //Field offset: 0x8
	public BossType bossBloon; //Field offset: 0x10
	public bool bossEliteMode; //Field offset: 0x14
	public bool bossRankedMode; //Field offset: 0x15
	public Int32[] spawnRounds; //Field offset: 0x18
	public bool bossForcePreSpawnBoss; //Field offset: 0x20
	public float bossSpawnDistanceOverride; //Field offset: 0x24

	private static BossGameData() { }

	public BossGameData() { }

	public BossGameData Clone() { }

}

