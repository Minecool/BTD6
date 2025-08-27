namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateSoundOnSelected : TowerBehavior
{
	public CreateSoundOnSelected parent; //Field offset: 0x98
	public AudioClip sound1; //Field offset: 0xA0
	public AudioClip expSound1; //Field offset: 0xA8
	public AudioClip sound2; //Field offset: 0xB0
	public AudioClip expSound2; //Field offset: 0xB8
	public AudioClip sound3; //Field offset: 0xC0
	public AudioClip expSound3; //Field offset: 0xC8
	public AudioClip sound4; //Field offset: 0xD0
	public AudioClip expSound4; //Field offset: 0xD8
	public AudioClip sound5; //Field offset: 0xE0
	public AudioClip expSound5; //Field offset: 0xE8
	public AudioClip sound6; //Field offset: 0xF0
	public AudioClip expSound6; //Field offset: 0xF8
	public AudioClip altSound1; //Field offset: 0x100
	public AudioClip expAltSound1; //Field offset: 0x108
	public AudioClip altSound2; //Field offset: 0x110
	public AudioClip expAltSound2; //Field offset: 0x118

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1501
	}

	public CreateSoundOnSelected() { }

	public virtual TowerBehaviorModel get_Def() { }

}

