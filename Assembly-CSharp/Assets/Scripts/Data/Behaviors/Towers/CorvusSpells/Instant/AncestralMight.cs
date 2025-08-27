namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "AncestralMight", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/AncestralMight")]
public class AncestralMight : CorvusInstantSpell
{
	public Attack attack; //Field offset: 0x88
	public float absorptionDuration; //Field offset: 0x90
	public PrefabReference withEchoSwap; //Field offset: 0x98

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 795
	}

	public AncestralMight() { }

	public virtual TowerBehaviorModel get_Def() { }

}

