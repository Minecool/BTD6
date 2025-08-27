namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateGreatWhiteEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateGreatWhiteEffectModel : ProjectileBehaviorModel
{
	public PrefabReference display; //Field offset: 0x38
	public PrefabReference bloonDestroyedDisplay; //Field offset: 0x40
	public DisplayModel displayModel; //Field offset: 0x48
	public DisplayModel bloonDestroyedDisplayModel; //Field offset: 0x50
	public EffectModel retreatEffectModel; //Field offset: 0x58
	public float bloonPopTimeScale; //Field offset: 0x60
	public float postDragTime; //Field offset: 0x64
	public string maxGrabBloonName; //Field offset: 0x68
	public int bitingAnimationState; //Field offset: 0x70
	public float exitAnimationTime; //Field offset: 0x74
	public int exitAnimationState; //Field offset: 0x78
	public float maxMoabGrabTime; //Field offset: 0x7C
	public float maxMoabGrabTimeMegalodon; //Field offset: 0x80
	public int moabDamagePerSecond; //Field offset: 0x84
	public float maxMoabDamagePercentPerSecond; //Field offset: 0x88
	public float playRetreatAnimationAt; //Field offset: 0x8C
	public int readyAnimationState; //Field offset: 0x90
	public ProjectileModel thrashingProjectileModel; //Field offset: 0x98
	public ProjectileModel bloonFollowProjectileModel; //Field offset: 0xA0
	public float thrashingProjectileRate; //Field offset: 0xA8
	public EffectModel thrashingEffectModel; //Field offset: 0xB0
	public int noGrabAnimationState; //Field offset: 0xB8
	public SingleEmissionModel emissionModel; //Field offset: 0xC0
	public EffectModel noGrabEffectModel; //Field offset: 0xC8
	public int maxPullRbe; //Field offset: 0xD0

	public CreateGreatWhiteEffectModel(string name, PrefabReference display, PrefabReference bloonDestroyedDisplay, EffectModel retreatEffectModel, float bloonPopTimeScale, float postDragTime, string maxGrabBloonName, int bitingAnimationState, float exitAnimationTime, int exitAnimationState, float maxMoabGrabTime, float maxMoabGrabTimeMegalodon, int moabDamagePerSecond, float maxMoabDamagePercentPerSecond, float playRetreatAnimationAt, int readyAnimationState, ProjectileModel thrashingProjectileModel, ProjectileModel bloonFollowProjectileModel, float thrashingProjectileRate, EffectModel thrashingEffectModel, int noGrabAnimationState, EffectModel noGrabEffectModel, int maxPullRbe) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

