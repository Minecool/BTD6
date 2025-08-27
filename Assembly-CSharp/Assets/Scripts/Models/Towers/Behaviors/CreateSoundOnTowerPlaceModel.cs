namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateSoundOnTowerPlace), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnTowerPlaceModel : TowerBehaviorModel
{
	public SoundModel sound1; //Field offset: 0x30
	public SoundModel sound2; //Field offset: 0x38
	public SoundModel waterSound1; //Field offset: 0x40
	public SoundModel waterSound2; //Field offset: 0x48
	public SoundModel heroSound1; //Field offset: 0x50
	public SoundModel heroSound2; //Field offset: 0x58
	public SoundModel reactSound; //Field offset: 0x60
	public SoundModel reactSoundAlt; //Field offset: 0x68
	public string towerType; //Field offset: 0x70
	public string towerSkin; //Field offset: 0x78
	public float reactDelay; //Field offset: 0x80

	public CreateSoundOnTowerPlaceModel(string name, SoundModel sound1, SoundModel sound2, SoundModel waterSound1, SoundModel waterSound2, SoundModel heroSound1, SoundModel heroSound2, SoundModel reactSound, SoundModel reactSoundAlt, string towerType, string towerSkin, float reactDelay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

