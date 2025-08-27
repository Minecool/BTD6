namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SpiritOfTheForest", menuName = "BTD6/Behaviors/Towers/SpiritOfTheForest")]
public class SpiritOfTheForest : TowerBehavior
{
	public PrefabReference objectToPlace1Far; //Field offset: 0x30
	public PrefabReference objectToPlace2Far; //Field offset: 0x38
	public PrefabReference objectToPlace3Far; //Field offset: 0x40
	public PrefabReference objectToPlace4Far; //Field offset: 0x48
	public PrefabReference objectToPlace1Middle; //Field offset: 0x50
	public PrefabReference objectToPlace2Middle; //Field offset: 0x58
	public PrefabReference objectToPlace3Middle; //Field offset: 0x60
	public PrefabReference objectToPlace4Middle; //Field offset: 0x68
	public PrefabReference objectToPlace1Close; //Field offset: 0x70
	public PrefabReference objectToPlace2Close; //Field offset: 0x78
	public PrefabReference objectToPlace3Close; //Field offset: 0x80
	public PrefabReference objectToPlace4Close; //Field offset: 0x88
	public DamageOverTimeZone damageOverTimeZoneFar; //Field offset: 0x90
	public DamageOverTimeZone damageOverTimeZoneMiddle; //Field offset: 0x98
	public DamageOverTimeZone damageOverTimeZoneClose; //Field offset: 0xA0
	public float middleRange; //Field offset: 0xA8
	public float closeRange; //Field offset: 0xAC
	public float spacingMin; //Field offset: 0xB0
	public float spacingMax; //Field offset: 0xB4
	public float scaleMin; //Field offset: 0xB8
	public float scaleMax; //Field offset: 0xBC
	public float rotationMin; //Field offset: 0xC0
	public float rotationMax; //Field offset: 0xC4
	public float offsetMin; //Field offset: 0xC8
	public float offsetMax; //Field offset: 0xCC
	public float circleRadius; //Field offset: 0xD0
	public float generateRadius; //Field offset: 0xD4
	public float time; //Field offset: 0xD8
	public float minScale; //Field offset: 0xDC
	public float maxScale; //Field offset: 0xE0
	public float scaleTime; //Field offset: 0xE4

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1312
	}

	public SpiritOfTheForest() { }

	public virtual TowerBehaviorModel get_Def() { }

}

