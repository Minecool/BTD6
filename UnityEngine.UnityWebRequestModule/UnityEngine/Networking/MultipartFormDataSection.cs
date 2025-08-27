namespace UnityEngine.Networking;

public class MultipartFormDataSection : IMultipartFormSection
{
	private string name; //Field offset: 0x10
	private Byte[] data; //Field offset: 0x18
	private string content; //Field offset: 0x20

	public override string contentType
	{
		 get { } //Length: 159
	}

	public override string fileName
	{
		 get { } //Length: 5
	}

	public override Byte[] sectionData
	{
		 get { } //Length: 7
	}

	public override string sectionName
	{
		 get { } //Length: 7
	}

	public MultipartFormDataSection(string name, string data, Encoding encoding, string contentType) { }

	public MultipartFormDataSection(string name, string data, string contentType) { }

	public MultipartFormDataSection(string name, string data) { }

	public MultipartFormDataSection(string data) { }

	public override string get_contentType() { }

	public override string get_fileName() { }

	public override Byte[] get_sectionData() { }

	public override string get_sectionName() { }

}

