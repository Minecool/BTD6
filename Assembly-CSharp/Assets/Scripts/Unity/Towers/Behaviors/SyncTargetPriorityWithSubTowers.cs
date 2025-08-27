namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SyncTargetPriorityWithSubTowers : TowerBehavior
{
	public SyncTargetPriorityWithSubTowers parent; //Field offset: 0x98
	public bool targetTypeMustExist; //Field offset: 0xA0
	public string expTargetTypeMustExist; //Field offset: 0xA8
	public string ignoreTowersList; //Field offset: 0xB0
	public string expIgnoreTowersList; //Field offset: 0xB8
	public string placeOnlyForTowersList; //Field offset: 0xC0
	public string expPlaceOnlyForTowersList; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 159
	}

	public SyncTargetPriorityWithSubTowers() { }

	public virtual TowerBehaviorModel get_Def() { }

}

