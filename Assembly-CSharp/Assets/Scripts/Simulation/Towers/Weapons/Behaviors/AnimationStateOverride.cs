namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class AnimationStateOverride : WeaponBehavior
{
	public AnimationStateOverrideModel animationStateOverrideModel; //Field offset: 0x68

	public AnimationStateOverride() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

