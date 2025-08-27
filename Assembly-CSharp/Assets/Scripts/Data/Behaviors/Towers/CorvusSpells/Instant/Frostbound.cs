namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Frostbound", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Frostbound")]
public class Frostbound : CorvusInstantSpell
{
	public Projectile projectile; //Field offset: 0x88

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 644
	}

	public Frostbound() { }

	public virtual TowerBehaviorModel get_Def() { }

}

