namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageUpPerAbilityActivateModifier : DamageModifier
{
	public DamageUpPerAbilityActivateModifier parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public DamageUpPerAbilityActivateModifier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

