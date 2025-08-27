namespace NinjaKiwi.Common.ResourceUtils;

public class ResourceReleaser : MonoBehaviour, IResourceReleaser
{
	private static Dictionary<String, List`1<IResourceReleaser>> trackedReleasers; //Field offset: 0x0
	[CompilerGenerated]
	private AsyncOperationHandle<T> <toRelease>k__BackingField; //Field offset: 0x0
	public Action<AsyncOperationHandle`1<T>> onLoadHandler; //Field offset: 0x0

	public private AsyncOperationHandle<T> toRelease
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public ResourceReleaser`1() { }

	[CompilerGenerated]
	public AsyncOperationHandle<T> get_toRelease() { }

	private override void NinjaKiwi.Common.ResourceUtils.IResourceReleaser.Release() { }

	private void OnDestroy() { }

	public void ReleaseOnDestroy(AsyncOperationHandle<T> toRelease) { }

	private static void SceneUnloaded(Scene scene) { }

	[CompilerGenerated]
	private void set_toRelease(AsyncOperationHandle<T> value) { }

}

