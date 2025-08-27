namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Wind), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WindModel : ProjectileBehaviorWithOverlayModel
{
	internal class AddBehaviorToBloonMutator : BehaviorMutator
	{
		private readonly float distanceMin; //Field offset: 0x70
		private readonly float distanceMax; //Field offset: 0x74
		public string overlayType; //Field offset: 0x78
		public readonly float distanceScaleForTags; //Field offset: 0x80
		public readonly string distanceScaleForTagsTags; //Field offset: 0x88
		public float speedMultiplier; //Field offset: 0x90

		public AddBehaviorToBloonMutator(string id, float distanceMin, float distanceMax, string overlayType, float distanceScaleForTags, string distanceScaleForTagsTags, float speedMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string id = "Wind"; //Field offset: 0x0
	public float distanceMin; //Field offset: 0x40
	public float distanceMax; //Field offset: 0x44
	public float chance; //Field offset: 0x48
	public bool affectMoab; //Field offset: 0x4C
	public float distanceScaleForTags; //Field offset: 0x50
	public string distanceScaleForTagsTags; //Field offset: 0x58
	public String[] distanceScaleForTagsTagsList; //Field offset: 0x60
	public float speedMultiplier; //Field offset: 0x68
	private AddBehaviorToBloonMutator _mutator; //Field offset: 0x70

	public AddBehaviorToBloonMutator mutator
	{
		 get { } //Length: 399
	}

	public WindModel(string name, float distanceMin, float distanceMax, float chance, bool affectMoab, string overlayType, float distanceScaleForTags = 1, string distanceScaleForTagsTags = "", float speedMultiplier = 1) { }

	public virtual Model Clone() { }

	public AddBehaviorToBloonMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

