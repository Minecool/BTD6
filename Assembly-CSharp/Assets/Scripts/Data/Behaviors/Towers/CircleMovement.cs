namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CircleMovement", menuName = "BTD6/Behaviors/Towers/CircleMovement")]
public class CircleMovement : TowerBehavior
{
	public float radius; //Field offset: 0x30
	public float speed; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public CircleMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

