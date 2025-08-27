namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RetargetOnContact), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RetargetOnContactModel : ProjectileBehaviorModel
{
	public float distance; //Field offset: 0x38
	public float minDistance; //Field offset: 0x3C
	public int maxBounces; //Field offset: 0x40
	[SerializeField]
	private float delay; //Field offset: 0x44
	public int delayFrames; //Field offset: 0x48
	public TargetType targetType; //Field offset: 0x50
	public bool expireIfNoTargetFound; //Field offset: 0x68

	public RetargetOnContactModel(string name, float distance, float minDistance, int maxBounces, string targetType, float delay, bool expireIfNoTargetFound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

