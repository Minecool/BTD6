namespace UnityEngine.Rendering;

internal sealed class OnCullingCompleteCallback : MulticastDelegate
{

	public OnCullingCompleteCallback(object object, IntPtr method) { }

	public override void Invoke(JobHandle jobHandle, in BatchCullingContext cullingContext, in BatchCullingOutput cullingOutput) { }

}

