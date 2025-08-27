namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Overload", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Overload")]
public class Overload : CorvusInstantSpell
{
	public Projectile projectile; //Field offset: 0x88

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 644
	}

	public Overload() { }

	public virtual TowerBehaviorModel get_Def() { }

}

