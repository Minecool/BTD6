namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class LinkProjectileRadiusToTowerRange : TowerBehavior
{
	public LinkProjectileRadiusToTowerRangeModel modl; //Field offset: 0x68

	public LinkProjectileRadiusToTowerRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRangeChanged() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

