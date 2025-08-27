namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class UseParentEject : WeaponBehavior
{
	public UseParentEjectModel useParentEjectModel; //Field offset: 0x68

	public UseParentEject() { }

	public virtual Nullable<Vector3> EmitPosition() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

