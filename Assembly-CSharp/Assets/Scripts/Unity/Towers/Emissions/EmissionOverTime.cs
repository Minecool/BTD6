namespace Assets.Scripts.Unity.Towers.Emissions;

public class EmissionOverTime : Emission
{
	public EmissionOverTime parent; //Field offset: 0x88
	public int count; //Field offset: 0x90
	public string expCount; //Field offset: 0x98
	public float timeBetween; //Field offset: 0xA0
	public string expTimeBetween; //Field offset: 0xA8

	public virtual EmissionModel Def
	{
		 get { } //Length: 206
	}

	public EmissionOverTime() { }

	public virtual EmissionModel get_Def() { }

}

