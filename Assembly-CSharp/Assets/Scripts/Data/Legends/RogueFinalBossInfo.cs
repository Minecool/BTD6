namespace Assets.Scripts.Data.Legends;

public class RogueFinalBossInfo
{
	public BossType boss; //Field offset: 0x10
	public int baseHealth; //Field offset: 0x14
	public float healthMultiplierPerStage; //Field offset: 0x18
	public float armourPercent; //Field offset: 0x1C
	public float speedMultiplier; //Field offset: 0x20

	public RogueFinalBossInfo() { }

}

