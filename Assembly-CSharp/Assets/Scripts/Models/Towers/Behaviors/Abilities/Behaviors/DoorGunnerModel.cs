namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(DoorGunner), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DoorGunnerModel : AbilityBehaviorModel
{
	internal class DoorGunnerMutator : BehaviorMutator
	{

		public DoorGunnerMutator() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public PrefabReference selectionObjectPath; //Field offset: 0x30
	public PrefabReference isSelectableGameObject; //Field offset: 0x38
	public SoundModel activateSound; //Field offset: 0x40
	public SoundModel pickupSound; //Field offset: 0x48
	private DoorGunnerMutator mutator; //Field offset: 0x50

	public DoorGunnerMutator Mutator
	{
		 get { } //Length: 207
	}

	public DoorGunnerModel(string name, PrefabReference selectionObjectPath, PrefabReference isSelectableGameObject, SoundModel activateSound, SoundModel pickupSound) { }

	public virtual Model Clone() { }

	public DoorGunnerMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

