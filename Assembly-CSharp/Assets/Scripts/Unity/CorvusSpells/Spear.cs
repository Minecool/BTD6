namespace Assets.Scripts.Unity.CorvusSpells;

public class Spear : CorvusContinuousSpell
{
	private SpearModel def; //Field offset: 0x158
	public Attack attack; //Field offset: 0x160

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 805
	}

	public Spear() { }

	public virtual TowerBehaviorModel get_Def() { }

}

