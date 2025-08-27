namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(RandomTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomTargetModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public bool keepTargetUntilInvalid; //Field offset: 0x39
	public bool ignoreOtherRandomTargets; //Field offset: 0x3A

	public RandomTargetModel(string name, bool isSelectable, bool isOnSubTower, bool keepTargetUntilInvalid, bool ignoreOtherRandomTargets) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

