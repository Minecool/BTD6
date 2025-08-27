namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(IgnoreCollisionAfterCollide), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IgnoreCollisionAfterCollideModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float timeAfterCollide; //Field offset: 0x38
	public float timeAfterCollideFrames; //Field offset: 0x3C

	public IgnoreCollisionAfterCollideModel(string name, float timeAfterCollide) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

