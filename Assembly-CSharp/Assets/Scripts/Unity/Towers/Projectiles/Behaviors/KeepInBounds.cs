namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class KeepInBounds : ProjectileBehavior
{
	public KeepInBounds parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public KeepInBounds() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

