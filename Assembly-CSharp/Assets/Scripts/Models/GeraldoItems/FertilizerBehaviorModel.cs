namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(FertilizerBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FertilizerBehaviorModel : GeraldoItemBehaviorModel
{
	internal class FertilizerMutator : BehaviorMutator
	{
		private readonly FertilizerBehaviorModel fertilizerBehaviorModel; //Field offset: 0x70

		public FertilizerMutator(FertilizerBehaviorModel fertilizerBehaviorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "Fertilizer"; //Field offset: 0x0
	public float cashScale; //Field offset: 0x30
	public float cashIncrement; //Field offset: 0x34
	public int rounds; //Field offset: 0x38
	public int path1TierLimit; //Field offset: 0x3C
	public int path2TierLimit; //Field offset: 0x40
	public int path3TierLimit; //Field offset: 0x44
	public PrefabReference buffDisplayPath; //Field offset: 0x48
	public string buffLocsName; //Field offset: 0x50
	public string buffIconName; //Field offset: 0x58
	private DisplayModel buffDisplayModel; //Field offset: 0x60
	public PrefabReference effectAtTowerId; //Field offset: 0x68
	private FertilizerMutator mutator; //Field offset: 0x70

	public FertilizerMutator Mutator
	{
		 get { } //Length: 271
	}

	public FertilizerBehaviorModel(string name, float cashScale, float cashIncrement, int rounds, int path1TierLimit, int path2TierLimit, int path3TierLimit, PrefabReference buffDisplayPath, string buffLocsName, string buffIconName, PrefabReference effectAtTowerId) { }

	public virtual Model Clone() { }

	public FertilizerMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public bool IsTowerModelValid(TowerModel towerModel) { }

}

