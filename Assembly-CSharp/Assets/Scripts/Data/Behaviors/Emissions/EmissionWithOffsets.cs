namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionWithOffsets", menuName = "BTD6/Behaviors/Emissions/EmissionWithOffsets")]
public class EmissionWithOffsets : Emission
{
	public int projectileCount; //Field offset: 0x30
	public bool rotateProjectileWithTower; //Field offset: 0x34
	public float randomRotationCone; //Field offset: 0x38
	public ThrowMarkerOffset[] throwMarkerOffsets; //Field offset: 0x40

	public virtual EmissionModel Def
	{
		 get { } //Length: 234
	}

	public EmissionWithOffsets() { }

	public virtual EmissionModel get_Def() { }

}

