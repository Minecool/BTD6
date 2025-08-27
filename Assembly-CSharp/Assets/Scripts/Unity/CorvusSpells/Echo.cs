namespace Assets.Scripts.Unity.CorvusSpells;

public class Echo : CorvusInstantSpell
{
	private EchoModel def; //Field offset: 0x158
	public Tower duplicateSpiritTower; //Field offset: 0x160

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 732
	}

	public Echo() { }

	public virtual TowerBehaviorModel get_Def() { }

}

