namespace System.Globalization;

internal class CodePageDataItem
{
	private static readonly Char[] sep; //Field offset: 0x0
	internal int m_dataIndex; //Field offset: 0x10
	internal int m_uiFamilyCodePage; //Field offset: 0x14
	internal string m_webName; //Field offset: 0x18
	internal string m_headerName; //Field offset: 0x20
	internal uint m_flags; //Field offset: 0x28

	public string HeaderName
	{
		 get { } //Length: 191
	}

	public string WebName
	{
		 get { } //Length: 189
	}

	private static CodePageDataItem() { }

	internal CodePageDataItem(int dataIndex) { }

	internal static string CreateString(string pStrings, uint index) { }

	public string get_HeaderName() { }

	public string get_WebName() { }

}

