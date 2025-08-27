namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(HexManager), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HexManagerModel : TowerBehaviorWithOverlayModel
{
	internal class HexMutator : BehaviorMutator
	{
		public BloonBehaviorModel behavior; //Field offset: 0x70
		public string overlayType; //Field offset: 0x78
		public string mutationId; //Field offset: 0x80

		public HexMutator(BloonBehaviorModel behavior, string mutationId, string overlayType, bool isUnique = true, bool lastAppliesFirst = false) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public HexModel hex; //Field offset: 0x38
	private Dictionary<ObjectId, HexMutator> mutators; //Field offset: 0x40

	public HexManagerModel(string name, HexModel hex, string overlayType) { }

	public virtual Model Clone() { }

	public HexMutator GetMutatorForTower(Tower tower) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

