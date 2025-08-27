namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class MapBorderRebound : ProjectileBehavior
{
	public MapBorderRebound parent; //Field offset: 0x88
	public bool changeRotation; //Field offset: 0x90
	public string expChangeRotation; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 139
	}

	public MapBorderRebound() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

