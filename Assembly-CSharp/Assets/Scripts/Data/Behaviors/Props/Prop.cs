namespace Assets.Scripts.Data.Behaviors.Props;

[CreateAssetMenu(fileName = "Prop", menuName = "BTD6/Behaviors/Prop Asset", order = 1)]
[UIComponent("Default")]
public class Prop : Entity<PropModel>, IGameEditorAsset
{
	[UIVariableHidden]
	public SpriteReference icon; //Field offset: 0x28
	[UIVariableComponent("DisplayView")]
	public PrefabReference display; //Field offset: 0x30
	private ItemVarientData itemVarientData; //Field offset: 0x38
	private PropSetType propSetType; //Field offset: 0x48
	private Area[] areas; //Field offset: 0x50
	private String[] collections; //Field offset: 0x58
	private string linkedToTrophyStoreItemId; //Field offset: 0x60
	private bool hasAnimationController; //Field offset: 0x68
	private bool isSightAndPlacementBlockingDisabled; //Field offset: 0x69
	private bool isPremiumItem; //Field offset: 0x6A
	private bool isNewItem; //Field offset: 0x6B
	[JsonConverter(typeof(BehaviorConverter))]
	public Behavior[] behaviors; //Field offset: 0x70
	private bool dontDestroyTowers; //Field offset: 0x78
	public float radius; //Field offset: 0x7C
	[JsonConverter(typeof(BehaviorConverter))]
	[UIVariableComponent("BehaviorListEditView")]
	public EntityEvent[] events; //Field offset: 0x80
	[HideInInspector]
	[ULongEnumFlags(typeof(MapEditorItemTag), True)]
	private ulong tags; //Field offset: 0x88

	[JsonIgnore]
	public virtual PropModel Def
	{
		 get { } //Length: 596
	}

	[JsonIgnore]
	public virtual EntityEvent[] Events
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public MapEditorItemTag Tags
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Prop() { }

	public virtual PropModel get_Def() { }

	public virtual EntityEvent[] get_Events() { }

	public virtual Model get_Model() { }

	public MapEditorItemTag get_Tags() { }

	public void set_Tags(MapEditorItemTag value) { }

}

