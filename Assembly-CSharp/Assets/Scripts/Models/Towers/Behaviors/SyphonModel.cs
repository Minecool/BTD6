namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(Syphon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SyphonModel : TowerBehaviorWithOverlayModel
{
	internal class BloonWorthMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70
		public string overlayType; //Field offset: 0x78

		public BloonWorthMutator(string id, float multiplier, string overlayType) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string mutationId; //Field offset: 0x38
	public float multiplier; //Field offset: 0x40
	public int charges; //Field offset: 0x44
	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C
	public String[] ignoreTags; //Field offset: 0x50
	private BloonWorthMutator mutator; //Field offset: 0x58

	public BloonWorthMutator Mutator
	{
		 get { } //Length: 153
	}

	public SyphonModel(string name, string mutationId, float multiplier, int charges, float lifespan, String[] ignoreTags, string overlayType) { }

	public virtual Model Clone() { }

	public BloonWorthMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void UpdateMutator() { }

}

