namespace UnityEngine.Rendering;

[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
[RequireComponent(typeof(Transform))]
public sealed class SortingGroup : Behaviour
{

	internal int index
	{
		internal get { } //Length: 119
	}

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	internal static int invalidSortingGroupID
	{
		internal get { } //Length: 42
	}

	public bool sortAtRoot
	{
		 get { } //Length: 119
		 set { } //Length: 135
	}

	internal int sortingGroupID
	{
		internal get { } //Length: 119
	}

	internal int sortingGroupOrder
	{
		internal get { } //Length: 119
	}

	internal uint sortingKey
	{
		internal get { } //Length: 119
	}

	public int sortingLayerID
	{
		 get { } //Length: 119
		 set { } //Length: 132
	}

	public string sortingLayerName
	{
		 get { } //Length: 216
		 set { } //Length: 398
	}

	public int sortingOrder
	{
		 get { } //Length: 119
		 set { } //Length: 132
	}

	public SortingGroup() { }

	internal int get_index() { }

	private static int get_index_Injected(IntPtr _unity_self) { }

	internal static int get_invalidSortingGroupID() { }

	public bool get_sortAtRoot() { }

	private static bool get_sortAtRoot_Injected(IntPtr _unity_self) { }

	internal int get_sortingGroupID() { }

	private static int get_sortingGroupID_Injected(IntPtr _unity_self) { }

	internal int get_sortingGroupOrder() { }

	private static int get_sortingGroupOrder_Injected(IntPtr _unity_self) { }

	internal uint get_sortingKey() { }

	private static uint get_sortingKey_Injected(IntPtr _unity_self) { }

	public int get_sortingLayerID() { }

	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	public string get_sortingLayerName() { }

	private static void get_sortingLayerName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public int get_sortingOrder() { }

	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

	private static IntPtr GetSortingGroupByIndex_Injected(int index) { }

	public void set_sortAtRoot(bool value) { }

	private static void set_sortAtRoot_Injected(IntPtr _unity_self, bool value) { }

	public void set_sortingLayerID(int value) { }

	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	public void set_sortingLayerName(string value) { }

	private static void set_sortingLayerName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_sortingOrder(int value) { }

	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	public static void UpdateAllSortingGroups() { }

}

