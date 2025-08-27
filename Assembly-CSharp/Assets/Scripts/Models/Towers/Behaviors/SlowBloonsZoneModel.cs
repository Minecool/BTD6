namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SlowBloonsZone), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SlowBloonsZoneModel : TowerBehaviorModel
{
	internal class Mutator : BehaviorMutator
	{
		private float speedScale; //Field offset: 0x70
		private float speedChange; //Field offset: 0x74

		public Mutator(bool isUnique, string mutationId, float speedScale, float speedChange) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float zoneRadius; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x40
	public FilterModel[] filters; //Field offset: 0x48
	public float speedScale; //Field offset: 0x50
	public float speedChange; //Field offset: 0x54
	public bool bindRadiusToTowerRange; //Field offset: 0x58
	public float radiusOffset; //Field offset: 0x5C
	public string bloonTag; //Field offset: 0x60
	public String[] bloonTags; //Field offset: 0x68
	public bool inclusive; //Field offset: 0x70
	private BehaviorMutator _mutator; //Field offset: 0x78

	public BehaviorMutator mutator
	{
		 get { } //Length: 289
	}

	public SlowBloonsZoneModel(string name, float zoneRadius, string mutationId, bool isUnique, FilterModel[] filters, float speedScale, float speedChange, bool bindRadiusToTowerRange, float radiusOffset, string bloonTag, bool inclusive, BehaviorMutator mutator = null) { }

	public virtual Model Clone() { }

	public BehaviorMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

