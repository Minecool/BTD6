namespace Assets.Scripts.Unity.Towers.Emissions;

public class PointEmission : Emission
{
	public PointEmission parent; //Field offset: 0x88
	public bool checkLineOfSight; //Field offset: 0x90
	public string expCheckLineOfSight; //Field offset: 0x98

	public virtual EmissionModel Def
	{
		 get { } //Length: 185
	}

	public PointEmission() { }

	public virtual EmissionModel get_Def() { }

}

