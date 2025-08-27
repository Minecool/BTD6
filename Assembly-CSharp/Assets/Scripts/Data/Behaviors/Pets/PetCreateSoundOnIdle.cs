namespace Assets.Scripts.Data.Behaviors.Pets;

[CreateAssetMenu(fileName = "PetCreateSoundOnIdle", menuName = "BTD6/Behaviors/Pets/PetCreateSoundOnIdle")]
public class PetCreateSoundOnIdle : PetBehavior
{
	public AudioClipReference sound1; //Field offset: 0x28
	public AudioClipReference sound2; //Field offset: 0x30
	public AudioClipReference sound3; //Field offset: 0x38
	public AudioClipReference sound4; //Field offset: 0x40
	public int idleMin; //Field offset: 0x48
	public int idleMax; //Field offset: 0x4C

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 196
	}

	public PetCreateSoundOnIdle() { }

	public virtual PetBehaviorModel get_Def() { }

}

