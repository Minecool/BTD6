namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetLastSharedRange), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetLastSharedRangeModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public bool isSharedRangeEnabled; //Field offset: 0x39
	public bool isGlobalRange; //Field offset: 0x3A
	public bool isGettingRangeFromSpecificTower; //Field offset: 0x3B
	public string specificTowerType; //Field offset: 0x40

	public TargetLastSharedRangeModel(string name, bool isSelectable, bool isSharedRangeEnabled, bool isOnSubTower, bool isGlobalRange, bool isGettingRangeFromSpecificTower = false, string specificTowerType = "") { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

