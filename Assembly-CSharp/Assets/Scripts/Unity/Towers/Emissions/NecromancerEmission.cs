namespace Assets.Scripts.Unity.Towers.Emissions;

public class NecromancerEmission : Emission
{
	public GrappleEmission parent; //Field offset: 0x88
	public int maxRbeStored; //Field offset: 0x90
	public string expMaxRbeStored; //Field offset: 0x98
	public int maxRbeSpawnedPerSecond; //Field offset: 0xA0
	public string expMaxRbeSpawnedPerSecond; //Field offset: 0xA8
	public int minBloonsSpawnedPerWave; //Field offset: 0xB0
	public string expMinBloonsSpawnedPerWave; //Field offset: 0xB8
	public int maxBloonsSpawnedPerWave; //Field offset: 0xC0
	public string expMaxBloonsSpawnedPerWave; //Field offset: 0xC8
	public int maxPiercePerBloon; //Field offset: 0xD0
	public string expMaxPiercePerBloon; //Field offset: 0xD8
	public int maxPathRandomRange; //Field offset: 0xE0
	public string expMaxPathRandomRange; //Field offset: 0xE8
	public int maxPathOffset; //Field offset: 0xF0
	public string expMaxPathOffset; //Field offset: 0xF8
	public int rateStackMax; //Field offset: 0x100
	public string expRateStackMax; //Field offset: 0x108
	public int rateRbePerStack; //Field offset: 0x110
	public string expRateRbePerStack; //Field offset: 0x118
	public int damageStackMax; //Field offset: 0x120
	public string expDamageStackMax; //Field offset: 0x128
	public int damageRbePerStack; //Field offset: 0x130
	public string expDamageRbePerStack; //Field offset: 0x138
	public int roundsBeforeDecay; //Field offset: 0x140
	public string expRoundsBeforeDecay; //Field offset: 0x148

	public virtual EmissionModel Def
	{
		 get { } //Length: 414
	}

	public NecromancerEmission() { }

	public virtual EmissionModel get_Def() { }

}

