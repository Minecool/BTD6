namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class EndOfRoundClearBypass : ProjectileBehavior
{
	public EndOfRoundClearBypass parent; //Field offset: 0x88
	public string gameModes; //Field offset: 0x90
	public string expGameModes; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 108
	}

	public EndOfRoundClearBypass() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

