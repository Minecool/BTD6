namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Pickup : ProjectileBehavior
{
	public PickupModel pickupModel; //Field offset: 0x68
	private Vector3Boxed collectPoint; //Field offset: 0x70
	private bool foundPoint; //Field offset: 0x78
	private bool farmerPickup; //Field offset: 0x79
	private int currentCollectFrames; //Field offset: 0x7C
	private readonly float innerCollectRadius; //Field offset: 0x80
	private readonly int maxCollectFrames; //Field offset: 0x84

	public Pickup() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsFarmerPickup() { }

	public bool IsIgnoringOthers() { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public void StartFarmerPickup() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateInputCursorLocation(Vector2 holdPoint) { }

}

