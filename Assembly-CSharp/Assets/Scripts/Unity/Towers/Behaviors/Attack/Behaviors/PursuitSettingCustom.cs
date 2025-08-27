namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class PursuitSettingCustom : PursuitSetting
{
	public string initialTargetType; //Field offset: 0xB0
	public string expInitialTargetType; //Field offset: 0xB8
	public bool useParentForClose; //Field offset: 0xC0
	public string expUseParentForClose; //Field offset: 0xC8
	public bool mustBeInRangeOfParent; //Field offset: 0xD0
	public string expMustBeInRangeOfParent; //Field offset: 0xD8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 220
	}

	public PursuitSettingCustom() { }

	public virtual AttackBehaviorModel get_Def() { }

}

