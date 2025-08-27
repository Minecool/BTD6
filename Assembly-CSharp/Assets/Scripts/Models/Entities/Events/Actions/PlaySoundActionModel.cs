namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(PlaySoundAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PlaySoundActionModel : EntityActionModel
{
	public SoundModel sound; //Field offset: 0x38

	public PlaySoundActionModel(string name, SoundModel sound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

