namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class IgnoreTowersBlocker : TowerBehavior
{
	public IgnoreTowersBlockerModel ignoreTowersBlockerModel; //Field offset: 0x68

	public IgnoreTowersBlocker() { }

	public bool FilterTowers(String[] areaType) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

