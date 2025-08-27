namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class BrickellFreezeMinesAbilityBuff : AbilityBehavior
{
	public BrickellFreezeMinesAbilityBuff parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	public float projectileSpeedMultiplier; //Field offset: 0xA0
	public string expProjectileSpeedMultiplier; //Field offset: 0xA8
	public float duration; //Field offset: 0xB0
	public string expDuration; //Field offset: 0xB8
	public string buffLocsName; //Field offset: 0xC0
	public string expBuffLocsName; //Field offset: 0xC8
	public string buffIconName; //Field offset: 0xD0
	public string expBuffIconName; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 208
	}

	public BrickellFreezeMinesAbilityBuff() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

