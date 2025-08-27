namespace Unity.Services.Analytics.Internal;

internal class BufferX : IBuffer
{
	private readonly Byte[] k_WorkingBuffer; //Field offset: 0x10
	private readonly Char[] k_WorkingCharacterBuffer; //Field offset: 0x18
	private readonly Byte[] k_BufferHeader; //Field offset: 0x20
	private readonly Byte[] k_HeaderEventName; //Field offset: 0x28
	private readonly Byte[] k_HeaderUserName; //Field offset: 0x30
	private readonly Byte[] k_HeaderSessionID; //Field offset: 0x38
	private readonly Byte[] k_HeaderEventUUID; //Field offset: 0x40
	private readonly Byte[] k_HeaderTimestamp; //Field offset: 0x48
	private readonly Byte[] k_HeaderEventVersion; //Field offset: 0x50
	private readonly Byte[] k_HeaderInstallationID; //Field offset: 0x58
	private readonly Byte[] k_HeaderPlayerID; //Field offset: 0x60
	private readonly Byte[] k_HeaderOpenEventParams; //Field offset: 0x68
	private readonly Byte[] k_CloseEvent; //Field offset: 0x70
	private readonly byte k_Quote; //Field offset: 0x78
	private readonly Byte[] k_QuoteColon; //Field offset: 0x80
	private readonly Byte[] k_QuoteComma; //Field offset: 0x88
	private readonly Byte[] k_Comma; //Field offset: 0x90
	private readonly Byte[] k_OpenBrace; //Field offset: 0x98
	private readonly Byte[] k_CloseBraceComma; //Field offset: 0xA0
	private readonly Byte[] k_OpenBracket; //Field offset: 0xA8
	private readonly Byte[] k_CloseBracketComma; //Field offset: 0xB0
	private readonly Byte[] k_True; //Field offset: 0xB8
	private readonly Byte[] k_False; //Field offset: 0xC0
	private readonly IBufferSystemCalls m_SystemCalls; //Field offset: 0xC8
	private readonly IDiskCache m_DiskCache; //Field offset: 0xD0
	private IBufferIds m_Ids; //Field offset: 0xD8
	private readonly List<Int32> m_EventEnds; //Field offset: 0xE0
	private MemoryStream m_SpareBuffer; //Field offset: 0xE8
	private MemoryStream m_Buffer; //Field offset: 0xF0

	public override int Length
	{
		 get { } //Length: 45
	}

	public BufferX(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache) { }

	public override void ClearBuffer(long upTo) { }

	public override void ClearBuffer() { }

	public override void ClearDiskCache() { }

	public override void FlushToDisk() { }

	public override int get_Length() { }

	public void InjectIds(IBufferIds ids) { }

	public override void PushArrayEnd() { }

	public override void PushArrayStart(string name) { }

	public override void PushBool(bool val, string name = null) { }

	public override void PushDouble(double val, string name = null) { }

	public override void PushEndEvent() { }

	public override void PushFloat(float val, string name = null) { }

	public override void PushInt(int val, string name = null) { }

	public override void PushInt64(long val, string name = null) { }

	public override void PushObjectEnd() { }

	public override void PushObjectStart(string name = null) { }

	public override void PushStartEvent(string name, DateTime datetime, Nullable<Int64> eventVersion, bool addPlayerIdsToEventBody) { }

	public override void PushString(string value, string name = null) { }

	public override void PushTimestamp(DateTime val, string name) { }

	public override Byte[] Serialize() { }

	internal static string SerializeDateTime(DateTime dateTime) { }

	private void StripTrailingCommaIfNecessary() { }

	private void WriteByte(in byte value) { }

	private void WriteBytes(in Byte[] bytes) { }

	private void WriteName(string name) { }

	private void WriteString(in string value) { }

}

