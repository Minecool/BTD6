namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageModifierUnstableConcoction : DamageModifier
{
	public DamageModifierForModifiers parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public DamageModifierUnstableConcoction() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

