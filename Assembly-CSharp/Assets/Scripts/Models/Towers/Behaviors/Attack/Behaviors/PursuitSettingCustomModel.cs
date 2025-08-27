namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(PursuitSettingCustom), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PursuitSettingCustomModel : PursuitSettingModel
{
	public string initialTargetType; //Field offset: 0x40
	public bool useParentForClose; //Field offset: 0x48
	public bool mustBeInRangeOfParent; //Field offset: 0x49

	public PursuitSettingCustomModel(string name, bool isSelectable, float pursuitDistance, bool isOnSubTower, string initialTargetType, bool useParentForClose, bool mustBeInRangeOfParent) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

