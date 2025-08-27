namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterBloonsToWithinAngle : Filter
{
	public FilterBloonsToWithinAngleModel filterBloonsToWithinAngleModel; //Field offset: 0x58
	private Vector2 originPosition; //Field offset: 0x60
	private bool originNeedsUpdate; //Field offset: 0x68

	public FilterBloonsToWithinAngle() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateOrigin() { }

}

