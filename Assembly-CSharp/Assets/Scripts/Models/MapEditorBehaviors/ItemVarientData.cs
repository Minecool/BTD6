namespace Assets.Scripts.Models.MapEditorBehaviors;

public struct ItemVarientData : IEquatable<ItemVarientData>
{
	public string groupId; //Field offset: 0x0
	public int numVarients; //Field offset: 0x8
	public bool isPrimaryVarient; //Field offset: 0xC

	[IsReadOnly]
	public override bool Equals(ItemVarientData other) { }

}

