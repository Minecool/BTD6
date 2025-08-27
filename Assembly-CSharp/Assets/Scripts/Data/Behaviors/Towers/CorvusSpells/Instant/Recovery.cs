namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Recovery", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Recovery")]
public class Recovery : CorvusInstantSpell
{
	public float spellRecoveryRate; //Field offset: 0x88
	public float absorptionDuration; //Field offset: 0x8C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 643
	}

	public Recovery() { }

	public virtual TowerBehaviorModel get_Def() { }

}

