namespace Unity.Services.Analytics.Internal;

internal interface IBuffer
{

	public int Length
	{
		 get { } //Length: 0
	}

	public void ClearBuffer(long upTo) { }

	public void ClearBuffer() { }

	public void ClearDiskCache() { }

	public void FlushToDisk() { }

	public int get_Length() { }

	public void PushArrayEnd() { }

	public void PushArrayStart(string name) { }

	public void PushBool(bool val, string name = null) { }

	public void PushDouble(double val, string name = null) { }

	public void PushEndEvent() { }

	public void PushFloat(float val, string name = null) { }

	public void PushInt(int val, string name = null) { }

	public void PushInt64(long val, string name = null) { }

	public void PushObjectEnd() { }

	public void PushObjectStart(string name = null) { }

	public void PushStartEvent(string name, DateTime datetime, Nullable<Int64> eventVersion, bool addPlayerIdsToEventBody = false) { }

	public void PushString(string val, string name = null) { }

	public void PushTimestamp(DateTime val, string name = null) { }

	public Byte[] Serialize() { }

}

