namespace Assets.Scripts.Unity.CorvusSpells.PassiveBonuses;

public class SpiritualWill : TowerBehavior
{
	private SpiritualWillModel def; //Field offset: 0x98
	public int manaPerSecond; //Field offset: 0xA0
	public string expManaPerSecond; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public SpiritualWill() { }

	public virtual TowerBehaviorModel get_Def() { }

}

