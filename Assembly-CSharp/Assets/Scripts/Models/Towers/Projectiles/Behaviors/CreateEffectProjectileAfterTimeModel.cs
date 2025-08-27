namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateEffectProjectileAfterTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectProjectileAfterTimeModel : ProjectileBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x38
	[SerializeField]
	private float time; //Field offset: 0x40
	public int timeFrames; //Field offset: 0x44
	public bool repeat; //Field offset: 0x48
	public bool isBuffedByRate; //Field offset: 0x49
	public bool useTargetPosition; //Field offset: 0x4A

	public CreateEffectProjectileAfterTimeModel(string name, EffectModel effectModel, float time, bool repeat, bool isBuffedByRate, bool useTargetPosition) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

