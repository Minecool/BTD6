namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(EmergencyUnlock), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmergencyUnlockModel : AbilityBehaviorModel
{
	internal class EmergencyUnlockMutator : BehaviorMutator
	{
		private EmergencyUnlockModel emergencyUnlockModel; //Field offset: 0x70

		public EmergencyUnlockMutator(EmergencyUnlockModel emergencyUnlockModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float swivelSpeedMultiplier; //Field offset: 0x30
	[SerializeField]
	private float duration; //Field offset: 0x34
	public int durationFrames; //Field offset: 0x38
	public SoundModel activateSound; //Field offset: 0x40
	public PrefabReference buffDisplayPath; //Field offset: 0x48
	private DisplayModel buffDisplayModel; //Field offset: 0x50
	private EmergencyUnlockMutator mutator; //Field offset: 0x58

	public EmergencyUnlockMutator Mutator
	{
		 get { } //Length: 215
	}

	public EmergencyUnlockModel(string name, float swivelSpeedMultiplier, float duration, SoundModel activateSound, PrefabReference buffDisplayPath) { }

	public virtual Model Clone() { }

	public EmergencyUnlockMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

