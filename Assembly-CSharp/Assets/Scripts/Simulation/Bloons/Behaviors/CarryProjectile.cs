namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CarryProjectile : BloonBehavior
{
	private CarryProjectileModel carryProjectileModel; //Field offset: 0x70
	private Emission emission; //Field offset: 0x78
	private List<Projectile> projectilesCreated; //Field offset: 0x80
	private List<Projectile> removeList; //Field offset: 0x88

	public CarryProjectile() { }

	public virtual void Attatched() { }

	private void Emit() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool LayersExhaused(DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

