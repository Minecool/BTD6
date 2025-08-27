namespace Assets.Scripts.Unity.CorvusSpells;

public class Nourishment : CorvusInstantSpell
{
	private NourishmentModel def; //Field offset: 0x158
	public float xpPerMana; //Field offset: 0x160
	public string expXpPerMana; //Field offset: 0x168
	public float cashPerManaAtMaxLevel; //Field offset: 0x170
	public string expCashPerManaAtMaxLevel; //Field offset: 0x178

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 751
	}

	public Nourishment() { }

	public virtual TowerBehaviorModel get_Def() { }

}

