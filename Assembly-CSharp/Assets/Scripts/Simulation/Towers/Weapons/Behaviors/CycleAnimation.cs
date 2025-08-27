namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CycleAnimation : WeaponBehavior
{
	public CycleAnimationModel cycleAnimationModel; //Field offset: 0x68
	private int current; //Field offset: 0x70

	public CycleAnimation() { }

	public virtual Nullable<Int32> GetAnimation(int currentAnimation) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

