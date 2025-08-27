namespace System.Runtime.Remoting.Messaging;

internal class IllogicalCallContext
{
	private Hashtable m_Datastore; //Field offset: 0x10
	private object m_HostContext; //Field offset: 0x18

	private Hashtable Datastore
	{
		private get { } //Length: 102
	}

	internal bool HasUserData
	{
		internal get { } //Length: 49
	}

	internal object HostContext
	{
		internal get { } //Length: 5
		internal set { } //Length: 5
	}

	public IllogicalCallContext() { }

	public IllogicalCallContext CreateCopy() { }

	public void FreeNamedDataSlot(string name) { }

	private Hashtable get_Datastore() { }

	internal bool get_HasUserData() { }

	internal object get_HostContext() { }

	internal void set_HostContext(object value) { }

}

