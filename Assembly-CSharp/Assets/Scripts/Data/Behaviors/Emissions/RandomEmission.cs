namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "RandomEmission", menuName = "BTD6/Behaviors/Emissions/RandomEmission")]
public class RandomEmission : Emission
{
	public float angle; //Field offset: 0x30
	public float count; //Field offset: 0x34
	public float startOffset; //Field offset: 0x38
	public bool useSpeedMultiplier; //Field offset: 0x3C
	public float speedMultiplierMin; //Field offset: 0x40
	public float speedMultiplierMax; //Field offset: 0x44
	public float ejectPointRandomness; //Field offset: 0x48
	public bool useMainAttackRotation; //Field offset: 0x4C

	public virtual EmissionModel Def
	{
		 get { } //Length: 311
	}

	public RandomEmission() { }

	public virtual EmissionModel get_Def() { }

}

