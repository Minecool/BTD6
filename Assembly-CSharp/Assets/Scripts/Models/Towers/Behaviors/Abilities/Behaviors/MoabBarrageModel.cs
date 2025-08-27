namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(MoabBarrage), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoabBarrageModel : AbilityBehaviorModel
{
	internal class AddBehaviorToBloonMutator : BehaviorMutator
	{
		public MoabBarrageModel moabBarrageModel; //Field offset: 0x70

		public AddBehaviorToBloonMutator(MoabBarrageModel addBehaviorToBloonModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int durationFrames; //Field offset: 0x30
	public BloonBehaviorModel damageOverTimeModel; //Field offset: 0x38
	public int targets; //Field offset: 0x40
	public string mutatorId; //Field offset: 0x48
	private Dictionary<ObjectId, AddBehaviorToBloonMutator> mutators; //Field offset: 0x50

	public MoabBarrageModel(string name, int durationFrames, BloonBehaviorModel damageOverTimeModel, int targets, string mutatorId) { }

	public virtual Model Clone() { }

	public AddBehaviorToBloonMutator GetMutatorForTower(Tower tower) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

