namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(SubmergedTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SubmergedTargetModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38

	public SubmergedTargetModel(string name, bool isSelectable, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool ContinueToNextPriority() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

