namespace Assets.Scripts.Data.Boss;

public class Bosses : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public BossType bossType; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <GetBossData>b__0(BossData boss) { }

	}

	public const int kMaxBossTier = 5; //Field offset: 0x0
	[ReorderableList("items", True)]
	[SerializeField]
	private BossDetailsContainer BossList; //Field offset: 0x18

	public Bosses() { }

	public BossData GetBossData(string bossName) { }

	public BossData GetBossData(BossType bossType) { }

}

