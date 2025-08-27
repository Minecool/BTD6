namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "IncreaseRange", menuName = "BTD6/Behaviors/Abilities/IncreaseRange")]
public class IncreaseRange : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public float addative; //Field offset: 0x38
	public bool endOnDefeatScreen; //Field offset: 0x3C

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 184
	}

	public IncreaseRange() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

