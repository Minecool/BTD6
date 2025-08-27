namespace NinjaKiwi.LiNK.DataModels;

public class LobbyInviteModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<<>f__AnonymousType1`3<String, String, <>f__AnonymousType2`2<Int64, <>f__AnonymousType3`2<String, String>>[]>, IEnumerable`1<<>f__AnonymousType2`2<Int64, <>f__AnonymousType3`2<String, String>>>> <>9__6_0; //Field offset: 0x8
		public static Func<<>f__AnonymousType1`3<String, String, <>f__AnonymousType2`2<Int64, <>f__AnonymousType3`2<String, String>>[]>, <>f__AnonymousType2`2<Int64, <>f__AnonymousType3`2<String, String>>, LobbyInviteModel> <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<<>f__AnonymousType2`2<Int64, <>f__AnonymousType3`2<String, String>>> <DeserialiseLiNKResponse>b__6_0(<>f__AnonymousType1<String, String, <>f__AnonymousType2`2<Int64, <>f__AnonymousType3`2<String, String>>[]> provider) { }

		internal LobbyInviteModel <DeserialiseLiNKResponse>b__6_1(<>f__AnonymousType1<String, String, <>f__AnonymousType2`2<Int64, <>f__AnonymousType3`2<String, String>>[]> provider, <>f__AnonymousType2<Int64, <>f__AnonymousType3`2<String, String>> invite) { }

	}

	internal enum InviteType
	{
		PRIVATE = 0,
		PUBLIC = 1,
	}

	private static readonly DateTime jan1970; //Field offset: 0x0
	public string lobbyID; //Field offset: 0x10
	public string metadata; //Field offset: 0x18
	public DateTime createdAt; //Field offset: 0x20
	public string recipientProviderID; //Field offset: 0x28
	public InviteType type; //Field offset: 0x30

	private static LobbyInviteModel() { }

	public LobbyInviteModel() { }

	public static IEnumerable<LobbyInviteModel> DeserialiseLiNKResponse(string json) { }

}

