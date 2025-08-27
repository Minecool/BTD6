namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class WeaponRateAnimationSpeed : ProjectileBehavior
{
	public WeaponRateAnimationSpeedModel weaponRateAnimationSpeedModel; //Field offset: 0x68

	public WeaponRateAnimationSpeed() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

