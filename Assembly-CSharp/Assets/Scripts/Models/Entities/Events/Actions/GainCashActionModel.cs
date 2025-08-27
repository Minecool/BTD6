namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(GainCashAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GainCashActionModel : EntityActionModel
{
	public float amount; //Field offset: 0x38
	public bool showText; //Field offset: 0x3C
	public PrefabReference textAssetId; //Field offset: 0x40

	public GainCashActionModel(string name, float amount, bool showText, PrefabReference textAssetId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

