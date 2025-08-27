namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Redeploy), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RedeployModel : AbilityBehaviorModel
{
	internal class RedeployMutator : BehaviorMutator
	{

		public RedeployMutator() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "RedeployMutator"; //Field offset: 0x0
	public PrefabReference selectionObjectPath; //Field offset: 0x30
	public PrefabReference isSelectableGameObject; //Field offset: 0x38
	public SoundModel activateSound; //Field offset: 0x40
	public SoundModel pickupSound; //Field offset: 0x48
	public SoundModel dropOffSound; //Field offset: 0x50
	public bool isDoorGunnerActive; //Field offset: 0x58
	private RedeployMutator mutator; //Field offset: 0x60

	public RedeployMutator Mutator
	{
		 get { } //Length: 207
	}

	public RedeployModel(string name, PrefabReference selectionObjectPath, PrefabReference isSelectableGameObject, SoundModel activateSound, SoundModel pickupSound, SoundModel dropOffSound, bool isDoorGunnerActive) { }

	public virtual Model Clone() { }

	public RedeployMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

