namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "AttackAirUnit", menuName = "BTD6/Behaviors/Attacks/AttackAirUnit")]
public class AttackAirUnit : Attack
{

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 828
	}

	public AttackAirUnit() { }

	public virtual TowerBehaviorModel get_Def() { }

}

