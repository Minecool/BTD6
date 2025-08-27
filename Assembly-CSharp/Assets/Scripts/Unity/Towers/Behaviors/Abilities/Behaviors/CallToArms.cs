namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CallToArms : AbilityBehavior
{
	public CallToArms parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float multiplier; //Field offset: 0xA0
	public string expMultiplier; //Field offset: 0xA8
	public string useRadius; //Field offset: 0xB0
	public string expUseRadius; //Field offset: 0xB8
	public string buffLocsName; //Field offset: 0xC0
	public string expBuffLocsName; //Field offset: 0xC8
	public string buffIconName; //Field offset: 0xD0
	public string expBuffIconName; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 217
	}

	public CallToArms() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

