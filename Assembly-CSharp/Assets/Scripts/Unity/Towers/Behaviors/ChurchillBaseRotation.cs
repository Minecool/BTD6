namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ChurchillBaseRotation : TowerBehavior
{
	public ChurchillBaseRotation parent; //Field offset: 0x98
	public float rotationSpeed; //Field offset: 0xA0
	public string expRotationSpeed; //Field offset: 0xA8
	public int animationClockwise; //Field offset: 0xB0
	public string expAnimationMovingClockwise; //Field offset: 0xB8
	public int animationAntiClockwise; //Field offset: 0xC0
	public string expAnimationMovingAntiClockwise; //Field offset: 0xC8
	public int animationNotMoving; //Field offset: 0xD0
	public string expAnimationStateNotMoving; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 176
	}

	public ChurchillBaseRotation() { }

	public virtual TowerBehaviorModel get_Def() { }

}

