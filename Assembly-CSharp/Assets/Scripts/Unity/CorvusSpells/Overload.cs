namespace Assets.Scripts.Unity.CorvusSpells;

public class Overload : CorvusInstantSpell
{
	private OverloadModel def; //Field offset: 0x158
	public Projectile projectile; //Field offset: 0x160

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 732
	}

	public Overload() { }

	public virtual TowerBehaviorModel get_Def() { }

}

