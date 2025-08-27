namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class Standoff : WeaponBehavior
{
	public StandoffModel standoffModel; //Field offset: 0x68

	public Standoff() { }

	public virtual float GetRate(float rate) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

