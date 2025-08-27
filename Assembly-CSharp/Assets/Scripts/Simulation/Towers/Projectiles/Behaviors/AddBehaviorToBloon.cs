namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddBehaviorToBloon : ProjectileBehavior
{
	public AddBehaviorToBloonModel addBehaviorToBloonModel; //Field offset: 0x68
	private Filter bloonFilter; //Field offset: 0x70
	private List<Filter> bloonFilters; //Field offset: 0x78
	private Damage damageBehavior; //Field offset: 0x80

	public AddBehaviorToBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

