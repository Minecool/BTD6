namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(MapItemVsProjectileBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MapItemVsProjectileBehaviorModel : SimulationBehaviorModel
{
	public float collisionMarkerX; //Field offset: 0x30
	public float collisionMarkerY; //Field offset: 0x34
	public float collisionRadius; //Field offset: 0x38
	public string projectileChipTag; //Field offset: 0x40

	public MapItemVsProjectileBehaviorModel(string name, float collisionMarkerX, float collisionMarkerY, float collisionRadius, string projectileChipTag) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

