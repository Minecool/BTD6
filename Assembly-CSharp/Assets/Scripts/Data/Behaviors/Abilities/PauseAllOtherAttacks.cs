namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "PauseAllOtherAttacks", menuName = "BTD6/Behaviors/Abilities/PauseAllOtherAttacks")]
public class PauseAllOtherAttacks : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public bool endOnRoundEnd; //Field offset: 0x34
	public bool endOnDefeatScreen; //Field offset: 0x35

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public PauseAllOtherAttacks() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

