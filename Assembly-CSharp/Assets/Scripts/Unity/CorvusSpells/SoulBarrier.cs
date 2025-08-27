namespace Assets.Scripts.Unity.CorvusSpells;

public class SoulBarrier : CorvusInstantSpell
{
	private SoulBarrierModel def; //Field offset: 0x158
	public int manaPerLifeAbsorbed; //Field offset: 0x160
	public string expManaPerLifeAbsorbed; //Field offset: 0x168
	public int maxLivesAbsorbed; //Field offset: 0x170
	public string expMaxLivesAbsorbed; //Field offset: 0x178

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 756
	}

	public SoulBarrier() { }

	public virtual TowerBehaviorModel get_Def() { }

}

