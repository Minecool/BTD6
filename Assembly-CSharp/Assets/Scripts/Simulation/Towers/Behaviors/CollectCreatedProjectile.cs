namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CollectCreatedProjectile : TowerBehavior
{
	public CollectCreatedProjectileModel collectCreatedProjectileModel; //Field offset: 0x68

	public CollectCreatedProjectile() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

