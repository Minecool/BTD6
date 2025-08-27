namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(MorphTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MorphTowerModel : AbilityBehaviorModel
{
	internal class MorphMutator : BehaviorMutator
	{
		public TowerModel newTowerModel; //Field offset: 0x70

		public MorphMutator(bool isUnique, string mutatorId, int priority, TowerModel newTowerModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public bool isUnique; //Field offset: 0x30
	public int priority; //Field offset: 0x34
	public string mutatorId; //Field offset: 0x38
	public bool mutateAll; //Field offset: 0x40
	public bool mutateSelf; //Field offset: 0x41
	public TowerModel towerModel; //Field offset: 0x48
	public TowerModel secondaryTowerModel; //Field offset: 0x50
	public EffectModel effectModel; //Field offset: 0x58
	public EffectModel effectOnTransitionBackModel; //Field offset: 0x60
	public int maxTier; //Field offset: 0x68
	public float maxCost; //Field offset: 0x6C
	public int maxTowers; //Field offset: 0x70
	public string affectList; //Field offset: 0x78
	public String[] affectListArray; //Field offset: 0x80
	public bool resetOnDefeatScreen; //Field offset: 0x88
	public string ignoreWithMutators; //Field offset: 0x90
	public String[] ignoreWithMutatorsList; //Field offset: 0x98
	[SerializeField]
	private float lifespan; //Field offset: 0xA0
	public int lifespanFrames; //Field offset: 0xA4
	private MorphMutator morthTowerSelf; //Field offset: 0xA8
	private MorphMutator morthTowerNotSelf; //Field offset: 0xB0

	public float Lifespan
	{
		 get { } //Length: 9
		 set { } //Length: 27
	}

	public MorphMutator MorthTowerNotSelf
	{
		 get { } //Length: 180
	}

	public MorphMutator MorthTowerSelf
	{
		 get { } //Length: 180
	}

	public MorphTowerModel(string name, bool isUnique, int priority, string mutatorId, float lifespan, bool mutateAll, bool mutateSelf, TowerModel towerModel, TowerModel secondaryTowerModel, EffectModel effectModel, int maxTier, float maxCost, int maxTowers, string affectList, EffectModel effectOnTransitionBackModel, bool resetOnDefeatScreen, string ignoreWithMutators) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public MorphMutator get_MorthTowerNotSelf() { }

	public MorphMutator get_MorthTowerSelf() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

