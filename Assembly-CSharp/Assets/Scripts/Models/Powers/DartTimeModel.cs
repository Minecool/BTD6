namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(DartTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DartTimeModel : PowerBehaviorModel
{
	internal class BloonTimeSlowMutatorClass : BehaviorMutator
	{
		private DartTimeModel dtModel; //Field offset: 0x70

		public BloonTimeSlowMutatorClass(DartTimeModel dtModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class TowerTimeSlowMutatorClass : BehaviorMutator
	{
		private DartTimeModel dtModel; //Field offset: 0x70

		public TowerTimeSlowMutatorClass(DartTimeModel dtModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float bloonSpeed; //Field offset: 0x30
	public float towerAttackSpeed; //Field offset: 0x34
	public float duration; //Field offset: 0x38
	private DartTimeBloonBehaviorModel dartTimeBloonBehaviorModel; //Field offset: 0x40
	private BloonTimeSlowMutatorClass bloonTimeSlowMutator; //Field offset: 0x48
	private TowerTimeSlowMutatorClass towerTimeSlowMutator; //Field offset: 0x50

	public BloonTimeSlowMutatorClass BloonTimeSlowMutator
	{
		 get { } //Length: 211
	}

	public TowerTimeSlowMutatorClass TowerTimeSlowMutator
	{
		 get { } //Length: 211
	}

	public DartTimeModel(string name, float bloonSpeed, float towerAttackSpeed, float duration) { }

	public virtual Model Clone() { }

	public BloonTimeSlowMutatorClass get_BloonTimeSlowMutator() { }

	public TowerTimeSlowMutatorClass get_TowerTimeSlowMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

