namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AddBehaviorToBloonInZone), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddBehaviorToBloonInZoneModel : TowerBehaviorWithOverlayModel
{
	internal class AddBehaviorToBloonMutator : BehaviorMutator
	{
		public string overlayType; //Field offset: 0x70
		public BloonBehaviorModel[] behaviors; //Field offset: 0x78
		public string mutationId; //Field offset: 0x80

		public AddBehaviorToBloonMutator(bool isUnique, string overlayType, BloonBehaviorModel[] behaviors, string mutationId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float zoneRadius; //Field offset: 0x38
	public string mutationId; //Field offset: 0x40
	public bool isUnique; //Field offset: 0x48
	public BloonBehaviorModel[] behaviors; //Field offset: 0x50
	public FilterModel[] filters; //Field offset: 0x58
	public bool bindRadiusToTowerRange; //Field offset: 0x60
	public float radiusOffset; //Field offset: 0x64
	private BehaviorMutator _mutator; //Field offset: 0x68

	public BehaviorMutator mutator
	{
		 get { } //Length: 284
	}

	public AddBehaviorToBloonInZoneModel(string name, float zoneRadius, string mutationId, bool isUnique, BloonBehaviorModel[] behaviors, FilterModel[] filters, string overlayType, bool bindRadiusToTowerRange = false, float radiusOffset = 0, BehaviorMutator mutator = null) { }

	public virtual Model Clone() { }

	public BehaviorMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

