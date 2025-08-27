namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PlaceAlongTrack : TowerBehavior
{
	public PlaceAlongTrack parent; //Field offset: 0x98
	public GameObject objectToPlace1; //Field offset: 0xA0
	public GameObject expObjectToPlace1; //Field offset: 0xA8
	public GameObject objectToPlace2; //Field offset: 0xB0
	public GameObject expObjectToPlace2; //Field offset: 0xB8
	public GameObject objectToPlace3; //Field offset: 0xC0
	public GameObject expObjectToPlace3; //Field offset: 0xC8
	public GameObject objectToPlace4; //Field offset: 0xD0
	public GameObject expObjectToPlace4; //Field offset: 0xD8
	public float spacingMin; //Field offset: 0xE0
	public string expSpacingMin; //Field offset: 0xE8
	public float spacingMax; //Field offset: 0xF0
	public string expSpacingMax; //Field offset: 0xF8
	public float scaleMin; //Field offset: 0x100
	public string expScaleMin; //Field offset: 0x108
	public float scaleMax; //Field offset: 0x110
	public string expScaleMax; //Field offset: 0x118
	public float rotationMin; //Field offset: 0x120
	public string expRotationMin; //Field offset: 0x128
	public float rotationMax; //Field offset: 0x130
	public string expRotationMax; //Field offset: 0x138
	public float offsetMin; //Field offset: 0x140
	public string expOffsetMin; //Field offset: 0x148
	public float offsetMax; //Field offset: 0x150
	public string expOffsetMax; //Field offset: 0x158

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 459
	}

	public PlaceAlongTrack() { }

	public virtual TowerBehaviorModel get_Def() { }

}

