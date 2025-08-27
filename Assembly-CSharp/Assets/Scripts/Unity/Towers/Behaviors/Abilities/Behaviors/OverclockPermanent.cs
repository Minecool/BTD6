namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class OverclockPermanent : AbilityBehavior
{
	public OverclockPermanent parent; //Field offset: 0x88
	public float rateModifier; //Field offset: 0x90
	public string expRateModifier; //Field offset: 0x98
	public float villageRangeModifier; //Field offset: 0xA0
	public string expVillageRangeModifier; //Field offset: 0xA8
	public int maxStacks; //Field offset: 0xB0
	public string expMaxStacks; //Field offset: 0xB8
	public string buffLocsName; //Field offset: 0xC0
	public string expBuffLocsName; //Field offset: 0xC8
	public string buffIconName; //Field offset: 0xD0
	public string expBuffIconName; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 205
	}

	public OverclockPermanent() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

