namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MoabShoveZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoabShoveZoneModel : TowerBehaviorModel
{
	internal class MoabShoveMutator : BehaviorMutator
	{
		public MoabShoveZoneModel moabShoveZoneModel; //Field offset: 0x70

		public MoabShoveMutator(MoabShoveZoneModel moabShoveZoneModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "MoabShoveZone"; //Field offset: 0x0
	public float range; //Field offset: 0x30
	public float moabPushSpeedScaleCap; //Field offset: 0x34
	public float bfbPushSpeedScaleCap; //Field offset: 0x38
	public float zomgPushSpeedScaleCap; //Field offset: 0x3C
	public FilterInvisibleModel filterInvisibleModel; //Field offset: 0x40

	public MoabShoveZoneModel(string name, float range, float moabPushSpeedScaleCap, float bfbPushSpeedScaleCap, float zomgPushSpeedScaleCap, FilterInvisibleModel filterInvisibleModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

