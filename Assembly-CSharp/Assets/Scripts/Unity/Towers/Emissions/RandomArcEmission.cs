namespace Assets.Scripts.Unity.Towers.Emissions;

public class RandomArcEmission : Emission
{
	public RandomArcEmission parent; //Field offset: 0x88
	public float angle; //Field offset: 0x90
	public string expAngle; //Field offset: 0x98
	public float count; //Field offset: 0xA0
	public string expCount; //Field offset: 0xA8
	public float offset; //Field offset: 0xB0
	public string expOffset; //Field offset: 0xB8
	public float randomAngle; //Field offset: 0xC0
	public string expRandomAngle; //Field offset: 0xC8
	public float startOffset; //Field offset: 0xD0
	public string expStartOffset; //Field offset: 0xD8

	public virtual EmissionModel Def
	{
		 get { } //Length: 295
	}

	public RandomArcEmission() { }

	public virtual EmissionModel get_Def() { }

}

