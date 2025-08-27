namespace Assets.Scripts.Unity.Towers.Pets;

public class PetCreateSoundOnPlace : PetBehavior
{
	[SerializeField]
	private AudioClipReference sound; //Field offset: 0x10
	[SerializeField]
	private float delay; //Field offset: 0x18
	private PetBehaviorModel def; //Field offset: 0x20

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public PetCreateSoundOnPlace() { }

	public virtual PetBehaviorModel get_Def() { }

}

