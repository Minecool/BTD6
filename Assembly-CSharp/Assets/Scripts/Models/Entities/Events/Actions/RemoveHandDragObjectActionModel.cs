namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(RemoveHandDragObjectAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveHandDragObjectActionModel : EntityActionModel
{
	public string placementId; //Field offset: 0x38

	public RemoveHandDragObjectActionModel(string name, string placementId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

