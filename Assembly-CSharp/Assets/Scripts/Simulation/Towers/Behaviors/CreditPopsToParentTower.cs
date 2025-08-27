namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class CreditPopsToParentTower : TowerBehavior
{
	public CreditPopsToParentTowerModel creditPopsToParentTowerModel; //Field offset: 0x68
	private ObjectId towerId; //Field offset: 0x70

	public CreditPopsToParentTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnBloonDamaged(Bloon bloon, float amount) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

