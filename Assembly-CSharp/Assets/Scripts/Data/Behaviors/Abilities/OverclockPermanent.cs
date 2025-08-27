namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "OverclockPermanent", menuName = "BTD6/Behaviors/Abilities/OverclockPermanent")]
public class OverclockPermanent : AbilityBehavior
{
	public float rateModifier; //Field offset: 0x30
	public float villageRangeModifier; //Field offset: 0x34
	public int maxStacks; //Field offset: 0x38
	public string buffLocsName; //Field offset: 0x40
	public string buffIconName; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 190
	}

	public OverclockPermanent() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

