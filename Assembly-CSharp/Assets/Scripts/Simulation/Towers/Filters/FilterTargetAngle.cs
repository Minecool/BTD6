namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterTargetAngle : Filter
{
	public FilterTargetAngleModel filterTargetAngleModel; //Field offset: 0x58
	private DisplayBehavior display; //Field offset: 0x60
	private Tower tower; //Field offset: 0x68
	private AirUnit airUnit; //Field offset: 0x70

	public FilterTargetAngle() { }

	public virtual void Attatched() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	private void FindDisplay() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

