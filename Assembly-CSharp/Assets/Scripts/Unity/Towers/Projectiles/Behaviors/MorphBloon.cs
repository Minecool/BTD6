namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class MorphBloon : ProjectileBehavior
{
	public MorphBloon parent; //Field offset: 0x88
	public string bloonId; //Field offset: 0x90
	public string expBloonId; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 108
	}

	public MorphBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

