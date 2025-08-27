namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells.Instant;

[CreateAssetMenu(fileName = "Ember", menuName = "BTD6/Behaviors/Towers/CorvusSpells/Instant/Ember")]
public class Ember : CorvusInstantSpell
{
	public Attack attack; //Field offset: 0x88

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 732
	}

	public Ember() { }

	public virtual TowerBehaviorModel get_Def() { }

}

