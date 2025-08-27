namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddTagToBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddTagToBloonModel : ProjectileBehaviorWithOverlayModel
{
	internal class Mutator : BehaviorMutator
	{
		public float multiplier; //Field offset: 0x70
		public string mutationId; //Field offset: 0x78
		public string bloonTag; //Field offset: 0x80
		public string overlayType; //Field offset: 0x88

		public Mutator(string bloonTag, string mutationId, bool isUnique, string overlayType) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string bloonTag; //Field offset: 0x40
	public int layers; //Field offset: 0x48
	public string mutationId; //Field offset: 0x50
	public bool isUnique; //Field offset: 0x58
	private Mutator _mutator; //Field offset: 0x60
	[SerializeField]
	private float lifespan; //Field offset: 0x68
	public int lifespanFrames; //Field offset: 0x6C

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public Mutator mutator
	{
		 get { } //Length: 284
	}

	public AddTagToBloonModel(string name, string bloonTag, float lifespan, string mutationId, int layers, bool isUnique, string overlayType, Mutator mutator = null) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public Mutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

