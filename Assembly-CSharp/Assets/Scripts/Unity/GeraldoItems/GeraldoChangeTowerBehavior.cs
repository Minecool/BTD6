namespace Assets.Scripts.Unity.GeraldoItems;

public class GeraldoChangeTowerBehavior : GeraldoItemBehavior
{
	[SerializeField]
	private string targetTowerBaseId; //Field offset: 0x10
	[SerializeField]
	private int path1TierMax; //Field offset: 0x18
	[SerializeField]
	private int path2TierMax; //Field offset: 0x1C
	[SerializeField]
	private int path3TierMax; //Field offset: 0x20
	[SerializeField]
	private string resultingTowerName; //Field offset: 0x28
	[SerializeField]
	private PrefabReference effectAtTower; //Field offset: 0x30
	[SerializeField]
	private string upgradedTowerName; //Field offset: 0x38
	[SerializeField]
	private int upgradedTowerUnlockedAt; //Field offset: 0x40
	[SerializeField]
	private int resultingPath1TierMax; //Field offset: 0x44
	[SerializeField]
	private int resultingPath2TierMax; //Field offset: 0x48
	[SerializeField]
	private int resultingPath3TierMax; //Field offset: 0x4C
	[SerializeField]
	private string upgradeBlockId; //Field offset: 0x50

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 299
	}

	public GeraldoChangeTowerBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

