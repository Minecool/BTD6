namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ChurchillBaseRotation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChurchillBaseRotationModel : TowerBehaviorModel
{
	public float rotationSpeed; //Field offset: 0x30
	public int animationMovingClockwise; //Field offset: 0x34
	public int animationMovingAntiClockwise; //Field offset: 0x38
	public int animationStateNotMoving; //Field offset: 0x3C

	public ChurchillBaseRotationModel(string name, float rotationSpeed, int animationMovingClockwise, int animationMovingAntiClockwise, int animationStateNotMoving) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

