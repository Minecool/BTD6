namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SilasIceFragments), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SilasIceFragmentsModel : TowerBehaviorModel
{
	public ProjectileModel iceFragmentProjectileModel; //Field offset: 0x30
	public int iceFragmentLevel; //Field offset: 0x38
	[Header("Inner")]
	public float innerOrbitRotationTime; //Field offset: 0x3C
	public float innerOrbitDistance; //Field offset: 0x40
	public int maxInnerOrbitShards; //Field offset: 0x44
	public bool isInnerOrbitCounterClockwise; //Field offset: 0x48
	public int innerOrbitMinimumTowerTier; //Field offset: 0x4C
	[Header("Middle")]
	public float middleOrbitRotationTime; //Field offset: 0x50
	public float middleOrbitDistance; //Field offset: 0x54
	public int maxMiddleOrbitShards; //Field offset: 0x58
	public bool isMiddleOrbitCounterClockwise; //Field offset: 0x5C
	public int middleOrbitMinimumTowerTier; //Field offset: 0x60
	[Header("Outer")]
	public float outerOrbitRotationTime; //Field offset: 0x64
	public float outerOrbitDistance; //Field offset: 0x68
	public int maxOuterOrbitShards; //Field offset: 0x6C
	public bool isOuterOrbitCounterClockwise; //Field offset: 0x70
	public int outerOrbitMinimumTowerTier; //Field offset: 0x74

	public SilasIceFragmentsModel(string name, ProjectileModel iceFragmentProjectileModel, int iceFragmentLevel, float innerOrbitRotationTime, float innerOrbitDistance, int maxInnerOrbitShards, bool isInnerOrbitCounterClockwise, int innerOrbitMinimumTowerTier, float middleOrbitRotationTime, float middleOrbitDistance, int maxMiddleOrbitShards, bool isMiddleOrbitCounterClockwise, int middleOrbitMinimumTowerTier, float outerOrbitRotationTime, float outerOrbitDistance, int maxOuterOrbitShards, bool isOuterOrbitCounterClockwise, int outerOrbitMinimumTowerTier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

