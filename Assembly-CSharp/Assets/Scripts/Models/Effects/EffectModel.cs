namespace Assets.Scripts.Models.Effects;

public class EffectModel : Model
{
	public PrefabReference assetId; //Field offset: 0x30
	public float scale; //Field offset: 0x38
	public float lifespan; //Field offset: 0x3C
	public Fullscreen fullscreen; //Field offset: 0x40
	public bool useCenterPosition; //Field offset: 0x44
	public bool useTransformPosition; //Field offset: 0x45
	public bool useTransfromRotation; //Field offset: 0x46
	public bool destroyOnTransformDestroy; //Field offset: 0x47
	public bool alwaysUseAge; //Field offset: 0x48
	public bool useRoundTime; //Field offset: 0x49

	public EffectModel(string id, PrefabReference assetId, float scale, float lifespan, Fullscreen fullscreen, bool useCenterPosition, bool useTransformPosition, bool useTransfromRotation, bool destroyOnTransformDestroy, bool alwaysUseAge, bool useRoundTime) { }

	public EffectModel(string id, PrefabReference assetId, float scale, float lifespan) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

