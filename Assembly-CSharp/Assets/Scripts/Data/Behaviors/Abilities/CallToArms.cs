namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CallToArms", menuName = "BTD6/Behaviors/Abilities/CallToArms")]
public class CallToArms : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public bool useRadius; //Field offset: 0x38
	public string buffLocsName; //Field offset: 0x40
	public string buffIconName; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 192
	}

	public CallToArms() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

