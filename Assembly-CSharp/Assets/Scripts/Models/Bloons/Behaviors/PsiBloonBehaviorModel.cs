namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(PsiBloonBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PsiBloonBehaviorModel : BloonBehaviorModelWithTowerTracking
{
	public string overlayType; //Field offset: 0x38
	public int damagePerTick; //Field offset: 0x40
	[SerializeField]
	private float tickRate; //Field offset: 0x44
	public int tickRateFrames; //Field offset: 0x48
	public AgeingDestroyModel displayAgeingDestroyModel; //Field offset: 0x50
	[SerializeField]
	private float trembleSpeed; //Field offset: 0x58
	public float trembleSpeedFrames; //Field offset: 0x5C
	public float trembleDistanceMin; //Field offset: 0x60
	public float trembleDistanceMax; //Field offset: 0x64
	public float trembleTimeThresholdMin; //Field offset: 0x68
	public int trembleFramesThresholdMin; //Field offset: 0x6C
	public float trembleTimeThresholdMax; //Field offset: 0x70
	public int trembleFramesThresholdMax; //Field offset: 0x74
	public ProjectileModel projectileOnBloonDestroyModel; //Field offset: 0x78
	public EmissionModel emissionModel; //Field offset: 0x80
	public EffectModel effectOnBloonDestroyModel; //Field offset: 0x88

	public PsiBloonBehaviorModel() { }

	public PsiBloonBehaviorModel(string name, string overlayType, int damagePerTick, float tickRate, ObjectId tower, float trembleSpeed, float trembleDistanceMin, float trembleDistanceMax, float trembleTimeThresholdMin, float trembleTimeThresholdMax, ProjectileModel projectileOnBloonDestroyModel, EmissionModel emissionModel, EffectModel effectOnBloonDestroyModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

