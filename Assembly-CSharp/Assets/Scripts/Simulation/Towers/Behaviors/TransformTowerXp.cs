namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class TransformTowerXp : TowerBehavior
{
	public TransformTowerXpModel transformTowerXpModel; //Field offset: 0x68

	public TransformTowerXp() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual float TransformXp(float xp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

