namespace Assets.Scripts.Unity.Towers.Emissions;

public class SingleEmmisionTowardsTarget : Emission
{
	public SingleEmmisionTowardsTarget parent; //Field offset: 0x88
	public float offset; //Field offset: 0x90
	public string expOffset; //Field offset: 0x98

	public virtual EmissionModel Def
	{
		 get { } //Length: 185
	}

	public SingleEmmisionTowardsTarget() { }

	public virtual EmissionModel get_Def() { }

}

