namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ChurchillBaseRotation", menuName = "BTD6/Behaviors/Towers/ChurchillBaseRotation")]
public class ChurchillBaseRotation : TowerBehavior
{
	public float rotationSpeed; //Field offset: 0x30
	public int animationClockwise; //Field offset: 0x34
	public int animationAntiClockwise; //Field offset: 0x38
	public int animationNotMoving; //Field offset: 0x3C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 164
	}

	public ChurchillBaseRotation() { }

	public virtual TowerBehaviorModel get_Def() { }

}

