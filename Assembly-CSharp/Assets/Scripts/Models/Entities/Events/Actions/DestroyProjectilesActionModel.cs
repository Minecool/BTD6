namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(DestroyProjectilesAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyProjectilesActionModel : EntityActionModel
{
	public float range; //Field offset: 0x38

	public DestroyProjectilesActionModel(string name, float range) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

