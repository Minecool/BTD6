namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Trample", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Trample")]
public class Trample : CorvusInstantSpell
{
	public float speedBonus; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 681
	}

	public Trample() { }

	public virtual TowerBehaviorModel get_Def() { }

}

