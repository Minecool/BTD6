namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventMapBonusSaveData
{
	internal class BonusInfo
	{
		public string difficulty; //Field offset: 0x10
		public string trackName; //Field offset: 0x18
		public DateTime expiresAt; //Field offset: 0x20
		public bool completed; //Field offset: 0x28

		public BonusInfo() { }

	}

	public Dictionary<String, BonusInfo> bonusesByDifficulty; //Field offset: 0x10

	public CollectionEventMapBonusSaveData() { }

}

