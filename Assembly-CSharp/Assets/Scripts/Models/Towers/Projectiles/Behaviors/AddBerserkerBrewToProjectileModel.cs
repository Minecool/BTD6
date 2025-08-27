namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddBerserkerBrewToProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddBerserkerBrewToProjectileModel : ProjectileBehaviorModel
{
	internal class BeserkerBrewMutator : BehaviorMutator
	{
		private AddBerserkerBrewToProjectileModel brewModel; //Field offset: 0x70

		public BeserkerBrewMutator(AddBerserkerBrewToProjectileModel brewModel, bool isUnique, string id, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class BlockerMutator : BehaviorMutator
	{

		public BlockerMutator(bool isUnique, string id, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string BerserkerBrewPermaId = "BerserkerBrewPerma"; //Field offset: 0x0
	public static readonly string blockerMutationId; //Field offset: 0x0
	public int cap; //Field offset: 0x38
	public string ignoreList; //Field offset: 0x40
	public string mutationId; //Field offset: 0x48
	[SerializeField]
	private float lifespan; //Field offset: 0x50
	public int lifespanFrames; //Field offset: 0x54
	public float damageUp; //Field offset: 0x58
	public float pierceUp; //Field offset: 0x5C
	public float rateUp; //Field offset: 0x60
	public float rangeUp; //Field offset: 0x64
	[SerializeField]
	private float rebuffBlockTime; //Field offset: 0x68
	public int rebuffBlockTimeFrames; //Field offset: 0x6C
	public WeaponBehaviorModel[] weapBehaviors; //Field offset: 0x70
	public TowerBehaviorModel[] towerBehaviors; //Field offset: 0x78
	public String[] ignoreMutationsByOrder; //Field offset: 0x80
	public PrefabReference assetId; //Field offset: 0x88
	public string buffLocsName; //Field offset: 0x90
	public string buffIconName; //Field offset: 0x98
	public string mutatorsToRemove; //Field offset: 0xA0
	public String[] mutatorsToRemoveList; //Field offset: 0xA8
	private BeserkerBrewMutator mutator; //Field offset: 0xB0
	private BlockerMutator blocker; //Field offset: 0xB8

	public BlockerMutator Blocker
	{
		 get { } //Length: 256
	}

	public BeserkerBrewMutator Mutator
	{
		 get { } //Length: 272
	}

	private static AddBerserkerBrewToProjectileModel() { }

	public AddBerserkerBrewToProjectileModel(string name, string mutationId, float lifespan, int cap, float damageUp, float pierceUp, float rateUp, float rangeUp, string ignoreList, WeaponBehaviorModel[] weapBehaviors, TowerBehaviorModel[] towerBehaviors, String[] ignoreMutationsByOrder, float rebuffBlockTime, PrefabReference assetId, string buffLocsName, string buffIconName, string mutatorsToRemove) { }

	public virtual Model Clone() { }

	public BlockerMutator get_Blocker() { }

	public BeserkerBrewMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

