namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(LockInPlaceSetting), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LockInPlaceSettingModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40

	public LockInPlaceSettingModel(string name, bool isSelectable, bool isOnSubTower, PrefabReference display) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	public virtual string GetTargetTypeCustomInputClass() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

