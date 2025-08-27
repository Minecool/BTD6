namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(GeraldoChangeTowerBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GeraldoChangeTowerBehaviorModel : GeraldoItemBehaviorModel
{
	internal class UpgradeBlockerMutator : BehaviorMutator
	{
		private readonly int resultingPath1TierMax; //Field offset: 0x70
		private readonly int resultingPath2TierMax; //Field offset: 0x74
		private readonly int resultingPath3TierMax; //Field offset: 0x78
		private readonly string upgradeBlockId; //Field offset: 0x80

		public UpgradeBlockerMutator(string mutatorId, int resultingPath1TierMax, int resultingPath2TierMax, int resultingPath3TierMax, string upgradeBlockId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string upgradeBlockerMutatorId = "GeraldoUpgradeBlocker"; //Field offset: 0x0
	public string targetTowerBaseId; //Field offset: 0x30
	public int path1TierMax; //Field offset: 0x38
	public int path2TierMax; //Field offset: 0x3C
	public int path3TierMax; //Field offset: 0x40
	public string resultingTowerName; //Field offset: 0x48
	public PrefabReference effectAtTowerId; //Field offset: 0x50
	public string upgradedTowerName; //Field offset: 0x58
	public int upgradedTowerUnlockedAt; //Field offset: 0x60
	[SerializeField]
	private int resultingPath1TierMax; //Field offset: 0x64
	[SerializeField]
	private int resultingPath2TierMax; //Field offset: 0x68
	[SerializeField]
	private int resultingPath3TierMax; //Field offset: 0x6C
	[SerializeField]
	private string upgradeBlockId; //Field offset: 0x70
	private UpgradeBlockerMutator mutator; //Field offset: 0x78

	public UpgradeBlockerMutator Mutator
	{
		 get { } //Length: 317
	}

	public GeraldoChangeTowerBehaviorModel(string name, string targetTowerBaseId, int path1TierMax, int path2TierMax, int path3TierMax, string resultingTowerName, PrefabReference effectAtTowerId, string upgradedTowerName, int upgradedTowerUnlockedAt, int resultingPath1TierMax, int resultingPath2TierMax, int resultingPath3TierMax, string upgradeBlockId) { }

	public virtual Model Clone() { }

	public UpgradeBlockerMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

