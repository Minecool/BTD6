namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Haste", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Haste")]
public class Haste : CorvusInstantSpell
{
	public float orbitSpeedMultiplier; //Field offset: 0x88
	public float turnSpeedMultiplier; //Field offset: 0x8C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 662
	}

	public Haste() { }

	public virtual TowerBehaviorModel get_Def() { }

}

