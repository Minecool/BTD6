namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(SharpeningStoneBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SharpeningStoneBehaviorModel : GeraldoItemBehaviorModel
{
	internal class SharpeningStoneMutator : BehaviorMutator
	{
		private readonly SharpeningStoneBehaviorModel sharpeningStoneBehaviorModel; //Field offset: 0x70
		private readonly float pierceIncrease; //Field offset: 0x78

		public SharpeningStoneMutator(SharpeningStoneBehaviorModel sharpeningStoneBehaviorModel, float pierceIncrease, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "SharpeningStone"; //Field offset: 0x0
	public const string greaterMutatorId = "SharpeningStoneGreater"; //Field offset: 0x0
	public float pierceIncrease; //Field offset: 0x30
	public PrefabReference buffDisplayPath; //Field offset: 0x38
	public string buffLocsName; //Field offset: 0x40
	public string buffIconName; //Field offset: 0x48
	private DisplayModel buffDisplayModel; //Field offset: 0x50
	public BloonProperties sharpProperty; //Field offset: 0x58
	public PrefabReference effectAtTowerId; //Field offset: 0x60
	public float bonusPierceAtLevel; //Field offset: 0x68
	public float bonusPierce; //Field offset: 0x6C
	public int rounds; //Field offset: 0x70
	private SharpeningStoneMutator mutator; //Field offset: 0x78
	private SharpeningStoneMutator mutatorGreater; //Field offset: 0x80

	public SharpeningStoneMutator Mutator
	{
		 get { } //Length: 126
	}

	public SharpeningStoneMutator MutatorGreater
	{
		 get { } //Length: 147
	}

	public SharpeningStoneBehaviorModel(string name, float pierceIncrease, PrefabReference buffDisplayPath, string buffLocsName, string buffIconName, PrefabReference effectAtTowerId, float bonusPierceAtLevel, float bonusPierce, int rounds) { }

	public virtual Model Clone() { }

	public SharpeningStoneMutator get_Mutator() { }

	public SharpeningStoneMutator get_MutatorGreater() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public bool IsTowerModelValid(TowerModel towerModel) { }

}

