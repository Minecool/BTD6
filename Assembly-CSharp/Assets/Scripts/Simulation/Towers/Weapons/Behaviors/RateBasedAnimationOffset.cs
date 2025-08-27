namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class RateBasedAnimationOffset : WeaponBehavior
{
	public RateBasedAnimationOffsetModel rateBasedAnimationOffsetModel; //Field offset: 0x68

	public RateBasedAnimationOffset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

