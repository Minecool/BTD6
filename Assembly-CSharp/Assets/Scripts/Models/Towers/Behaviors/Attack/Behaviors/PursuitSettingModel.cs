namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(PursuitSetting), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PursuitSettingModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public float pursuitDistance; //Field offset: 0x3C

	public PursuitSettingModel(string name, bool isSelectable, float pursuitDistance, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

