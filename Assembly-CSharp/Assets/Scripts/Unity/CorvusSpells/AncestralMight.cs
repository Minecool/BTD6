namespace Assets.Scripts.Unity.CorvusSpells;

public class AncestralMight : CorvusInstantSpell
{
	private AncestralMightModel def; //Field offset: 0x158
	public Attack attack; //Field offset: 0x160
	public float absorptionDuration; //Field offset: 0x168
	public string expAbsorptionDuration; //Field offset: 0x170
	public GameObject withEchoSwap; //Field offset: 0x178
	public GameObject expWithEchoSwap; //Field offset: 0x180

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 920
	}

	public AncestralMight() { }

	public virtual TowerBehaviorModel get_Def() { }

}

