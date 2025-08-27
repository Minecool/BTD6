namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetIndependant), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetIndependantModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public TargetSupplierModel targetProvider; //Field offset: 0x40

	public TargetIndependantModel(string name, bool isSelectable, TargetSupplierModel targetProvider, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

