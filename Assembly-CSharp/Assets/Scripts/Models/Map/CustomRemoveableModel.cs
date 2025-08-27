namespace Assets.Scripts.Models.Map;

[Implementation(typeof(CustomRemoveable), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CustomRemoveableModel : RemoveableModel
{
	public RemovableAreaData removeableAreaData; //Field offset: 0xA8
	public int onTriggerFramesToWait; //Field offset: 0xC8

	public CustomRemoveableModel(string name, string objecName, bool isActive, AreaType defaultType, int removealCost, string menuName, string menuDescription, Vector3 position, bool denySellIfStackedTowers, bool destroyArea, string textKey, string modPathId, Nullable<Single> modPathBloonHeightOffset, Nullable<Single> modPathMoabHeightOffset, Nullable<Single> modPathBloonScale, Nullable<Single> modPathMoabScale, Nullable<Boolean> modPathBloonInvulnerability, Nullable<Boolean> modPathMoabInvulnerability, RemovableAreaData removeableAreaData, int onTriggerFramesToWait) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

