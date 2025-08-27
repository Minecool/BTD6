namespace NinjaKiwi.GUTS.Models.ContentBrowser;

public class AccoladeTransaction : IAccoladeTransaction, IEquatable<AccoladeTransaction>
{
	[CompilerGenerated]
	private long <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <FromUserId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ToUserId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ContentType <ContentType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <ContentId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <AccoladeId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <Quantity>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private DateTime <CreationTime>k__BackingField; //Field offset: 0x48

	public override string AccoladeId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override string ContentId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override ContentType ContentType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override DateTime CreationTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override string FromUserId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override long Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override int Quantity
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override string ToUserId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public AccoladeTransaction() { }

	public override bool Equals(AccoladeTransaction other) { }

	public virtual bool Equals(object other) { }

	[CompilerGenerated]
	public override string get_AccoladeId() { }

	[CompilerGenerated]
	public override string get_ContentId() { }

	[CompilerGenerated]
	public override ContentType get_ContentType() { }

	[CompilerGenerated]
	public override DateTime get_CreationTime() { }

	[CompilerGenerated]
	public override string get_FromUserId() { }

	[CompilerGenerated]
	public override long get_Id() { }

	[CompilerGenerated]
	public override int get_Quantity() { }

	[CompilerGenerated]
	public override string get_ToUserId() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public override void set_AccoladeId(string value) { }

	[CompilerGenerated]
	public override void set_ContentId(string value) { }

	[CompilerGenerated]
	public override void set_ContentType(ContentType value) { }

	[CompilerGenerated]
	public override void set_CreationTime(DateTime value) { }

	[CompilerGenerated]
	public override void set_FromUserId(string value) { }

	[CompilerGenerated]
	public override void set_Id(long value) { }

	[CompilerGenerated]
	public override void set_Quantity(int value) { }

	[CompilerGenerated]
	public override void set_ToUserId(string value) { }

}

