namespace Assets.Scripts.Models.Behaviors;

[Implementation(typeof(TransformBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TransformModel : Model
{
	public Vector3 position; //Field offset: 0x30
	public float rotation; //Field offset: 0x3C

	public TransformModel(string name, Vector3 position, float rotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

