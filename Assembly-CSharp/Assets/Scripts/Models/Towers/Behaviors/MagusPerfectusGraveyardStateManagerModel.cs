namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MagusPerfectusGraveyardStateManager), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MagusPerfectusGraveyardStateManagerModel : TowerBehaviorModel
{
	public static readonly string StateConsuming; //Field offset: 0x0
	public static readonly string StateGenerating; //Field offset: 0x8
	public static readonly string StateDrainingOverTime; //Field offset: 0x10
	public static readonly String[] AllGraveyardStates; //Field offset: 0x18
	public int maxManaStoredInGraveyard; //Field offset: 0x30
	public Dictionary<String, String[]> attackManagerStates; //Field offset: 0x38
	public float rateBonusThreshold; //Field offset: 0x40
	public float rateMultplierAmount; //Field offset: 0x44
	public PrefabReference graveyardDisplay1; //Field offset: 0x48
	public PrefabReference graveyardDisplay2; //Field offset: 0x50
	public PrefabReference textDisplayPrefab; //Field offset: 0x58
	public SoundModel switchAttackToGenerateSound; //Field offset: 0x60
	public SoundModel switchAttackToConsumeSound; //Field offset: 0x68
	public PrefabReference[] phoenixDisabledPrefabs; //Field offset: 0x70
	private RateSupportMutator rateMutator; //Field offset: 0x78

	public RateSupportMutator RateMutator
	{
		 get { } //Length: 284
	}

	private static MagusPerfectusGraveyardStateManagerModel() { }

	public MagusPerfectusGraveyardStateManagerModel(string name, int maxManaStoredInGraveyard, Dictionary<String, String[]> attackManagerStates, float rateBonusThreshold, float rateMultplierAmount, PrefabReference graveyardDisplay1, PrefabReference graveyardDisplay2, PrefabReference textDisplayPrefab, SoundModel switchAttackToGenerateSound, SoundModel switchAttackToConsumeSound, PrefabReference[] phoenixDisabledPrefabs) { }

	public virtual Model Clone() { }

	private Dictionary<String, String[]> CloneAttackManagerStates() { }

	private bool CompareAttackManagerStates(MagusPerfectusGraveyardStateManagerModel compareTo) { }

	public RateSupportMutator get_RateMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

