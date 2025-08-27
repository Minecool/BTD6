namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "SlowMinusAbilityDuration", menuName = "BTD6/Behaviors/Projectiles/SlowMinusAbilityDuration")]
public class SlowMinusAbilityDuration : Slow
{
	public string abilityId; //Field offset: 0x80

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 404
	}

	public SlowMinusAbilityDuration() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

