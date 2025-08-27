namespace Assets.Scripts.Unity.CorvusSpells.Continuous;

public class Malevolence : CorvusContinuousSpell
{
	private MalevolenceModel def; //Field offset: 0x158
	public Attack attack; //Field offset: 0x160
	public float absorptionDuration; //Field offset: 0x168
	public string expAbsorptionDuration; //Field offset: 0x170

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 836
	}

	public Malevolence() { }

	public virtual TowerBehaviorModel get_Def() { }

}

