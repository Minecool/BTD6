namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Rotate), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RotateModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float angle; //Field offset: 0x38
	public float rotationFrames; //Field offset: 0x3C

	public RotateModel(string name, float angle) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

