namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MonkeyBanker), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeyBankerModel : TowerBehaviorBuffModel
{
	internal class BankIncomeMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70
		private readonly MonkeyBankerModel parent; //Field offset: 0x78

		public BankIncomeMutator(string mutatorId, float multiplier, int maxStacks, BuffIndicatorModel buffIndicatorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorIdStacking = "BankIncomeMutatorStacking"; //Field offset: 0x0
	public const string mutatorIdBase = "BankIncomeMutatorBase"; //Field offset: 0x0
	public float bankIncomeMultiplierBase; //Field offset: 0x48
	public float bankIncomeMultiplierPerStack; //Field offset: 0x4C
	public int bankIncomeMaxStacks; //Field offset: 0x50
	public bool isBananaFinancier; //Field offset: 0x54
	public float bankInstaDepositAmount; //Field offset: 0x58
	public float bankInstaDepositStackAmount; //Field offset: 0x5C
	public float bankInstaDepositMaxStackAmount; //Field offset: 0x60
	public int bankCollectAnimation; //Field offset: 0x64
	public BuffIndicatorModel buffIndicatorModel; //Field offset: 0x68
	private BankIncomeMutator mutatorStacking; //Field offset: 0x70
	private BankIncomeMutator mutatorBase; //Field offset: 0x78

	public BankIncomeMutator MutatorBase
	{
		 get { } //Length: 258
	}

	public BankIncomeMutator MutatorStacking
	{
		 get { } //Length: 173
	}

	public MonkeyBankerModel(string name, float bankIncomeMultiplierBase, float bankIncomeMultiplierPerStack, int bankIncomeMaxStacks, bool isBananaFinancier, string buffLocsName, float bankInstaDepositAmount, float bankInstaDepositStackAmount, float bankInstaDepositMaxStackAmount, int bankCollectAnimation) { }

	public virtual Model Clone() { }

	public BankIncomeMutator get_MutatorBase() { }

	public BankIncomeMutator get_MutatorStacking() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

