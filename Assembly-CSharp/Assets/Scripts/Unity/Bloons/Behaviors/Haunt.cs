namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class Haunt : BloonBehavior
{
	private HauntModel def; //Field offset: 0x88
	public float bonusEnergyDamage; //Field offset: 0x90
	public string expBonusEnergyDamage; //Field offset: 0x98
	public int manaPerRbe; //Field offset: 0xA0
	public string expManaPerRbe; //Field offset: 0xA8
	public Projectile projectileOnDestroy; //Field offset: 0xB0
	public Effect effectOnDestroy; //Field offset: 0xB8
	public Effect expEffectOnDestroy; //Field offset: 0xC0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 294
	}

	public Haunt() { }

	public virtual BloonBehaviorModel get_Def() { }

}

