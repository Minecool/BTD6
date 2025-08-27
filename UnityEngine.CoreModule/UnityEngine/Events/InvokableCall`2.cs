namespace UnityEngine.Events;

internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UnityAction<T1, T2> Delegate; //Field offset: 0x0

	public InvokableCall`2(object target, MethodInfo theFunction) { }

	public virtual bool Find(object targetObj, MethodInfo method) { }

	public virtual void Invoke(Object[] args) { }

	public void Invoke(T1 args0, T2 args1) { }

}

