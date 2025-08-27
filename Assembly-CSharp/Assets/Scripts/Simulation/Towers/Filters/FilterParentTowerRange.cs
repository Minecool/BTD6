namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterParentTowerRange : Filter
{
	public FilterParentTowerRangeModel filterParentTowerRangeModel; //Field offset: 0x58
	public Tower parentTower; //Field offset: 0x60
	public Attack parentTowerAttack; //Field offset: 0x68
	private List<Bloon> targets; //Field offset: 0x70

	public FilterParentTowerRange() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

