namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SlowMinusAbilityDuration : Slow
{
	public string abilityId; //Field offset: 0x170
	public string expAbilityId; //Field offset: 0x178

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 425
	}

	public SlowMinusAbilityDuration() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

