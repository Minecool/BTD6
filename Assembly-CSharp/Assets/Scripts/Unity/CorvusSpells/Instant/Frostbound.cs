namespace Assets.Scripts.Unity.CorvusSpells.Instant;

public class Frostbound : CorvusInstantSpell
{
	private FrostboundModel def; //Field offset: 0x158
	public Projectile projectile; //Field offset: 0x160

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 732
	}

	public Frostbound() { }

	public virtual TowerBehaviorModel get_Def() { }

}

