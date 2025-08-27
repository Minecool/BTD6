namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "GeraldoChangeTowerBehavior", menuName = "BTD6/Behaviors/Towers/GeraldoItems/GeraldoChangeTowerBehavior")]
public class GeraldoChangeTowerBehavior : GeraldoItemBehavior
{
	public string targetTowerBaseId; //Field offset: 0x28
	public int path1TierMax; //Field offset: 0x30
	public int path2TierMax; //Field offset: 0x34
	public int path3TierMax; //Field offset: 0x38
	public string resultingTowerName; //Field offset: 0x40
	public PrefabReference effectAtTower; //Field offset: 0x48
	public string upgradedTowerName; //Field offset: 0x50
	public int upgradedTowerUnlockedAt; //Field offset: 0x58
	public int resultingPath1TierMax; //Field offset: 0x5C
	public int resultingPath2TierMax; //Field offset: 0x60
	public int resultingPath3TierMax; //Field offset: 0x64
	public string upgradeBlockId; //Field offset: 0x68

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 299
	}

	public GeraldoChangeTowerBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

