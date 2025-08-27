namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class FilterFractionOfBloonType : ProjectileBehavior
{
	public FilterFractionOfBloonTypeModel projectileFilterModel; //Field offset: 0x68
	private int collidedBloonsOfTypeCount; //Field offset: 0x70
	private int affectedBloonCount; //Field offset: 0x74

	public FilterFractionOfBloonType() { }

	public virtual bool FilterCollision(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

