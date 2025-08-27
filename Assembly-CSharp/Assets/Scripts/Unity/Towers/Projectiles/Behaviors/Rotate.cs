namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Rotate : ProjectileBehavior
{
	public Rotate parent; //Field offset: 0x88
	public float angle; //Field offset: 0x90
	public string expAngle; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public Rotate() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

