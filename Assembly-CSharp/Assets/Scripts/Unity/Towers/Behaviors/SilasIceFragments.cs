namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SilasIceFragments : TowerBehavior
{
	public SilasIceFragments parent; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public int iceFragmentLevel; //Field offset: 0xB0
	public string expIceFragmentLevel; //Field offset: 0xB8
	[Header("Inner")]
	public float innerOrbitRotationTime; //Field offset: 0xC0
	public string expInnerOrbitRotationTime; //Field offset: 0xC8
	public float innerOrbitDistance; //Field offset: 0xD0
	public string expInnerOrbitDistance; //Field offset: 0xD8
	public int maxInnerOrbitShards; //Field offset: 0xE0
	public string expMaxInnerOrbitShards; //Field offset: 0xE8
	public bool isInnerOrbitCounterClockwise; //Field offset: 0xF0
	public string expIsInnerOrbitCounterClockwise; //Field offset: 0xF8
	public int innerOrbitMinimumTowerTier; //Field offset: 0x100
	public string expInnerOrbitMinimumTowerTier; //Field offset: 0x108
	[Header("Middle")]
	public float middleOrbitRotationTime; //Field offset: 0x110
	public string expMiddleOrbitRotationTime; //Field offset: 0x118
	public int maxMiddleOrbitShards; //Field offset: 0x120
	public string expMaxMiddleOrbitShards; //Field offset: 0x128
	public bool isMiddleOrbitCounterClockwise; //Field offset: 0x130
	public string expIsMiddleOrbitCounterClockwise; //Field offset: 0x138
	public float middleOrbitDistance; //Field offset: 0x140
	public string expMiddleOrbitDistance; //Field offset: 0x148
	public int middleOrbitMinimumTowerTier; //Field offset: 0x150
	public string expMiddleOrbitMinimumTowerTier; //Field offset: 0x158
	[Header("Outer")]
	public float outerOrbitRotationTime; //Field offset: 0x160
	public string expOuterOrbitRotationTime; //Field offset: 0x168
	public float outerOrbitDistance; //Field offset: 0x170
	public string expOuterOrbitDistance; //Field offset: 0x178
	public int maxOuterOrbitShards; //Field offset: 0x180
	public string expMaxOuterOrbitShards; //Field offset: 0x188
	public bool isOuterOrbitCounterClockwise; //Field offset: 0x190
	public string expIsOuterOrbitCounterClockwise; //Field offset: 0x198
	public int outerOrbitMinimumTowerTier; //Field offset: 0x1A0
	public string expOuterOrbitMinimumTowerTier; //Field offset: 0x1A8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 624
	}

	public SilasIceFragments() { }

	public virtual TowerBehaviorModel get_Def() { }

}

