namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Continuous;

[CreateAssetMenu(fileName = "Malevolence", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Continuous/Malevolence")]
public class Malevolence : CorvusContinuousSpell
{
	public Attack attack; //Field offset: 0x88
	public float absorptionDuration; //Field offset: 0x90

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 748
	}

	public Malevolence() { }

	public virtual TowerBehaviorModel get_Def() { }

}

