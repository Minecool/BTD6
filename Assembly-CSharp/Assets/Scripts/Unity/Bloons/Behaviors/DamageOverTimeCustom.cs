namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class DamageOverTimeCustom : DamageOverTime
{
	public string bloonTags; //Field offset: 0x188
	public string expBloonTags; //Field offset: 0x190
	public float multiplier; //Field offset: 0x198
	public string expMultiplier; //Field offset: 0x1A0
	public int additive; //Field offset: 0x1A8
	public string expAdditive; //Field offset: 0x1B0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 2266
	}

	public DamageOverTimeCustom() { }

	public virtual BloonBehaviorModel get_Def() { }

}

