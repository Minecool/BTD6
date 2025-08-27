namespace Assets.Scripts.Data.Behaviors;

[CreateAssetMenu(fileName = "Sound", menuName = "BTD6/Behaviors/Sound")]
public class Sound : EntityBehavior<SoundModel>
{
	public AudioClipReference sound; //Field offset: 0x28

	public virtual SoundModel Def
	{
		 get { } //Length: 105
	}

	public Sound() { }

	public virtual SoundModel get_Def() { }

}

