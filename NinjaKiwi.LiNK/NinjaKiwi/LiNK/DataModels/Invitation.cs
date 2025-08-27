namespace NinjaKiwi.LiNK.DataModels;

public class Invitation
{
	[DataContract]
	public class Model
	{
		internal class MemberData
		{
			[DataMember(Name = "uuid")]
			public string uuid; //Field offset: 0x10
			[DataMember(Name = "inviter")]
			public string inviter; //Field offset: 0x18
			[DataMember(Name = "metadata")]
			public string metadata; //Field offset: 0x20

			public MemberData() { }

		}

		private static readonly DateTime jan1970; //Field offset: 0x0
		[DataMember(Name = "createdAt")]
		public long createdAt; //Field offset: 0x10
		[DataMember(Name = "memberData")]
		public MemberData memberData; //Field offset: 0x18

		private static Model() { }

		public Model() { }

		public Invitation ToInvitation(string type) { }

	}

	public readonly string invitationId; //Field offset: 0x10
	public readonly string inviterId; //Field offset: 0x18
	public readonly string metadata; //Field offset: 0x20
	public readonly string type; //Field offset: 0x28
	public readonly DateTime createdAt; //Field offset: 0x30

	public Invitation(string invitationId, string inviterId, string metadata, string type, DateTime createdAt) { }

}

