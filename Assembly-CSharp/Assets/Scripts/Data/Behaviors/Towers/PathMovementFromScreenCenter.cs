namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PathMovementFromScreenCenter", menuName = "BTD6/Behaviors/Towers/PathMovementFromScreenCenter")]
public class PathMovementFromScreenCenter : TowerBehavior
{
	public float speed; //Field offset: 0x30
	public bool ignoreTargetType; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public PathMovementFromScreenCenter() { }

	public virtual TowerBehaviorModel get_Def() { }

}

