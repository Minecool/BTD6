namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SpiritOfTheForest : TowerBehavior
{
	public SpiritOfTheForest parent; //Field offset: 0x98
	public GameObject objectToPlace1Far; //Field offset: 0xA0
	public GameObject expObjectToPlace1Far; //Field offset: 0xA8
	public GameObject objectToPlace2Far; //Field offset: 0xB0
	public GameObject expObjectToPlace2Far; //Field offset: 0xB8
	public GameObject objectToPlace3Far; //Field offset: 0xC0
	public GameObject expObjectToPlace3Far; //Field offset: 0xC8
	public GameObject objectToPlace4Far; //Field offset: 0xD0
	public GameObject expObjectToPlace4Far; //Field offset: 0xD8
	public GameObject objectToPlace1Middle; //Field offset: 0xE0
	public GameObject expObjectToPlace1Middle; //Field offset: 0xE8
	public GameObject objectToPlace2Middle; //Field offset: 0xF0
	public GameObject expObjectToPlace2Middle; //Field offset: 0xF8
	public GameObject objectToPlace3Middle; //Field offset: 0x100
	public GameObject expObjectToPlace3Middle; //Field offset: 0x108
	public GameObject objectToPlace4Middle; //Field offset: 0x110
	public GameObject expObjectToPlace4Middle; //Field offset: 0x118
	public GameObject objectToPlace1Close; //Field offset: 0x120
	public GameObject expObjectToPlace1Close; //Field offset: 0x128
	public GameObject objectToPlace2Close; //Field offset: 0x130
	public GameObject expObjectToPlace2Close; //Field offset: 0x138
	public GameObject objectToPlace3Close; //Field offset: 0x140
	public GameObject expObjectToPlace3Close; //Field offset: 0x148
	public GameObject objectToPlace4Close; //Field offset: 0x150
	public GameObject expObjectToPlace4Close; //Field offset: 0x158
	public DamageOverTimeZone damageOverTimeZoneFar; //Field offset: 0x160
	public DamageOverTimeZone expDamageOverTimeZoneFar; //Field offset: 0x168
	public DamageOverTimeZone damageOverTimeZoneMiddle; //Field offset: 0x170
	public DamageOverTimeZone expDamageOverTimeZoneMiddle; //Field offset: 0x178
	public DamageOverTimeZone damageOverTimeZoneClose; //Field offset: 0x180
	public DamageOverTimeZone expDamageOverTimeZoneClose; //Field offset: 0x188
	public float middleRange; //Field offset: 0x190
	public string expMiddleRange; //Field offset: 0x198
	public float closeRange; //Field offset: 0x1A0
	public string expCloseRange; //Field offset: 0x1A8
	public float spacingMin; //Field offset: 0x1B0
	public string expSpacingMin; //Field offset: 0x1B8
	public float spacingMax; //Field offset: 0x1C0
	public string expSpacingMax; //Field offset: 0x1C8
	public float scaleMin; //Field offset: 0x1D0
	public string expScaleMin; //Field offset: 0x1D8
	public float scaleMax; //Field offset: 0x1E0
	public string expScaleMax; //Field offset: 0x1E8
	public float rotationMin; //Field offset: 0x1F0
	public string expRotationMin; //Field offset: 0x1F8
	public float rotationMax; //Field offset: 0x200
	public string expRotationMax; //Field offset: 0x208
	public float offsetMin; //Field offset: 0x210
	public string expOffsetMin; //Field offset: 0x218
	public float offsetMax; //Field offset: 0x220
	public string expOffsetMax; //Field offset: 0x228
	public float circleRadius; //Field offset: 0x230
	public string expCircleRadius; //Field offset: 0x238
	public float generateRadius; //Field offset: 0x240
	public string expGenerateRadius; //Field offset: 0x248
	public float time; //Field offset: 0x250
	public string expTime; //Field offset: 0x258
	public float minScale; //Field offset: 0x260
	public string expMinScale; //Field offset: 0x268
	public float maxScale; //Field offset: 0x270
	public string expMaxScale; //Field offset: 0x278
	public float scaleTime; //Field offset: 0x280
	public string expScaleTime; //Field offset: 0x288

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1507
	}

	public SpiritOfTheForest() { }

	public virtual TowerBehaviorModel get_Def() { }

}

