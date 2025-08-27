namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DepletionToCash : ProjectileBehavior
{
	public DepletionToCashModel depletionToCashModel; //Field offset: 0x68
	private bool cashedIn; //Field offset: 0x70

	public float amount
	{
		 get { } //Length: 46
	}

	public DepletionToCash() { }

	public float get_amount() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual float Pickup(Tower towerPickingUp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

