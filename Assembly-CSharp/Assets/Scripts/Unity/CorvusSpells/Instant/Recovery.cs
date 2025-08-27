namespace Assets.Scripts.Unity.CorvusSpells.Instant;

public class Recovery : CorvusInstantSpell
{
	private RecoveryModel def; //Field offset: 0x158
	public float spellRecoveryRate; //Field offset: 0x160
	public string expSpellRecoveryRate; //Field offset: 0x168
	public float absorptionDuration; //Field offset: 0x170
	public string expAbsorptionDuration; //Field offset: 0x178

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 751
	}

	public Recovery() { }

	public virtual TowerBehaviorModel get_Def() { }

}

