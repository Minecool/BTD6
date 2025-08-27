namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AddSoundToShopMenu), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddSoundToShopMenuModel : TowerBehaviorModel
{
	public SoundModel openShopSound; //Field offset: 0x30
	public SoundModel heroVoiceSound1; //Field offset: 0x38
	public SoundModel heroVoiceSound2; //Field offset: 0x40

	public AddSoundToShopMenuModel(string name, SoundModel openShopSound, SoundModel heroVoiceSound1, SoundModel heroVoiceSound2) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

