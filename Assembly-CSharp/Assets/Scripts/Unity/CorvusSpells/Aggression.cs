namespace Assets.Scripts.Unity.CorvusSpells;

public class Aggression : CorvusContinuousSpell
{
	private AggressionModel def; //Field offset: 0x158
	public float sizeMultiplier; //Field offset: 0x160
	public string expSizeMultiplier; //Field offset: 0x168
	public float rehitCooldownMultiplier; //Field offset: 0x170
	public string expRehitCooldownMultiplier; //Field offset: 0x178
	public GameObject displaySwap; //Field offset: 0x180
	public GameObject expDisplaySwap; //Field offset: 0x188

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 820
	}

	public Aggression() { }

	public virtual TowerBehaviorModel get_Def() { }

}

