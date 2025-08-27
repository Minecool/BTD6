namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "NecromancerEmission", menuName = "BTD6/Behaviors/Emissions/NecromancerEmission")]
public class NecromancerEmission : Emission
{
	public int maxRbeStored; //Field offset: 0x30
	public int maxRbeSpawnedPerSecond; //Field offset: 0x34
	public int minBloonsSpawnedPerWave; //Field offset: 0x38
	public int maxBloonsSpawnedPerWave; //Field offset: 0x3C
	public int maxPiercePerBloon; //Field offset: 0x40
	public int maxPathRandomRange; //Field offset: 0x44
	public int maxPathOffset; //Field offset: 0x48
	public int rateStackMax; //Field offset: 0x4C
	public int rateRbePerStack; //Field offset: 0x50
	public int damageStackMax; //Field offset: 0x54
	public int damageRbePerStack; //Field offset: 0x58
	public int roundsBeforeDecay; //Field offset: 0x5C

	public virtual EmissionModel Def
	{
		 get { } //Length: 352
	}

	public NecromancerEmission() { }

	public virtual EmissionModel get_Def() { }

}

