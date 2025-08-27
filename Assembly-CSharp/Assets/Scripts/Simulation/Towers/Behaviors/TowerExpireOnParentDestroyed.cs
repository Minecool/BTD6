namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerExpireOnParentDestroyed : TowerBehavior
{
	public TowerExpireOnParentDestroyedModel towerExpireOnParentDestroyedModel; //Field offset: 0x68
	private Tower parentTower; //Field offset: 0x70
	private bool getParentTower; //Field offset: 0x78

	public TowerExpireOnParentDestroyed() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void Process(int elapsed) { }

	private void TowerDestroyed(Tower destroyedTower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

