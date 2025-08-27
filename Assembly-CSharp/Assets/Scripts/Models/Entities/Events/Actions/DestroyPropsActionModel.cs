namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(DestroyPropsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyPropsActionModel : EntityActionModel
{
	public float range; //Field offset: 0x38

	public DestroyPropsActionModel(string name, float range) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

