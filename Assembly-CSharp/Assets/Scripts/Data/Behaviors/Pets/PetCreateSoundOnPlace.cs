namespace Assets.Scripts.Data.Behaviors.Pets;

[CreateAssetMenu(fileName = "PetCreateSoundOnPlace", menuName = "BTD6/Behaviors/Pets/PetCreateSoundOnPlace")]
public class PetCreateSoundOnPlace : PetBehavior
{
	public AudioClipReference sound; //Field offset: 0x28
	public float delay; //Field offset: 0x30

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 131
	}

	public PetCreateSoundOnPlace() { }

	public virtual PetBehaviorModel get_Def() { }

}

