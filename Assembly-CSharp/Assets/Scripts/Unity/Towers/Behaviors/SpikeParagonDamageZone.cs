namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SpikeParagonDamageZone : TowerBehavior
{
	public SpikeParagonDamageZone parent; //Field offset: 0x98
	public GameObject objectToPlace1; //Field offset: 0xA0
	public GameObject expObjectToPlace1; //Field offset: 0xA8
	public GameObject objectToPlace2; //Field offset: 0xB0
	public GameObject expObjectToPlace2; //Field offset: 0xB8
	public GameObject objectToPlace3; //Field offset: 0xC0
	public GameObject expObjectToPlace3; //Field offset: 0xC8
	public GameObject objectToPlace4; //Field offset: 0xD0
	public GameObject expObjectToPlace4; //Field offset: 0xD8
	public DamageOverTimeZone damageOverTimeZone; //Field offset: 0xE0
	public DamageOverTimeZone expDamageOverTimeZone; //Field offset: 0xE8
	public float spacingMin; //Field offset: 0xF0
	public string expSpacingMin; //Field offset: 0xF8
	public float spacingMax; //Field offset: 0x100
	public string expSpacingMax; //Field offset: 0x108
	public float scaleMin; //Field offset: 0x110
	public string expScaleMin; //Field offset: 0x118
	public float scaleMax; //Field offset: 0x120
	public string expScaleMax; //Field offset: 0x128
	public float rotationMin; //Field offset: 0x130
	public string expRotationMin; //Field offset: 0x138
	public float rotationMax; //Field offset: 0x140
	public string expRotationMax; //Field offset: 0x148
	public float offsetMin; //Field offset: 0x150
	public string expOffsetMin; //Field offset: 0x158
	public float offsetMax; //Field offset: 0x160
	public string expOffsetMax; //Field offset: 0x168
	public float circleRadius; //Field offset: 0x170
	public string expCircleRadius; //Field offset: 0x178
	public float generateRadius; //Field offset: 0x180
	public string expGenerateRadius; //Field offset: 0x188
	public float time; //Field offset: 0x190
	public string expTime; //Field offset: 0x198
	public float minScale; //Field offset: 0x1A0
	public string expMinScale; //Field offset: 0x1A8
	public float maxScale; //Field offset: 0x1B0
	public string expMaxScale; //Field offset: 0x1B8
	public float scaleTime; //Field offset: 0x1C0
	public string expScaleTime; //Field offset: 0x1C8
	public int minProjSpeed; //Field offset: 0x1D0
	public string expMinProjSpeed; //Field offset: 0x1D8
	public int maxProjSpeed; //Field offset: 0x1E0
	public string expMaxProjSpeed; //Field offset: 0x1E8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 910
	}

	public SpikeParagonDamageZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

