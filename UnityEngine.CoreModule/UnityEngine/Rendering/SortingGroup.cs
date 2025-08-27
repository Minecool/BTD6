namespace UnityEngine.Rendering;

[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
[RequireComponent(typeof(Transform))]
public sealed class SortingGroup : Behaviour
{

	internal int index
	{
		internal get { } //Length: 51
	}

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	internal static int invalidSortingGroupID
	{
		internal get { } //Length: 42
	}

	public bool sortAtRoot
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	internal int sortingGroupID
	{
		internal get { } //Length: 51
	}

	internal int sortingGroupOrder
	{
		internal get { } //Length: 51
	}

	internal uint sortingKey
	{
		internal get { } //Length: 51
	}

	public int sortingLayerID
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public string sortingLayerName
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int sortingOrder
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public SortingGroup() { }

	internal int get_index() { }

	internal static int get_invalidSortingGroupID() { }

	public bool get_sortAtRoot() { }

	internal int get_sortingGroupID() { }

	internal int get_sortingGroupOrder() { }

	internal uint get_sortingKey() { }

	public int get_sortingLayerID() { }

	public string get_sortingLayerName() { }

	public int get_sortingOrder() { }

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

	public void set_sortAtRoot(bool value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	public static void UpdateAllSortingGroups() { }

}

