namespace Assets.Scripts.Models.Behaviors;

[Implementation(typeof(WrappedMovement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WrappedMovementModel : Model
{
	public Vector3 start; //Field offset: 0x30
	public Vector3 end; //Field offset: 0x3C
	public float speed; //Field offset: 0x48

	public WrappedMovementModel(string name, Vector3 start, Vector3 end) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

