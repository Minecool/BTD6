namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class LeakDangerAttackSpeed : WeaponBehavior
{
	public LeakDangerAttackSpeedModel leakDangerAttackSpeedModel; //Field offset: 0x68
	public float calculateFrom; //Field offset: 0x70

	public LeakDangerAttackSpeed() { }

	public virtual float GetRate(float rate) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

