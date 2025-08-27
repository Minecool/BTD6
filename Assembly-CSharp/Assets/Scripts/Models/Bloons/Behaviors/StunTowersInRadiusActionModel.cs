namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(StunTowersInRadiusAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class StunTowersInRadiusActionModel : BloonBehaviorActionModel
{
	internal class TowerFreezeMutator : BehaviorMutator
	{
		public PrefabReference towerStunDisplayId; //Field offset: 0x70
		public bool blockTowerSelling; //Field offset: 0x78
		public bool pauseAnimations; //Field offset: 0x79
		public bool hideDisplayForSubtowers; //Field offset: 0x7A

		public TowerFreezeMutator(string id, PrefabReference towerStunDisplayId, bool blockTowerSelling, bool pauseAnimations = false, bool hideDisplayForSubtowers = false) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "TowerStun"; //Field offset: 0x0
	public float radius; //Field offset: 0x38
	public float stunDuration; //Field offset: 0x3C
	public float paragonStunTimeMultiplier; //Field offset: 0x40
	public PrefabReference towerStunEffect; //Field offset: 0x48
	public bool blockTowerSelling; //Field offset: 0x50
	private TowerFreezeMutator mutator; //Field offset: 0x58

	public TowerFreezeMutator Mutator
	{
		 get { } //Length: 165
	}

	public StunTowersInRadiusActionModel() { }

	public StunTowersInRadiusActionModel(string name, string actionId, float radius, float stunDuration, float paragonStunTimeMultiplier, PrefabReference towerStunDisplayAsset, bool blockTowerSelling) { }

	public virtual Model Clone() { }

	public TowerFreezeMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

