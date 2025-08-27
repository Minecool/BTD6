namespace Assets.Scripts.Unity.CorvusSpells;

public class Repel : CorvusInstantSpell
{
	private RepelModel def; //Field offset: 0x158
	public Projectile projectile; //Field offset: 0x160

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 732
	}

	public Repel() { }

	public virtual TowerBehaviorModel get_Def() { }

}

