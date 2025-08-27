namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectilesAlongPathWhenClose), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectilesAlongPathWhenCloseModel : ProjectileBehaviorModel
{
	public float range; //Field offset: 0x38
	public int amountOfProjectilesPerPath; //Field offset: 0x3C
	public ProjectileModel projectile; //Field offset: 0x40
	public EmissionModel emission; //Field offset: 0x48
	public EffectModel emitProjectileEffectModel; //Field offset: 0x50
	public EffectModel projectileLandingEffectModel; //Field offset: 0x58
	[SerializeField]
	private float projectileLandingEffectDelay; //Field offset: 0x60
	public int projectileLandingEffectDelayFrames; //Field offset: 0x64
	[SerializeField]
	private float projectileCreationDelay; //Field offset: 0x68
	public int projectileCreationDelayFrames; //Field offset: 0x6C
	public int fireProjectileAnimationState; //Field offset: 0x70
	public SoundModel sound1; //Field offset: 0x78
	public SoundModel sound2; //Field offset: 0x80
	public SoundModel sound3; //Field offset: 0x88
	public SoundModel sound4; //Field offset: 0x90
	public SoundModel sound5; //Field offset: 0x98

	public CreateProjectilesAlongPathWhenCloseModel(string name, ProjectileModel projectile, EmissionModel emission, float range, int amountOfProjectilesPerPath, EffectModel emitProjectileEffectModel, EffectModel projectileLandingEffectModel, float projectileLandingEffectDelay, float projectileCreationDelay, int fireProjectileAnimationState, SoundModel sound1, SoundModel sound2, SoundModel sound3, SoundModel sound4, SoundModel sound5) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

