namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "AttackFilter", menuName = "BTD6/Behaviors/Attacks/AttackFilter")]
public class AttackFilter : AttackBehavior
{
	public Filter[] filters; //Field offset: 0x30

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 132
	}

	public AttackFilter() { }

	public virtual AttackBehaviorModel get_Def() { }

}

