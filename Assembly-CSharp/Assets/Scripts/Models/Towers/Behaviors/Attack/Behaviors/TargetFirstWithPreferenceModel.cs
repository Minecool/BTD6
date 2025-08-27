namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetFirstWithPreference), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetFirstWithPreferenceModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public string priorityBloonTags; //Field offset: 0x40
	public String[] priorityBloonTagsList; //Field offset: 0x48

	public TargetFirstWithPreferenceModel(string name, bool isSelectable, bool isOnSubTower, string priorityBloonTags) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

