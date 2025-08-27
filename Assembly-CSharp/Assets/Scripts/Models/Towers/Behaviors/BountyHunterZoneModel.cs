namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BountyHunterZone), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BountyHunterZoneModel : SupportModel
{
	internal class BountyHunterMutator : BehaviorMutator
	{

		public BountyHunterMutator(BuffIndicatorModel buffIndicator, bool isArtifactMutator = false) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string BountyHunterMutatorId = "BountyHunterZone"; //Field offset: 0x0
	private BountyHunterMutator mutator; //Field offset: 0x60

	public BountyHunterMutator Mutator
	{
		 get { } //Length: 238
	}

	public BountyHunterZoneModel(string name, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	public BountyHunterMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

