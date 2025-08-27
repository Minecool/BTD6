namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SyncTargetPriorityWithSubTowers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SyncTargetPriorityWithSubTowersModel : TowerBehaviorModel
{
	public bool isSelectable; //Field offset: 0x30
	public bool targetTypeMustExist; //Field offset: 0x31
	public string ignoreTowersList; //Field offset: 0x38
	public String[] ignoreTowers; //Field offset: 0x40
	public string placeOnlyForTowersList; //Field offset: 0x48
	public String[] placeOnlyForTowers; //Field offset: 0x50

	public SyncTargetPriorityWithSubTowersModel(string name, bool targetTypeMustExist, string ignoreTowersList, string placeOnlyForTowersList) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

