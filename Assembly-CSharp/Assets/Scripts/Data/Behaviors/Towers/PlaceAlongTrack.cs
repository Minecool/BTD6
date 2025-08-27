namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PlaceAlongTrack", menuName = "BTD6/Behaviors/Towers/PlaceAlongTrack")]
public class PlaceAlongTrack : TowerBehavior
{
	public PrefabReference objectToPlace1; //Field offset: 0x30
	public PrefabReference objectToPlace2; //Field offset: 0x38
	public PrefabReference objectToPlace3; //Field offset: 0x40
	public PrefabReference objectToPlace4; //Field offset: 0x48
	public float spacingMin; //Field offset: 0x50
	public float spacingMax; //Field offset: 0x54
	public float scaleMin; //Field offset: 0x58
	public float scaleMax; //Field offset: 0x5C
	public float rotationMin; //Field offset: 0x60
	public float rotationMax; //Field offset: 0x64
	public float offsetMin; //Field offset: 0x68
	public float offsetMax; //Field offset: 0x6C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 347
	}

	public PlaceAlongTrack() { }

	public virtual TowerBehaviorModel get_Def() { }

}

