namespace Assets.Scripts.Models.Bloons;

[Implementation(typeof(Bloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BloonModel : Model
{
	public string id; //Field offset: 0x30
	public string baseId; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40
	public SpriteReference icon; //Field offset: 0x48
	public BloonOverlayClass overlayClass; //Field offset: 0x50
	public String[] tags; //Field offset: 0x58
	public Model[] behaviors; //Field offset: 0x60
	public ApplyModModel[] mods; //Field offset: 0x68
	public DamageStateModel[] damageDisplayStates; //Field offset: 0x70
	public CollisionGroupModel collisionGroup; //Field offset: 0x78
	public BloonProperties bloonProperties; //Field offset: 0x80
	public EffectModel[] depletionEffects; //Field offset: 0x88
	public bool isMoab; //Field offset: 0x90
	public bool isBoss; //Field offset: 0x91
	public bool isCamo; //Field offset: 0x92
	public bool isGrow; //Field offset: 0x93
	public bool isFortified; //Field offset: 0x94
	public bool hasChildrenWithDifferentTotalHealths; //Field offset: 0x95
	public bool isInvulnerable; //Field offset: 0x96
	public bool distributeDamageToChildren; //Field offset: 0x97
	public bool disallowCosmetics; //Field offset: 0x98
	public bool isSaved; //Field offset: 0x99
	public bool isImmuneToSlow; //Field offset: 0x9A
	private Nullable<Single> totalLeakDamage; //Field offset: 0x9C
	private Nullable<Single> storedLayers; //Field offset: 0xA4
	public float radius; //Field offset: 0xAC
	public float danger; //Field offset: 0xB0
	public int maxHealth; //Field offset: 0xB4
	public float coopMultiplier; //Field offset: 0xB8
	public float armourMultiplier; //Field offset: 0xBC
	public float leakDamage; //Field offset: 0xC0
	public int layerNumber; //Field offset: 0xC4
	public float bonusDamagePerHit; //Field offset: 0xC8
	public String[] currentOverlays; //Field offset: 0xD0
	public bool dontShowInSandbox; //Field offset: 0xD8
	public bool dontShowInSandboxOnRelease; //Field offset: 0xD9
	public bool alwaysRecordsDamage; //Field offset: 0xDA
	[SerializeField]
	private float speed; //Field offset: 0xDC
	public float speedFrames; //Field offset: 0xE0
	private Nullable<Boolean> isRock; //Field offset: 0xE4
	private bool updateChildBloonModels; //Field offset: 0xE6
	private readonly List<BloonModel> childBloonModels; //Field offset: 0xE8

	public bool IsBase
	{
		 get { } //Length: 32
	}

	public bool IsRock
	{
		 get { } //Length: 174
	}

	public float Speed
	{
		 get { } //Length: 9
		 set { } //Length: 25
	}

	public BloonModel(string id, string baseId, float speed, float radius, PrefabReference display, DamageStateModel[] damageDisplayStates, SpriteReference icon, Model[] behaviors, BloonOverlayClass overlayClass, String[] tags, ApplyModModel[] mods, CollisionGroupModel collisionGroup, float danger, bool hasChildrenWithDifferentTotalHealths, int layerNumber, bool isCamo, bool isGrow, bool isFortified, EffectModel[] depletionEffects, bool isMoab, bool isBoss, BloonProperties bloonProperties, float leakDamage, int maxHealth, bool distributeDamageToChildren, bool isInvulnerable, float bonusDamagePerHit, bool disallowCosmetics, bool isSaved, String[] currentOverlays, bool dontShowInSandbox, bool dontShowInSandboxOnRelease, bool alwaysRecordsDamage, bool isImmuneToSlow, float armourMultiplier = 1) { }

	public virtual Model Clone() { }

	public bool get_IsBase() { }

	public bool get_IsRock() { }

	public float get_Speed() { }

	public List<BloonModel> GetChildBloonModels(Simulation sim) { }

	public float GetTotalLayers(GameModel model) { }

	public float GetTotalLeakDamage(GameModel model) { }

	public bool HasTag(string tagToFind) { }

	public bool HasTags(String[] checkTags) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public bool IsHeavy() { }

	public void ResetTotalLeakDamage() { }

	public void set_Speed(float value) { }

	public void UpdateChildBloonModels() { }

}

