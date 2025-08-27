namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Repel", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Repel")]
public class Repel : CorvusInstantSpell
{
	public Projectile projectile; //Field offset: 0x88

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 644
	}

	public Repel() { }

	public virtual TowerBehaviorModel get_Def() { }

}

