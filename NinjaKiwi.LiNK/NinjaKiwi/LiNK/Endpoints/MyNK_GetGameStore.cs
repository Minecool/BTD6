namespace NinjaKiwi.LiNK.Endpoints;

public class MyNK_GetGameStore : Endpoint<MyNK_ItemModel[]>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<<>f__AnonymousType70`12<Int32, Int32, String, String, String, Int32, Int32, Int32, Int32, Int32, Int32, String>, MyNK_ItemModel> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal MyNK_ItemModel <Receive>b__2_0(<>f__AnonymousType702<Int32, Int32, String, String, String, Int32, Int32, Int32, Int32, Int32, Int32, String> item) { }

	}


	internal MyNK_GetGameStore(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<MyNK_ItemModel[]> Call(string gameName) { }

	protected virtual MyNK_ItemModel[] Receive(string json) { }

}

