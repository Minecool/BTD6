namespace Assets.Scripts.Unity.Towers.Emissions;

public class AlternatingArcEmission : Emission
{
	public AlternatingArcEmission parent; //Field offset: 0x88
	public bool useParentRotation; //Field offset: 0x90
	public string expUseParentRotation; //Field offset: 0x98
	public float angle; //Field offset: 0xA0
	public string expAngle; //Field offset: 0xA8
	public float count; //Field offset: 0xB0
	public string expCount; //Field offset: 0xB8

	public virtual EmissionModel Def
	{
		 get { } //Length: 235
	}

	public AlternatingArcEmission() { }

	public virtual EmissionModel get_Def() { }

}

