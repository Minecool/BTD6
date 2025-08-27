namespace NinjaKiwi.LiNK.Endpoints;

public class MyNK_GetUserInventory : Endpoint<MyNK_ItemModel[]>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<<>f__AnonymousType76`12<Int32, Int32, String, String, String, Int32, Int32, Int32, Int32, Int32, String, String>, MyNK_ItemModel> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal MyNK_ItemModel <Receive>b__2_0(<>f__AnonymousType762<Int32, Int32, String, String, String, Int32, Int32, Int32, Int32, Int32, String, String> item) { }

	}


	internal MyNK_GetUserInventory(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<MyNK_ItemModel[]> Call(string userID, string gameName) { }

	protected virtual MyNK_ItemModel[] Receive(string json) { }

}

