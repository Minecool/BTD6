namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(SpawnEffectAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnEffectActionModel : EntityActionModel
{
	public PrefabReference prefabReference; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40

	public SpawnEffectActionModel(string name, PrefabReference prefabReference, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

