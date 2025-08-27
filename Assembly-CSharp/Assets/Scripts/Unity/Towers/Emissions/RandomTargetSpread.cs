namespace Assets.Scripts.Unity.Towers.Emissions;

public class RandomTargetSpread : Emission
{
	public RandomTargetSpread parent; //Field offset: 0x88
	public float spread; //Field offset: 0x90
	public string expSpread; //Field offset: 0x98

	public virtual EmissionModel Def
	{
		 get { } //Length: 257
	}

	public RandomTargetSpread() { }

	public virtual EmissionModel get_Def() { }

}

