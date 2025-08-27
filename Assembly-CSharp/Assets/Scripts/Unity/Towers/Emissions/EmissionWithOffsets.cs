namespace Assets.Scripts.Unity.Towers.Emissions;

public class EmissionWithOffsets : Emission
{
	public EmissionWithOffsets parent; //Field offset: 0x88
	public int projectileCount; //Field offset: 0x90
	public string expProjectileCount; //Field offset: 0x98
	public bool rotateProjectileWithTower; //Field offset: 0xA0
	public string expRotateProjectileWithTower; //Field offset: 0xA8
	public float randomRotationCone; //Field offset: 0xB0
	public string expRandomRotationCone; //Field offset: 0xB8
	public bool dontSpreadProjectilesAcrossMarkers; //Field offset: 0xC0
	public string expDontSpreadProjectilesAcrossMarkers; //Field offset: 0xC8

	public virtual EmissionModel Def
	{
		 get { } //Length: 318
	}

	public EmissionWithOffsets() { }

	public virtual EmissionModel get_Def() { }

}

