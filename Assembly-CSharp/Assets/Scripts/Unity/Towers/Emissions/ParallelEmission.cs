namespace Assets.Scripts.Unity.Towers.Emissions;

public class ParallelEmission : Emission
{
	public ParallelEmission parent; //Field offset: 0x88
	public float spreadLength; //Field offset: 0x90
	public string expSpreadLength; //Field offset: 0x98
	public float yOffset; //Field offset: 0xA0
	public string expYOffset; //Field offset: 0xA8
	public float count; //Field offset: 0xB0
	public string expCount; //Field offset: 0xB8
	public bool linear; //Field offset: 0xC0
	public string expLinear; //Field offset: 0xC8

	public virtual EmissionModel Def
	{
		 get { } //Length: 260
	}

	public ParallelEmission() { }

	public virtual EmissionModel get_Def() { }

}

