namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PathMovementFromScreenCenter : TowerBehavior
{
	public PathMovementFromScreenCenter parent; //Field offset: 0x98
	public float speed; //Field offset: 0xA0
	public string expSpeed; //Field offset: 0xA8
	public bool ignoreTargetType; //Field offset: 0xB0
	public string expIgnoreTargetType; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public PathMovementFromScreenCenter() { }

	public virtual TowerBehaviorModel get_Def() { }

}

