namespace Assets.Scripts.Unity.Towers.Emissions;

public class RandomEmission : Emission
{
	public RandomEmission parent; //Field offset: 0x88
	public float angle; //Field offset: 0x90
	public float count; //Field offset: 0x94
	public float startOffset; //Field offset: 0x98
	public string expAngle; //Field offset: 0xA0
	public string expCount; //Field offset: 0xA8
	public string expStartOffset; //Field offset: 0xB0
	public bool useSpeedMultiplier; //Field offset: 0xB8
	public string expUseSpeedMultiplier; //Field offset: 0xC0
	public float speedMultiplierMin; //Field offset: 0xC8
	public string expSpeedMultiplierMin; //Field offset: 0xD0
	public float speedMultiplierMax; //Field offset: 0xD8
	public string expSpeedMultiplierMax; //Field offset: 0xE0
	public float ejectPointRandomness; //Field offset: 0xE8
	public string expEjectPointRandomness; //Field offset: 0xF0
	public bool useMainAttackRotation; //Field offset: 0xF8
	public string expUseMainAttackRotation; //Field offset: 0x100

	public virtual EmissionModel Def
	{
		 get { } //Length: 361
	}

	public RandomEmission() { }

	public virtual EmissionModel get_Def() { }

}

