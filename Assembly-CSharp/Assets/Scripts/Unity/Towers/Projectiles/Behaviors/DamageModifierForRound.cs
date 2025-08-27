namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageModifierForRound : DamageModifier
{
	public DamageModifierForRound parent; //Field offset: 0x88
	public float damagePerRound; //Field offset: 0x90
	public string expDamagePerRound; //Field offset: 0x98
	public int roundCap; //Field offset: 0xA0
	public string expRoundCap; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public DamageModifierForRound() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

