namespace Assets.Scripts.Unity.Towers.Emissions;

public class AdoraEmission : Emission
{
	public AdoraEmission parent; //Field offset: 0x88
	public int count; //Field offset: 0x90
	public string expCount; //Field offset: 0x98
	public float angleBetween; //Field offset: 0xA0
	public string expAngleBetween; //Field offset: 0xA8

	public virtual EmissionModel Def
	{
		 get { } //Length: 206
	}

	public AdoraEmission() { }

	public virtual EmissionModel get_Def() { }

}

