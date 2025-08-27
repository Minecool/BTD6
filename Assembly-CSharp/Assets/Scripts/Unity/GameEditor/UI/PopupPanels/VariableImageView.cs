namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class VariableImageView : VariableView<VariableViewModel`1<IAssetReference>>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public VariableImageView <>4__this; //Field offset: 0x10
		public VariableViewModel<SpriteReference> <spriteVM>5__2; //Field offset: 0x18
		public VariableViewModel<PrefabReference> <prefabVM>5__3; //Field offset: 0x20
		public VariableViewModel<AudioClipReference> <audioClipVM>5__4; //Field offset: 0x28

		public <>c__DisplayClass2_0() { }

		internal void <Bind>b__0() { }

		internal void <Bind>b__1() { }

		internal void <Bind>b__2() { }

	}

	[CompilerGenerated]
	private struct <ChangeAudio>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public VariableViewModel<AudioClipReference> audioClipViewModel; //Field offset: 0x28
		public VariableImageView <>4__this; //Field offset: 0x30
		private TaskAwaiter<Entry<BTD6AssetFlags>> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeDisplay>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public VariableViewModel<PrefabReference> prefabViewModel; //Field offset: 0x28
		public VariableImageView <>4__this; //Field offset: 0x30
		private TaskAwaiter<Entry<BTD6AssetFlags>> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeImage>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public VariableViewModel<SpriteReference> spriteViewModel; //Field offset: 0x28
		public VariableImageView <>4__this; //Field offset: 0x30
		private TaskAwaiter<Entry<BTD6AssetFlags>> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetDisplay>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public VariableViewModel<T> viewModel; //Field offset: 0x0
		public VariableImageView <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image variableImage; //Field offset: 0x40
	public Button changeImageButton; //Field offset: 0x48

	public VariableImageView() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	[AsyncStateMachine(typeof(<ChangeAudio>d__5))]
	private void ChangeAudio(VariableViewModel<AudioClipReference> audioClipViewModel) { }

	[AsyncStateMachine(typeof(<ChangeDisplay>d__4))]
	private void ChangeDisplay(VariableViewModel<PrefabReference> prefabViewModel) { }

	[AsyncStateMachine(typeof(<ChangeImage>d__3))]
	private void ChangeImage(VariableViewModel<SpriteReference> spriteViewModel) { }

	protected virtual void OnUpdateView() { }

	protected virtual void OnValueChanged() { }

	[AsyncStateMachine(typeof(<SetDisplay>d__6`1))]
	private Task SetDisplay(VariableViewModel<T> viewModel) { }

}

