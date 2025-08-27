namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(RemovePlacementCircleAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemovePlacementCircleActionModel : EntityActionModel
{
	public string placementId; //Field offset: 0x38

	public RemovePlacementCircleActionModel(string name, string placementId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

