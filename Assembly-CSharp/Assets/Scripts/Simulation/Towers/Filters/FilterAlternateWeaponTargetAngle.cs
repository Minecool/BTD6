namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterAlternateWeaponTargetAngle : Filter
{
	public FilterAlternateWeaponTargetAngleModel filterAlternateWeaponTargetAngle; //Field offset: 0x58
	public DisplayNode node; //Field offset: 0x60

	public FilterAlternateWeaponTargetAngle() { }

	public virtual void Attatched() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

