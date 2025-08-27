namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Echo", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Echo")]
public class Echo : CorvusInstantSpell
{
	public Tower duplicateSpiritTower; //Field offset: 0x88

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 644
	}

	public Echo() { }

	public virtual TowerBehaviorModel get_Def() { }

}

