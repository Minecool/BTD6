namespace Assets.Scripts.Data.Bloons;

[CreateAssetMenu(fileName = "New Bloon", menuName = "BTD6/Bloon", order = 1)]
public class BloonScriptable : ScriptableObject
{
	internal class CollisionCircle
	{
		[SerializeField]
		public Vector2 offset; //Field offset: 0x10
		[SerializeField]
		public float radius; //Field offset: 0x18

		public CollisionCircle() { }

	}

	[SerializeField]
	private string Id; //Field offset: 0x18
	[SerializeField]
	private string baseId; //Field offset: 0x20
	[SerializeField]
	private float radius; //Field offset: 0x28
	[SerializeField]
	private float speed; //Field offset: 0x2C
	[SerializeField]
	private float health; //Field offset: 0x30
	[SerializeField]
	private float fortifiedHealth; //Field offset: 0x34
	[SerializeField]
	private float leakDamage; //Field offset: 0x38
	[SerializeField]
	private float dangerAmount; //Field offset: 0x3C
	[SerializeField]
	private int layerNumber; //Field offset: 0x40
	[SerializeField]
	private float cashForPop; //Field offset: 0x44
	[SerializeField]
	private bool isMoab; //Field offset: 0x48
	[SerializeField]
	private bool isBoss; //Field offset: 0x49
	[SerializeField]
	private BloonDisplayScriptable displays; //Field offset: 0x50
	[SerializeField]
	private BloonOverlayClass overlayClass; //Field offset: 0x58
	[SerializeField]
	private BloonProperties bloonProperties; //Field offset: 0x5C
	[SerializeField]
	private PrefabReference depletionEffect; //Field offset: 0x60
	[SerializeField]
	private BloonSoundFXScriptable soundsPopFX; //Field offset: 0x68
	[SerializeField]
	private bool disallowCosmetics; //Field offset: 0x70
	[SerializeField]
	private bool dontSave; //Field offset: 0x71
	[SerializeField]
	private bool showDamageText; //Field offset: 0x72
	[SerializeField]
	private bool dontShowInSandbox; //Field offset: 0x73
	[SerializeField]
	private bool dontShowInSandboxOnRelease; //Field offset: 0x74
	[SerializeField]
	private List<CollisionCircle> collisionCircles; //Field offset: 0x78
	[SerializeField]
	private List<String> tags; //Field offset: 0x80
	[SerializeField]
	private List<String> affectedByMonkeyKnowledge; //Field offset: 0x88
	[SerializeField]
	private bool alwaysRecordsDamage; //Field offset: 0x90
	[SerializeField]
	private bool isImmuneToSlow; //Field offset: 0x91
	[SerializeReference]
	private BloonBehaviorModel[] models; //Field offset: 0x98

	public BloonScriptable() { }

	public BloonModel Def(BloonKindDisplay bkd, CollisionGroupModel cgm) { }

	public List<BloonModel> Defs() { }

}

