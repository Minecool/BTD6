namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(LineProjectileEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LineProjectileEmissionModel : EmissionModel
{
	public bool useTargetAsEndPoint; //Field offset: 0x38
	public AssetPathModel displayPath; //Field offset: 0x40
	public float displayLength; //Field offset: 0x48
	public float displayLifetime; //Field offset: 0x4C
	public bool ignoreBlockers; //Field offset: 0x50
	public EffectModel effectAtEndModel; //Field offset: 0x58
	public EffectModel effectAtStartModel; //Field offset: 0x60
	[SerializeField]
	private float effectAtEndRate; //Field offset: 0x68
	public int effectAtEndRateFrames; //Field offset: 0x6C
	public bool dontUseTowerPosition; //Field offset: 0x70
	public bool useTowerRotation; //Field offset: 0x71
	public bool useLengthSpeed; //Field offset: 0x72
	public float lengthSpeed; //Field offset: 0x74
	public float lengthPerFrame; //Field offset: 0x78
	public ProjectileModel projectileInitialHitModel; //Field offset: 0x80
	public ProjectileModel projectileAtEndModel; //Field offset: 0x88
	public EmissionModel emissionAtEndModel; //Field offset: 0x90
	public bool endProjectileSharesPierce; //Field offset: 0x98
	public EffectModel effectAtCollision; //Field offset: 0xA0
	public int maxCollisionEffects; //Field offset: 0xA8
	public bool emitFromTarget; //Field offset: 0xAC
	public float emitFromTargetLength; //Field offset: 0xB0

	public LineProjectileEmissionModel(string name, bool useTargetAsEndPoint, EmissionBehaviorModel[] behaviors, AssetPathModel displayPath, float displayLength, float displayLifetime, bool ignoreBlockers, EffectModel effectAtEndModel, EffectModel effectAtStartModel, float effectAtEndRate, bool dontUseTowerPosition, bool useTowerRotation, bool useLengthSpeed, float lengthSpeed, ProjectileModel projectileInitialHitModel, ProjectileModel projectileAtEndModel, EmissionModel emissionAtEndModel, bool endProjectileSharesPierce, EffectModel effectAtCollision, int maxCollisionEffects, bool emitFromTarget, float emitFromTargetLength) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

