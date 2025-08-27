namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RetargetOnContactDelay), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RetargetOnContactDelayModel : ProjectileBehaviorModel
{
	public float distance; //Field offset: 0x38
	public int maxBounces; //Field offset: 0x3C
	public int delayFrames; //Field offset: 0x40
	public bool onlyIfFirstBloonDestroyed; //Field offset: 0x44
	public PrefabReference displayPath; //Field offset: 0x48
	public float displayLength; //Field offset: 0x50
	public float displayLifetime; //Field offset: 0x54
	public float displayLengthScale; //Field offset: 0x58

	public RetargetOnContactDelayModel(string name, float distance, int maxBounces, int delayFrames, bool onlyIfFirstBloonDestroyed, PrefabReference displayPath, float displayLength, float displayLifetime, float displayLengthScale) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

