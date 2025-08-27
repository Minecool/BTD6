namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class IgnoreThrowMarker : WeaponBehavior
{
	public IgnoreThrowMarkerModel ignoreThrowMarkerModel; //Field offset: 0x68

	public IgnoreThrowMarker() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

