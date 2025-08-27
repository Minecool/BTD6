namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Continuous;

[CreateAssetMenu(fileName = "Spear", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Continuous/Spear")]
public class Spear : CorvusContinuousSpell
{
	public Attack attack; //Field offset: 0x88

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 715
	}

	public Spear() { }

	public virtual TowerBehaviorModel get_Def() { }

}

