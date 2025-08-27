namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateSoundOnUpgrade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnUpgradeModel : TowerBehaviorModel
{
	public SoundModel sound; //Field offset: 0x30
	public SoundModel sound1; //Field offset: 0x38
	public SoundModel sound2; //Field offset: 0x40
	public SoundModel sound3; //Field offset: 0x48
	public SoundModel sound4; //Field offset: 0x50
	public SoundModel sound5; //Field offset: 0x58
	public SoundModel sound6; //Field offset: 0x60
	public SoundModel sound7; //Field offset: 0x68
	public SoundModel sound8; //Field offset: 0x70

	public CreateSoundOnUpgradeModel(string name, SoundModel sound, SoundModel sound1, SoundModel sound2, SoundModel sound3, SoundModel sound4, SoundModel sound5, SoundModel sound6, SoundModel sound7, SoundModel sound8) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

