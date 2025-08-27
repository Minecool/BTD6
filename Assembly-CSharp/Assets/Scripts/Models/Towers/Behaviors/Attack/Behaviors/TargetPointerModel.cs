namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetPointer), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetPointerModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public string customName; //Field offset: 0x40
	public bool setOnAttached; //Field offset: 0x48

	public TargetPointerModel(string name, bool isSelectable, bool isOnSubTower, string custonName, bool setOnAttached) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

