namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Continuous;

[CreateAssetMenu(fileName = "Storm", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Continuous/Storm")]
public class Storm : CorvusContinuousSpell
{
	public Attack attack; //Field offset: 0x88

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 715
	}

	public Storm() { }

	public virtual TowerBehaviorModel get_Def() { }

}

