namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Nourishment", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Nourishment")]
public class Nourishment : CorvusInstantSpell
{
	public float xpPerMana; //Field offset: 0x88
	public float cashPerManaAtMaxLevel; //Field offset: 0x8C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 662
	}

	public Nourishment() { }

	public virtual TowerBehaviorModel get_Def() { }

}

