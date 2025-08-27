namespace Assets.Scripts.Models.Towers.Behaviors.Attack;

[Implementation(typeof(Attack), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AttackModel : TowerBehaviorModel
{
	public WeaponModel[] weapons; //Field offset: 0x30
	public Model[] behaviors; //Field offset: 0x38
	public float range; //Field offset: 0x40
	public TargetSupplierModel targetProvider; //Field offset: 0x48
	public float offsetX; //Field offset: 0x50
	public float offsetY; //Field offset: 0x54
	public float offsetZ; //Field offset: 0x58
	public bool attackThroughWalls; //Field offset: 0x5C
	public bool fireWithoutTarget; //Field offset: 0x5D
	public int framesBeforeRetarget; //Field offset: 0x60
	public bool addsToSharedGrid; //Field offset: 0x64
	public float sharedGridRange; //Field offset: 0x68
	public bool drawRangeCircle; //Field offset: 0x6C

	public AttackModel(string name, WeaponModel[] weapons, float range, Model[] behaviors, TargetSupplierModel targetProvider, float offsetX, float offsetY, float offsetZ, bool attackThroughWalls, bool fireWithoutTarget, int framesBeforeRetarget, bool addsToSharedGrid, float sharedGridRange, bool drawRangeCircle) { }

	public virtual Model[] BehaviorModels() { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual void SetBehaviorModels(Model[] behaviors) { }

}

