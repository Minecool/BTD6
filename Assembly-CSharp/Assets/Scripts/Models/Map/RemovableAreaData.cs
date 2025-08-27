namespace Assets.Scripts.Models.Map;

public struct RemovableAreaData
{
	public int removeableCost; //Field offset: 0x0
	public LayerData[] removableOnTriggerLayerIds; //Field offset: 0x8
	public LayerData[] removableOnShowLayerIds; //Field offset: 0x10
	public LayerData[] removableOnHideLayerIds; //Field offset: 0x18

	[IsReadOnly]
	public bool ContainsLayerData(LayerData layerData) { }

	[IsReadOnly]
	public LayerData[] GetRemovableLayerIds(RemoveableTypeGroup group) { }

	[IsReadOnly]
	public bool IsEqual(RemovableAreaData other) { }

	[IsReadOnly]
	public bool IsValid() { }

}

