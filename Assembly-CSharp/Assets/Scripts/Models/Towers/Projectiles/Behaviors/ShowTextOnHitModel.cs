namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ShowTextOnHit), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ShowTextOnHitModel : ProjectileBehaviorModel
{
	public PrefabReference assetId; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40
	public bool useTowerPosition; //Field offset: 0x44
	public string text; //Field offset: 0x48

	public ShowTextOnHitModel(string name, PrefabReference assetId, float lifespan, bool useTowerPosition, string text) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

