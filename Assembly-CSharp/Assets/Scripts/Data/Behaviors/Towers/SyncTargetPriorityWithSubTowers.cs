namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SyncTargetPriorityWithSubTowers", menuName = "BTD6/Behaviors/Towers/SyncTargetPriorityWithSubTowers")]
public class SyncTargetPriorityWithSubTowers : TowerBehavior
{
	public bool targetTypeMustExist; //Field offset: 0x30
	public string ignoreTowersList; //Field offset: 0x38
	public string placeOnlyForTowersList; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public SyncTargetPriorityWithSubTowers() { }

	public virtual TowerBehaviorModel get_Def() { }

}

