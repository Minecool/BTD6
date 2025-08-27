namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public class CTGameSettingBosses
{
	public Dictionary<String, Single> bossChances; //Field offset: 0x10
	public float oneTier; //Field offset: 0x18
	public float twoTiers; //Field offset: 0x1C
	public Int32[] spawnRounds; //Field offset: 0x20
	public Int32[] checkpointRounds; //Field offset: 0x28

	public static Dictionary<String, Single> kDefaultBossChances
	{
		 get { } //Length: 359
	}

	public static Int32[] kDefaultCheckpointRounds
	{
		 get { } //Length: 96
	}

	public CTGameSettingBosses() { }

	public static Dictionary<String, Single> get_kDefaultBossChances() { }

	public static Int32[] get_kDefaultCheckpointRounds() { }

}

