namespace Assets.Scripts.Unity.Towers.Pets;

public class PetCreateSoundOnIdle : PetBehavior
{
	[SerializeField]
	private AudioClipReference sound1; //Field offset: 0x18
	[SerializeField]
	private AudioClipReference sound2; //Field offset: 0x20
	[SerializeField]
	private AudioClipReference sound3; //Field offset: 0x28
	[SerializeField]
	private AudioClipReference sound4; //Field offset: 0x30
	[SerializeField]
	private int idleMin; //Field offset: 0x38
	[SerializeField]
	private int idleMax; //Field offset: 0x3C
	private PetBehaviorModel def; //Field offset: 0x40

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 253
	}

	public PetCreateSoundOnIdle() { }

	public virtual PetBehaviorModel get_Def() { }

}

