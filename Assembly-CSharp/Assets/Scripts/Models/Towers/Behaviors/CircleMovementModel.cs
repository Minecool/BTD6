namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CircleMovement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CircleMovementModel : TowerBehaviorModel
{
	public float radius; //Field offset: 0x30
	public float speed; //Field offset: 0x34

	public CircleMovementModel(string name, float radius, float speed) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

