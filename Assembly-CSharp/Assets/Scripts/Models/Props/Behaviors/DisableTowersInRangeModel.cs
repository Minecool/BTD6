namespace Assets.Scripts.Models.Props.Behaviors;

[Implementation(typeof(DisableTowersInRange), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DisableTowersInRangeModel : PropBehaviorModel
{
	internal class SuspendTowerMutator : BehaviorMutator
	{
		public PrefabReference displayOverlay; //Field offset: 0x70
		public bool hideDisplayForSubtowers; //Field offset: 0x78

		public SuspendTowerMutator(string id, PrefabReference displayOverlay, bool hideDisplayForSubtowers = false, string saveId = "") { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "TowerSuspendedMutator"; //Field offset: 0x0
	public int range; //Field offset: 0x30
	public PrefabReference disabledTowerOverlayDisplay; //Field offset: 0x38
	private SuspendTowerMutator mutator; //Field offset: 0x40

	public SuspendTowerMutator Mutator
	{
		 get { } //Length: 295
	}

	public DisableTowersInRangeModel(string name, int range, PrefabReference disabledTowerOverlayDisplay) { }

	public virtual Model Clone() { }

	public SuspendTowerMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

