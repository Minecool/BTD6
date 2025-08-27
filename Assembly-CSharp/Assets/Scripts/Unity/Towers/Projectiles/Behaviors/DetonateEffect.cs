namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DetonateEffect : ProjectileBehavior
{
	public DetonateEffect parent; //Field offset: 0x88
	public string effectMutationIds; //Field offset: 0x90
	public string expEffectMutationIds; //Field offset: 0x98
	public float damagePerSecondRemaining; //Field offset: 0xA0
	public string expDamagePerSecondRemaining; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 135
	}

	public DetonateEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

