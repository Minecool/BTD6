namespace Assets.Scripts.Models.Behaviors;

[Implementation(typeof(GreatWhiteEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GreatWhiteEffectModel : Model
{
	public DisplayModel displayModel; //Field offset: 0x30
	public DisplayModel bloonDestroyedDisplayModel; //Field offset: 0x38
	public EffectModel retreatEffectModel; //Field offset: 0x40
	public float bloonPopTimeScale; //Field offset: 0x48
	public float postDragTime; //Field offset: 0x4C
	public int postDragTimeFrames; //Field offset: 0x50
	public DisplayModel bloonEffectDisplayModel; //Field offset: 0x58
	public int bitingAnimationState; //Field offset: 0x60
	public float exitAnimationTime; //Field offset: 0x64
	public int exitAnimationTimeFrames; //Field offset: 0x68
	public int exitAnimationState; //Field offset: 0x6C
	public float maxMoabGrabTime; //Field offset: 0x70
	public float maxMoabGrabTimeMegalodon; //Field offset: 0x74
	public int moabDamagePerSecond; //Field offset: 0x78
	public float maxMoabDamagePercentPerSecond; //Field offset: 0x7C
	public float playRetreatAnimationAt; //Field offset: 0x80
	public int playRetreatAnimationAtFrames; //Field offset: 0x84
	public int readyAnimationState; //Field offset: 0x88
	public ProjectileModel thrashingProjectileModel; //Field offset: 0x90
	public float thrashingProjectileRate; //Field offset: 0x98
	public int thrashingProjectileRateFrames; //Field offset: 0x9C
	public EffectModel thrashingEffectModel; //Field offset: 0xA0

	public GreatWhiteEffectModel(string name, DisplayModel displayModel, DisplayModel bloonDestroyedDisplayModel, EffectModel retreatEffectModel, float bloonPopTimeScale, float postDragTime, int bitingAnimationState, float exitAnimationTime, int exitAnimationState, float maxMoabGrabTime, float maxMoabGrabTimeMegalodon, int moabDamagePerSecond, float maxMoabDamagePercentPerSecond, float playRetreatAnimationAt, int readyAnimationState, ProjectileModel thrashingProjectileModel, float thrashingProjectileRate, EffectModel thrashingEffectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

