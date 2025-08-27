namespace Newtonsoft.Json.Converters;

[NullableContext(2)]
internal interface IXmlDeclaration : IXmlNode
{

	public string Encoding
	{
		 get { } //Length: 0
	}

	public string Standalone
	{
		 get { } //Length: 0
	}

	public string Version
	{
		 get { } //Length: 0
	}

	public string get_Encoding() { }

	public string get_Standalone() { }

	public string get_Version() { }

}

