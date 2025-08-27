namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SellStackedTowers : TowerBehavior
{
	public SellStackedTowersModel sellStackedTowersModel; //Field offset: 0x68

	public SellStackedTowers() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

