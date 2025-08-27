namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(JarOfPicklesBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class JarOfPicklesBehaviorModel : GeraldoItemBehaviorModel
{
	internal class JarOfPicklesMutator : BehaviorMutator
	{
		private readonly JarOfPicklesBehaviorModel jarOfPicklesBehaviorModel; //Field offset: 0x70
		public readonly int version; //Field offset: 0x78

		public JarOfPicklesMutator(JarOfPicklesBehaviorModel jarOfPicklesBehaviorModel, string mutatorId, int version) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public static readonly String[] mutatorIds; //Field offset: 0x0
	public const string mutatorIdV3 = "JarOfPicklesV3"; //Field offset: 0x0
	public const string mutatorIdV2 = "JarOfPicklesV2"; //Field offset: 0x0
	public const string mutatorId = "JarOfPickles"; //Field offset: 0x0
	public float attackSpeedScale; //Field offset: 0x30
	public int damageIncrease; //Field offset: 0x34
	public int rounds; //Field offset: 0x38
	public PrefabReference buffDisplayPath; //Field offset: 0x40
	public string buffLocsName; //Field offset: 0x48
	public string buffIconName; //Field offset: 0x50
	public PrefabReference effectAtTowerId; //Field offset: 0x58
	private DisplayModel buffDisplayModel; //Field offset: 0x60
	public int bonusFortDamageAt; //Field offset: 0x68
	public int bonusFortDamage; //Field offset: 0x6C
	public int bonusFortDamageAtV2; //Field offset: 0x70
	public int bonusFortDamageV2; //Field offset: 0x74
	private DamageModifierForTagModel fortModifier; //Field offset: 0x78
	private DamageModifierForTagModel fortModifierV2; //Field offset: 0x80
	private JarOfPicklesMutator[] mutators; //Field offset: 0x88

	private static JarOfPicklesBehaviorModel() { }

	public JarOfPicklesBehaviorModel(string name, float attackSpeedScale, int damageIncrease, int rounds, PrefabReference buffDisplayPath, string buffLocsName, string buffIconName, PrefabReference effectAtTowerId, int bonusFortDamageAt, int bonusFortDamage, int bonusFortDamageAtV2, int bonusFortDamageV2) { }

	public virtual Model Clone() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	public JarOfPicklesMutator GetMutator(int version) { }

	public JarOfPicklesMutator GetMutator(string id) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

