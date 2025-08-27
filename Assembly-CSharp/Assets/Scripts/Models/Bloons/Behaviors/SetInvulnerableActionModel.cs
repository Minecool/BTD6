namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SetInvulnerableAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetInvulnerableActionModel : BloonBehaviorActionModel
{
	internal class InvulnerableMutator : BehaviorMutator
	{

		public InvulnerableMutator() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "Invulnerable"; //Field offset: 0x0
	public bool set; //Field offset: 0x38
	public AudioClipReference sound; //Field offset: 0x40
	private InvulnerableMutator mutator; //Field offset: 0x48

	public InvulnerableMutator Mutator
	{
		 get { } //Length: 207
	}

	public SetInvulnerableActionModel() { }

	public SetInvulnerableActionModel(string name, string actionId, bool set, AudioClipReference sound) { }

	public virtual Model Clone() { }

	public InvulnerableMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

