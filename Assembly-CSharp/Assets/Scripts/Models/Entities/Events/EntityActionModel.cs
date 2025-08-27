namespace Assets.Scripts.Models.Entities.Events;

[Implementation(typeof(EntityAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EntityActionModel : EntityBehaviorModel
{
	public int entityEventIndex; //Field offset: 0x30

	public EntityActionModel(string name, int entityEventIndex = -1) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

