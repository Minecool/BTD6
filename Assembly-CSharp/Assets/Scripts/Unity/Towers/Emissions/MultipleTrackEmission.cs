namespace Assets.Scripts.Unity.Towers.Emissions;

public class MultipleTrackEmission : Emission
{
	public MultipleTrackEmission parent; //Field offset: 0x88
	public float offset; //Field offset: 0x90
	public float count; //Field offset: 0x94
	public string expOffset; //Field offset: 0x98
	public string expCount; //Field offset: 0xA0

	public virtual EmissionModel Def
	{
		 get { } //Length: 210
	}

	public MultipleTrackEmission() { }

	public virtual EmissionModel get_Def() { }

}

