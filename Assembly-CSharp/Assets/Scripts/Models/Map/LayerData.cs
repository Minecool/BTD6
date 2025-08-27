namespace Assets.Scripts.Models.Map;

public struct LayerData
{
	public LayerType layerType; //Field offset: 0x0
	public int categoryLayerIndex; //Field offset: 0x4

	[IsReadOnly]
	public bool Contains(int layerId) { }

	[IsReadOnly]
	public bool IsEqual(LayerData other) { }

}

