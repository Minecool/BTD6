namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "FigureEightMovement", menuName = "BTD6/Behaviors/Towers/FigureEightMovement")]
public class FigureEightMovement : TowerBehavior
{
	public float radius; //Field offset: 0x30
	public float speed; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public FigureEightMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

