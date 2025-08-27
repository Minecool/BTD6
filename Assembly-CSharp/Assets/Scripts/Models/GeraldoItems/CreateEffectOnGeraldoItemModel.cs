namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(CreateEffectOnGeraldoItem), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnGeraldoItemModel : GeraldoItemBehaviorModel
{
	public PrefabReference effectId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public bool fullScreen; //Field offset: 0x3C
	public bool useCenterPosition; //Field offset: 0x3D

	public CreateEffectOnGeraldoItemModel(string name, PrefabReference effectId, float lifespan, bool fullScreen, bool useCenterPosition) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

