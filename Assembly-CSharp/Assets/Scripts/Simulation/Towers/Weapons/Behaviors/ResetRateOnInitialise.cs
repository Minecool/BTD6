namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class ResetRateOnInitialise : WeaponBehavior
{
	public ResetRateOnInitialiseModel resetRateOnInitialiseModel; //Field offset: 0x68

	public ResetRateOnInitialise() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

