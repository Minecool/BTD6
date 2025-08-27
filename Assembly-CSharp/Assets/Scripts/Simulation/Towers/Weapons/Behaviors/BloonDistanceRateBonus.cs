namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class BloonDistanceRateBonus : WeaponBehavior
{
	public BloonDistanceRateBonusModel bloonDistanceRateBonusModel; //Field offset: 0x68

	public BloonDistanceRateBonus() { }

	public virtual float GetRate(float rate) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

