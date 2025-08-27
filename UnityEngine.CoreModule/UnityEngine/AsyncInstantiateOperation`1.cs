namespace UnityEngine;

[ExcludeFromDocs]
public class AsyncInstantiateOperation : CustomYieldInstruction
{
	internal AsyncInstantiateOperation m_op; //Field offset: 0x0

	public virtual bool keepWaiting
	{
		 get { } //Length: 32
	}

	internal AsyncInstantiateOperation`1(AsyncInstantiateOperation op) { }

	public virtual bool get_keepWaiting() { }

}

