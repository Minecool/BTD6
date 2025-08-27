namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(EmissionWithOffsets), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionWithOffsetsModel : EmissionModel
{
	public ThrowMarkerOffsetModel[] throwMarkerOffsetModels; //Field offset: 0x38
	public int projectileCount; //Field offset: 0x40
	public bool rotateProjectileWithTower; //Field offset: 0x44
	public float randomRotationCone; //Field offset: 0x48
	public bool spreadProjectilesAcrossMarkers; //Field offset: 0x4C

	public EmissionWithOffsetsModel(string id, ThrowMarkerOffsetModel[] throwMarkerOffsetModels, int projectileCount, bool rotateProjectileWithTower, EmissionBehaviorModel[] behaviors, float randomRotationCone, bool spreadProjectilesAcrossMarkers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

