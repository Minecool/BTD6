namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(LightningSplitOnContact), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LightningSplitOnContactModel : ProjectileBehaviorModel
{
	public int targets; //Field offset: 0x38
	public ProjectileModel projectileModel; //Field offset: 0x40
	public EmissionModel emissionModel; //Field offset: 0x48
	public float splitRange; //Field offset: 0x50
	[SerializeField]
	private float delay; //Field offset: 0x54
	public int delayFrames; //Field offset: 0x58

	public LightningSplitOnContactModel(string name, int targets, ProjectileModel projectileModel, EmissionModel emissionModel, float splitRange, float delay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

