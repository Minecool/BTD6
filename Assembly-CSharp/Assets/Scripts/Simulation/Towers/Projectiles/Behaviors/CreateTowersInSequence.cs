namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateTowersInSequence : CreateTower
{
	public CreateTowersInSequenceModel createTowersInSequenceModel; //Field offset: 0x70
	private TowerModel towerModelToMake; //Field offset: 0x78

	public CreateTowersInSequence() { }

	private void CreateTower(TowerModel def, Vector3 position) { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void SetTowerModel(TowerModel towerModel, PrefabReference projectileDisplay) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

