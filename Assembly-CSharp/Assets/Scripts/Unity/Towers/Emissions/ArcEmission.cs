namespace Assets.Scripts.Unity.Towers.Emissions;

public class ArcEmission : Emission
{
	public ArcEmission parent; //Field offset: 0x88
	public float angle; //Field offset: 0x90
	public string expAngle; //Field offset: 0x98
	public float offset; //Field offset: 0xA0
	public string expOffset; //Field offset: 0xA8
	public float count; //Field offset: 0xB0
	public string expCount; //Field offset: 0xB8
	public bool useProjectileRotation; //Field offset: 0xC0
	public string expUseProjectileRotation; //Field offset: 0xC8
	public bool useAirUnitRotation; //Field offset: 0xD0
	public string expUseAirUnitRotation; //Field offset: 0xD8

	public virtual EmissionModel Def
	{
		 get { } //Length: 284
	}

	public ArcEmission() { }

	public virtual EmissionModel get_Def() { }

}

