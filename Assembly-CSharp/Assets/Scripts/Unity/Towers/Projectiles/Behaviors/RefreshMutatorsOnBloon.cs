namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RefreshMutatorsOnBloon : ProjectileBehavior
{
	public RefreshMutatorsOnBloon parent; //Field offset: 0x88
	public string mutatorId; //Field offset: 0x90
	public string expMutatorId; //Field offset: 0x98
	public string mutatorKey; //Field offset: 0xA0
	public string expMutatorKey; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 134
	}

	public RefreshMutatorsOnBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

