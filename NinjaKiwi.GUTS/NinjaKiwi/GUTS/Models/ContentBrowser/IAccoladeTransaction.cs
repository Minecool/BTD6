namespace NinjaKiwi.GUTS.Models.ContentBrowser;

public interface IAccoladeTransaction
{

	public string AccoladeId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string ContentId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ContentType ContentType
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public DateTime CreationTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string FromUserId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public long Id
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int Quantity
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string ToUserId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string get_AccoladeId() { }

	public string get_ContentId() { }

	public ContentType get_ContentType() { }

	public DateTime get_CreationTime() { }

	public string get_FromUserId() { }

	public long get_Id() { }

	public int get_Quantity() { }

	public string get_ToUserId() { }

	public void set_AccoladeId(string value) { }

	public void set_ContentId(string value) { }

	public void set_ContentType(ContentType value) { }

	public void set_CreationTime(DateTime value) { }

	public void set_FromUserId(string value) { }

	public void set_Id(long value) { }

	public void set_Quantity(int value) { }

	public void set_ToUserId(string value) { }

}

