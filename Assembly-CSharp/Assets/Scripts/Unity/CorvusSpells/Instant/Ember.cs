namespace Assets.Scripts.Unity.CorvusSpells.Instant;

public class Ember : CorvusInstantSpell
{
	private EmberModel def; //Field offset: 0x158
	public Attack attack; //Field offset: 0x160

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 811
	}

	public Ember() { }

	public virtual TowerBehaviorModel get_Def() { }

}

