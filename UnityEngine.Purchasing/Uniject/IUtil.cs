namespace Uniject;

internal interface IUtil
{

	public void AddPauseListener(Action<Boolean> runnable) { }

	public object InitiateCoroutine(IEnumerator start) { }

	public void InitiateCoroutine(IEnumerator start, int delayInSeconds) { }

	public bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant) { }

	public void RunOnMainThread(Action runnable) { }

}

