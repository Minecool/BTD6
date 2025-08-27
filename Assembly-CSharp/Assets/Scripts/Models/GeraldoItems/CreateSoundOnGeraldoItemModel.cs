namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(CreateSoundOnGeraldoItem), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnGeraldoItemModel : GeraldoItemBehaviorModel
{
	public AudioClipReference soundId; //Field offset: 0x30

	public CreateSoundOnGeraldoItemModel(string name, AudioClipReference soundId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

