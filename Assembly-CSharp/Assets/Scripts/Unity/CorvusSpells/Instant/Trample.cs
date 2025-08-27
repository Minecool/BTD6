namespace Assets.Scripts.Unity.CorvusSpells.Instant;

public class Trample : CorvusInstantSpell
{
	private TrampleModel def; //Field offset: 0x158
	public float speedBonus; //Field offset: 0x160
	public string expSpeedBonus; //Field offset: 0x168
	public Projectile projectile; //Field offset: 0x170

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 769
	}

	public Trample() { }

	public virtual TowerBehaviorModel get_Def() { }

}

