namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateSoundOnTowerExpire), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnTowerExpireModel : TowerBehaviorModel
{
	public SoundModel sound; //Field offset: 0x30

	public CreateSoundOnTowerExpireModel(string name, SoundModel sound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

