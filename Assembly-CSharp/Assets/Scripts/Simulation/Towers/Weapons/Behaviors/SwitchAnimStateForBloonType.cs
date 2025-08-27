namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class SwitchAnimStateForBloonType : WeaponBehavior
{
	private SwitchAnimStateForBloonTypeModel switchAnimStateForBloonTypeModel; //Field offset: 0x68

	public SwitchAnimStateForBloonType() { }

	public virtual Nullable<Int32> GetAnimation(int currentAnimation) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

