namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ScaleHeroXpWithTowerCount : TowerBehavior
{
	public ScaleHeroXpWithTowerCountModel scaleHeroXpWithTowerCountModel; //Field offset: 0x68

	public ScaleHeroXpWithTowerCount() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual float TransformXp(float xp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

