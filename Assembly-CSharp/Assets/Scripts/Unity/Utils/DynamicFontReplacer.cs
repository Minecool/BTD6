namespace Assets.Scripts.Unity.Utils;

public class DynamicFontReplacer : MonoBehaviour
{
	[CompilerGenerated]
	private struct <UpdateTextObjectFontAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TMP_Text textObj; //Field offset: 0x20
		public DynamicFontReplacer <>4__this; //Field offset: 0x28
		private Material <oldMaterial>5__2; //Field offset: 0x30
		private bool <usesFontMaterial>5__3; //Field offset: 0x38
		private TaskAwaiter<TMP_FontAsset> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kDynamicFontFolder = "DynamicFonts"; //Field offset: 0x0
	private AsyncOperationHandle<TMP_FontAsset> fontHandle; //Field offset: 0x20

	public DynamicFontReplacer() { }

	private void Awake() { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<UpdateTextObjectFontAsync>d__4))]
	private Task UpdateTextObjectFontAsync(TMP_Text textObj) { }

}

