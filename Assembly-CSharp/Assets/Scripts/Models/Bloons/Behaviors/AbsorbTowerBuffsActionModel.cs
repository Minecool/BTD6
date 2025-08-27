namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(AbsorbTowerBuffsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AbsorbTowerBuffsActionModel : BloonBehaviorActionModel
{
	internal class TowerFreezeMutator : BehaviorMutator
	{
		public PrefabReference towerFreezeDisplayId; //Field offset: 0x70

		public TowerFreezeMutator(PrefabReference towerFreezeDisplayId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int healPerBuff; //Field offset: 0x38
	public float healPercentPerBuff; //Field offset: 0x3C
	[SerializeField]
	private float towerFreezeDuration; //Field offset: 0x40
	public int towerFreezeDurationFrames; //Field offset: 0x44
	public float radius; //Field offset: 0x48
	public String[] ignoredBuffs; //Field offset: 0x50
	public String[] buffsAlwaysRemoved; //Field offset: 0x58
	public String[] buffsThatDontHeal; //Field offset: 0x60
	public String[] towersWhichAreDestroyed; //Field offset: 0x68
	public PrefabReference towerFreezeDisplayAsset; //Field offset: 0x70
	public string triggerName; //Field offset: 0x78
	private TowerFreezeMutator mutator; //Field offset: 0x80

	public TowerFreezeMutator Mutator
	{
		 get { } //Length: 231
	}

	public AbsorbTowerBuffsActionModel() { }

	public AbsorbTowerBuffsActionModel(string name, string actionId, int healPerBuff, float healPercentPerBuff, float towerFreezeDuration, float radius, String[] ignoredBuffs, String[] buffsAlwaysRemoved, String[] buffsThatDontHeal, String[] towersWhichAreDestroyed, PrefabReference towerFreezeDisplayAsset, string triggerName) { }

	public virtual Model Clone() { }

	public TowerFreezeMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

