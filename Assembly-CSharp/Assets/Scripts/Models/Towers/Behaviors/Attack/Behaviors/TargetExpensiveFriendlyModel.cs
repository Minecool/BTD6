namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetExpensiveFriendly), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetExpensiveFriendlyModel : TargetSupplierModel
{
	public string ignoreList; //Field offset: 0x38
	public bool ignorePrevious; //Field offset: 0x40
	public string previousId; //Field offset: 0x48
	public bool useRange; //Field offset: 0x50
	public bool isSelectable; //Field offset: 0x51

	public TargetExpensiveFriendlyModel(string name, string ignoreList, bool ignorePrevious, string previousId, bool useRange, bool isSelectable, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

