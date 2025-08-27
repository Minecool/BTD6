namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnBloonEnterTrack", menuName = "BTD6/Behaviors/Towers/CreateSoundOnBloonEnterTrack")]
public class CreateSoundOnBloonEnterTrack : TowerBehavior
{
	public Sound enterMoabSound; //Field offset: 0x30
	public Sound enterBfbSound; //Field offset: 0x38
	public Sound enterDdtSound; //Field offset: 0x40
	public Sound enterZomgSound; //Field offset: 0x48
	public Sound enterBadSound; //Field offset: 0x50

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 348
	}

	public CreateSoundOnBloonEnterTrack() { }

	public virtual TowerBehaviorModel get_Def() { }

}

