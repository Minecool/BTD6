namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AdoraTransformSound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AdoraTransformSoundModel : TowerBehaviorModel
{
	public SoundModel newSelectSound01; //Field offset: 0x30
	public SoundModel newSelectSound02; //Field offset: 0x38
	public SoundModel newSelectSound03; //Field offset: 0x40
	public SoundModel newSelectSound04; //Field offset: 0x48
	public SoundModel newSelectSound05; //Field offset: 0x50
	public SoundModel newSelectSound06; //Field offset: 0x58
	public SoundModel newSelectAltSound01; //Field offset: 0x60
	public SoundModel newSelectAltSound02; //Field offset: 0x68
	public SoundModel newLeakSound01; //Field offset: 0x70
	public SoundModel newLeakSound02; //Field offset: 0x78
	public SoundModel newMoabDestroyedSound01; //Field offset: 0x80
	public SoundModel newMoabDestroyedSound02; //Field offset: 0x88
	public SoundModel newMoabWarningSound; //Field offset: 0x90
	public SoundModel newBfbWarningSound; //Field offset: 0x98
	public SoundModel newZomgWarningSound; //Field offset: 0xA0
	public SoundModel newDdtWarningSound; //Field offset: 0xA8
	public SoundModel newBadWarningSound; //Field offset: 0xB0
	public SoundModel newUltimate3Sound; //Field offset: 0xB8
	public SoundModel newUltimate7Sound; //Field offset: 0xC0
	public SoundModel newUltimate10Sound; //Field offset: 0xC8
	public SoundModel transformSound; //Field offset: 0xD0

	public AdoraTransformSoundModel(string name, SoundModel newSelectSound01, SoundModel newSelectSound02, SoundModel newSelectSound03, SoundModel newSelectSound04, SoundModel newSelectSound05, SoundModel newSelectSound06, SoundModel newSelectAltSound01, SoundModel newSelectAltSound02, SoundModel newLeakSound01, SoundModel newLeakSound02, SoundModel newMoabDestroyedSound01, SoundModel newMoabDestroyedSound02, SoundModel newMoabWarningSound, SoundModel newBfbWarningSound, SoundModel newZomgWarningSound, SoundModel newDdtWarningSound, SoundModel newBadWarningSound, SoundModel newUltimate3Sound, SoundModel newUltimate7Sound, SoundModel newUltimate10Sound, SoundModel transformSound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

