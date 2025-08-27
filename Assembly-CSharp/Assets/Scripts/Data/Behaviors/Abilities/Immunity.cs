namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Immunity", menuName = "BTD6/Behaviors/Abilities/Immunity")]
public class Immunity : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public Effect effect; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 219
	}

	public Immunity() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

