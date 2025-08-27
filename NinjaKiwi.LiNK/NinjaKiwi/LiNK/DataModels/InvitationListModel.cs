namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
internal class InvitationListModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, InvitationCategoryList>, IEnumerable`1<Model>> <>9__2_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, InvitationCategoryList>, Model, Invitation> <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Model> <ToList>b__2_0(KeyValuePair<String, InvitationCategoryList> kvp) { }

		internal Invitation <ToList>b__2_1(KeyValuePair<String, InvitationCategoryList> kvp, Model invitationModel) { }

	}

	internal class InvitationCategoryList
	{
		[DataMember(Name = "providerId")]
		public string providerId; //Field offset: 0x10
		[DataMember(Name = "type")]
		public string type; //Field offset: 0x18
		[DataMember(Name = "invites")]
		public List<Model> invites; //Field offset: 0x20

		public InvitationCategoryList() { }

	}

	[DataMember(Name = "invites")]
	public Dictionary<String, InvitationCategoryList> invites; //Field offset: 0x10

	public InvitationListModel() { }

	public List<Invitation> ToList() { }

}

