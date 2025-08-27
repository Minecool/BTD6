namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateSoundOnSell), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnSellModel : TowerBehaviorModel
{
	public SoundModel sound; //Field offset: 0x30

	public CreateSoundOnSellModel(string name, SoundModel sound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

