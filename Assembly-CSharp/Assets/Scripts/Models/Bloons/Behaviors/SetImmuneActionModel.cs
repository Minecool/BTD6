namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SetImmuneAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetImmuneActionModel : BloonBehaviorActionModel
{
	internal class ImmunityMutator : BehaviorMutator
	{

		public ImmunityMutator() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "Immune"; //Field offset: 0x0
	public bool set; //Field offset: 0x38
	public AudioClipReference sound; //Field offset: 0x40
	private ImmunityMutator mutator; //Field offset: 0x48

	public ImmunityMutator Mutator
	{
		 get { } //Length: 207
	}

	public SetImmuneActionModel() { }

	public SetImmuneActionModel(string name, string actionId, bool set, AudioClipReference sound) { }

	public virtual Model Clone() { }

	public ImmunityMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

