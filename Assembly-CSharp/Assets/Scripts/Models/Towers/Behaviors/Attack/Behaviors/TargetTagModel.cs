namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetTag), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetTagModel : TargetSupplierModel
{
	public string tag; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x40
	public bool findStrongest; //Field offset: 0x41

	public TargetTagModel(string name, string tag, bool isSelectable, bool findStrongest, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

