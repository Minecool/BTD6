namespace Assets.Scripts.Models.Profile;

public class TowerSaveDataModel
{
	public string uniqueId; //Field offset: 0x10
	public long damageDealt; //Field offset: 0x18
	public long cashEarned; //Field offset: 0x20
	public float worth; //Field offset: 0x28
	public ObjectId IdLastSave; //Field offset: 0x2C
	public int createdAt; //Field offset: 0x30
	public TargetType targetType; //Field offset: 0x38
	public Vector3 position; //Field offset: 0x50
	public float rotation; //Field offset: 0x5C
	public string baseId; //Field offset: 0x60
	public string heroId; //Field offset: 0x68
	public float heroXpInCurrentLevel; //Field offset: 0x70
	public int pathOneTier; //Field offset: 0x74
	public int pathTwoTier; //Field offset: 0x78
	public int pathThreeTier; //Field offset: 0x7C
	public Dictionary<String, String> metaData; //Field offset: 0x80
	public int owner; //Field offset: 0x88
	public int originalOwner; //Field offset: 0x8C
	public int createdAtRoundTime; //Field offset: 0x90
	public ObjectId parentTowerId; //Field offset: 0x94
	public ObjectId areaPlacedOn; //Field offset: 0x98
	public bool isParagon; //Field offset: 0x9C
	public string geraldoTowerId; //Field offset: 0xA0
	public bool isSuspended; //Field offset: 0xA8
	public bool isSellingBlocked; //Field offset: 0xA9
	public bool isSelectionBlocked; //Field offset: 0xAA
	public string towerName; //Field offset: 0xB0
	public bool isNotUpgradeable; //Field offset: 0xB8
	public bool lockTargetTypeSwitching; //Field offset: 0xB9
	public int path1NumBlockedTiers; //Field offset: 0xBC
	public int path2NumBlockedTiers; //Field offset: 0xC0
	public int path3NumBlockedTiers; //Field offset: 0xC4
	public string powerId; //Field offset: 0xC8
	public int customMapTowerIndexId; //Field offset: 0xD0
	public bool isSuspendedButNotScaled; //Field offset: 0xD4

	public TowerSaveDataModel() { }

}

