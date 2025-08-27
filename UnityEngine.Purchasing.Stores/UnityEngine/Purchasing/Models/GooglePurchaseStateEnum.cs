namespace UnityEngine.Purchasing.Models;

internal static class GooglePurchaseStateEnum
{
	private static Nullable<Int32> s_Purchased; //Field offset: 0x0
	private static Nullable<Int32> s_Pending; //Field offset: 0x8

	private static AndroidJavaObject GetPurchaseStateJavaObject() { }

	internal static int Pending() { }

	internal static int Purchased() { }

}

