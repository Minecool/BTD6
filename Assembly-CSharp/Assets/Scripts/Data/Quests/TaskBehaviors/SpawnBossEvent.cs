namespace Assets.Scripts.Data.Quests.TaskBehaviors;

public class SpawnBossEvent : InGameDataMod
{
	internal class BossModeData
	{
		public BossType bossType; //Field offset: 0x10
		public Int32[] spawnRounds; //Field offset: 0x18
		public Int32[] checkPointRounds; //Field offset: 0x20
		public bool spawnBossImmediately; //Field offset: 0x28
		public bool playSpawnAnimation; //Field offset: 0x29
		public float bossSpawnDisatanceOverride; //Field offset: 0x2C

		public BossModeData() { }

	}

	internal class EliteModeDcmOverrides
	{
		public int cash; //Field offset: 0x10
		public int endRound; //Field offset: 0x14
		public int lives; //Field offset: 0x18

		public EliteModeDcmOverrides() { }

	}

	public BossModeData bossModeData; //Field offset: 0x10
	[Tooltip("If true, the DCM values will be used for elite mode. If false, the default DCM values will be used.")]
	public bool isEliteMode; //Field offset: 0x18
	public EliteModeDcmOverrides eliteDcmOverrides; //Field offset: 0x20

	public SpawnBossEvent() { }

	public virtual void ModifyData(InGameData editableInGameData) { }

}

