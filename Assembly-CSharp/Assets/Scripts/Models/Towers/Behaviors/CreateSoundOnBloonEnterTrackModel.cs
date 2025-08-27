namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateSoundOnBloonEnterTrack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnBloonEnterTrackModel : TowerBehaviorModel
{
	public SoundModel moabSound; //Field offset: 0x30
	public SoundModel bfbSound; //Field offset: 0x38
	public SoundModel ddtSound; //Field offset: 0x40
	public SoundModel zomgSound; //Field offset: 0x48
	public SoundModel badSound; //Field offset: 0x50

	public CreateSoundOnBloonEnterTrackModel(string name, SoundModel moabSound, SoundModel bfbSound, SoundModel ddtSound, SoundModel zomgSound, SoundModel badSound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

