namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(BottleHotSauceBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BottleHotSauceBehaviorModel : GeraldoItemBehaviorModel
{
	internal class BottleHotSauceMutator : BehaviorMutator
	{
		private readonly BottleHotSauceBehaviorModel bottleHotSauceBehaviorModel; //Field offset: 0x70

		public BottleHotSauceMutator(BottleHotSauceBehaviorModel bottleHotSauceBehaviorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "BottleHotSauce"; //Field offset: 0x0
	public string towerId; //Field offset: 0x30
	public PrefabReference buffDisplayPath; //Field offset: 0x38
	public string buffLocsName; //Field offset: 0x40
	public string buffIconName; //Field offset: 0x48
	public PrefabReference effectAtTowerId; //Field offset: 0x50
	private DisplayModel buffDisplayModel; //Field offset: 0x58
	public int v2At; //Field offset: 0x60
	private BottleHotSauceMutator mutator; //Field offset: 0x68

	public BottleHotSauceMutator Mutator
	{
		 get { } //Length: 275
	}

	public BottleHotSauceBehaviorModel(string name, PrefabReference buffDisplayPath, string buffLocsName, string buffIconName, PrefabReference effectAtTowerId, int v2At) { }

	public virtual Model Clone() { }

	public BottleHotSauceMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public bool IsTowerModelValid(TowerModel towerModel) { }

}

