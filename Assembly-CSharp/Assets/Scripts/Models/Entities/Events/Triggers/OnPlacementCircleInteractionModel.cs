namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnPlacementCircleInteraction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnPlacementCircleInteractionModel : EntityTriggerModel
{
	public String[] placementIdsToCheck; //Field offset: 0x38
	public bool requireTowerPlacedInCircle; //Field offset: 0x40

	public OnPlacementCircleInteractionModel(string name, String[] placementIdsToCheck, bool requireTowerPlacedInCircle = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

