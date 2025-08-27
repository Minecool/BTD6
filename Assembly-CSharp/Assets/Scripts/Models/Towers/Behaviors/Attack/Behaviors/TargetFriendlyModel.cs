namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetFriendly), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetFriendlyModel : TargetSupplierModel
{
	public string ignoreList; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x40
	public string mutationId; //Field offset: 0x48
	public bool mustHaveWeapon; //Field offset: 0x50

	public TargetFriendlyModel(string name, string ignoreList, bool isSelectable, bool isOnSubTower, string mutationId, bool mustHaveWeapon) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

