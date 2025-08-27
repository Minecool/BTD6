namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "PursuitSettingCustom", menuName = "BTD6/Behaviors/Attacks/PursuitSettingCustom")]
public class PursuitSettingCustom : PursuitSetting
{
	public string initialTargetType; //Field offset: 0x40
	public bool useParentForClose; //Field offset: 0x48
	public bool mustBeInRangeOfParent; //Field offset: 0x49

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 196
	}

	public PursuitSettingCustom() { }

	public virtual AttackBehaviorModel get_Def() { }

}

