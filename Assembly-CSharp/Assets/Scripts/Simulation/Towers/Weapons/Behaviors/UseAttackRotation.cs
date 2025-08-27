namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class UseAttackRotation : WeaponBehavior
{
	public UseAttackRotationModel useAttackRotationModel; //Field offset: 0x68

	public UseAttackRotation() { }

	public virtual Nullable<Single> EmitRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

