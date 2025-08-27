namespace NinjaKiwi.LiNK.Exceptions;

[DataContract]
public class InvalidRequestException : InternetException
{
	[DataContract]
	internal class DetailsField
	{
		[DataMember(Name = "reason")]
		public string reason; //Field offset: 0x10
		[DataMember(Name = "fix")]
		public string fix; //Field offset: 0x18

		public DetailsField() { }

	}

	[DataContract]
	internal class Issue
	{
		[DataMember(Name = "param")]
		public string parameter; //Field offset: 0x10
		[DataMember(Name = "msg")]
		public string message; //Field offset: 0x18

		public Issue() { }

		public virtual string ToString() { }

	}

	[DataMember(Name = "type")]
	public readonly string type; //Field offset: 0xA0
	[DataMember(Name = "account")]
	public readonly string account; //Field offset: 0xA8
	[DataMember(Name = "details")]
	public readonly DetailsField details; //Field offset: 0xB0
	[CompilerGenerated]
	private Issue[] <Issues>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0xC0

	[DataMember(Name = "description")]
	public private string Description
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[DataMember(Name = "issues")]
	public private Issue[] Issues
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public virtual string Message
	{
		 get { } //Length: 513
	}

	protected private InvalidRequestException() { }

	private static string ArrayToString(T[] array) { }

	[CompilerGenerated]
	public string get_Description() { }

	[CompilerGenerated]
	public Issue[] get_Issues() { }

	public virtual string get_Message() { }

	[CompilerGenerated]
	private void set_Description(string value) { }

	[CompilerGenerated]
	private void set_Issues(Issue[] value) { }

	[OnDeserialized]
	internal void Validate(StreamingContext context) { }

}

