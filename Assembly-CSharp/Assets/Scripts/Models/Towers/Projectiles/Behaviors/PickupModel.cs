namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Pickup), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PickupModel : ProjectileBehaviorModel
{
	public float collectRadius; //Field offset: 0x38
	[SerializeField]
	private float delay; //Field offset: 0x3C
	public float delayFrames; //Field offset: 0x40
	public bool isCamoPickup; //Field offset: 0x44

	public PickupModel(string name, float collectRadius, float delay, bool isCamoPickup) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

