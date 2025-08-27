namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(SeeInvisibilityPotionBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SeeInvisibilityPotionBehaviorModel : GeraldoItemBehaviorModel
{
	internal class SeeInvisibilityPotionEffectMutator : BehaviorMutator
	{
		private readonly SeeInvisibilityPotionBehaviorModel seeInvisibilityPotionModel; //Field offset: 0x70

		public SeeInvisibilityPotionEffectMutator(SeeInvisibilityPotionBehaviorModel seeInvisibilityPotionModel, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class SeeInvisibilityPotionMutator : BehaviorMutator
	{
		private readonly SeeInvisibilityPotionBehaviorModel seeInvisibilityPotionModel; //Field offset: 0x70
		public readonly int version; //Field offset: 0x78

		public SeeInvisibilityPotionMutator(SeeInvisibilityPotionBehaviorModel seeInvisibilityPotionModel, string mutatorId, int version) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string effectMutatorId = "SeeInvisibilityEffect"; //Field offset: 0x0
	public static readonly String[] mutatorIds; //Field offset: 0x0
	public const string mutatorId = "SeeInvisibilityPotion"; //Field offset: 0x0
	public const string mutatorIdV2 = "SeeInvisibilityPotionV2"; //Field offset: 0x0
	public const string mutatorIdV3 = "SeeInvisibilityPotionV3"; //Field offset: 0x0
	public int rounds; //Field offset: 0x30
	public PrefabReference buffDisplayPath; //Field offset: 0x38
	public string buffLocsName; //Field offset: 0x40
	public string buffIconName; //Field offset: 0x48
	private DisplayModel buffDisplayModel; //Field offset: 0x50
	public PrefabReference effectAtTowerId; //Field offset: 0x58
	public int upgradeV2At; //Field offset: 0x60
	public int roundsUpgradedTo; //Field offset: 0x64
	public float upgradedRangeScale; //Field offset: 0x68
	public int upgradeV3At; //Field offset: 0x6C
	public int bonusCamoDamage; //Field offset: 0x70
	private DamageModifierForTagModel camoModifier; //Field offset: 0x78
	private SeeInvisibilityPotionMutator[] mutators; //Field offset: 0x80
	private SeeInvisibilityPotionEffectMutator effectMutator; //Field offset: 0x88

	public SeeInvisibilityPotionEffectMutator EffectMutator
	{
		 get { } //Length: 234
	}

	private static SeeInvisibilityPotionBehaviorModel() { }

	public SeeInvisibilityPotionBehaviorModel(string name, int rounds, PrefabReference buffDisplayPath, string buffLocsName, string buffIconName, PrefabReference effectAtTowerId, int upgradeV2At, int roundsUpgradedTo, float upgradedRangeScale, int upgradeV3At, int bonusCamoDamage) { }

	public virtual Model Clone() { }

	public SeeInvisibilityPotionEffectMutator get_EffectMutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	public SeeInvisibilityPotionMutator GetMutator(int version) { }

	public SeeInvisibilityPotionMutator GetMutator(string id) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public bool IsTowerModelVisiblyImpaired(TowerModel towerModel) { }

}

