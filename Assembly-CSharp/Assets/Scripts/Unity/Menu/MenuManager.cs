namespace Assets.Scripts.Unity.Menu;

public class MenuManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menuData"}])]
		public static Func<ValueTuple`2<String, Object>, Boolean> <>9__54_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <LoadMainMenu>b__54_0(ValueTuple<String, Object> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass55_0() { }

		internal bool <HasWorldOverride>b__0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass63_0() { }

		internal bool <QueueMenu>b__0(ValueTuple<String, Object> i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public MenuManager <>4__this; //Field offset: 0x10
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menu", "menuStatus"}])]
		public ValueTuple<String, GameMenu, MenuStatus> previousMenu; //Field offset: 0x18

		public <>c__DisplayClass67_0() { }

		internal void <OpenMenuInternal>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public GameMenu menu; //Field offset: 0x10

		public <>c__DisplayClass68_0() { }

		internal bool <Open>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public MenuManager <>4__this; //Field offset: 0x10
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menu", "menuStatus"}])]
		public ValueTuple<String, GameMenu, MenuStatus> closingMenu; //Field offset: 0x18

		public <>c__DisplayClass72_0() { }

		internal void <CloseCurrentMenuInternal>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public GameMenu menu; //Field offset: 0x10

		public <>c__DisplayClass73_0() { }

		internal bool <ReOpen>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		private sealed class <<ForceCloseMenu>g__froceCloseMenuAndSubmenus|1>d : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public <>c__DisplayClass75_0 <>4__this; //Field offset: 0x20

			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			[DebuggerHidden]
			public <<ForceCloseMenu>g__froceCloseMenuAndSubmenus|1>d(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public string menuName; //Field offset: 0x10
		public MenuManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass75_0() { }

		internal bool <ForceCloseMenu>b__0(ValueTuple<String, Object> o) { }

		internal void <ForceCloseMenu>b__2() { }

		[IteratorStateMachine(typeof(<<ForceCloseMenu>g__froceCloseMenuAndSubmenus|1>d))]
		internal IEnumerator <ForceCloseMenu>g__froceCloseMenuAndSubmenus|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass88_0() { }

		internal bool <IsMenuOnStack>b__0(ValueTuple<String, Object> m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass89_0() { }

		internal bool <IsMenuOnQueue>b__0(ValueTuple<String, Object> m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass90_0() { }

		internal bool <RemoveMenuFromStack>b__0(ValueTuple<String, Object> o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass95_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass95_0() { }

		internal bool <GetMenuData>b__0(ValueTuple<String, Object> m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public string menuName; //Field offset: 0x10

		public <>c__DisplayClass96_0() { }

		internal bool <SetMenuData>b__0(ValueTuple<String, Object> m) { }

	}

	[CompilerGenerated]
	private sealed class <CloseCurrentMenuIfPossible>d__71 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public string menuToClose; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CloseCurrentMenuIfPossible>d__71(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <CloseCurrentMenuInternal>d__72 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public string menuToClose; //Field offset: 0x28
		private <>c__DisplayClass72_0 <>8__1; //Field offset: 0x30
		private string <menuName>5__2; //Field offset: 0x38
		private object <menuData>5__3; //Field offset: 0x40
		private bool <alreadyLoaded>5__4; //Field offset: 0x48

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CloseCurrentMenuInternal>d__72(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <CloseLoadingScreen>d__62 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		private AnimatedSceneLoader<LoadingScreen> <closingScreen>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CloseLoadingScreen>d__62(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <EnsureCorrectWorldScene>d__57 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menuData"}])]
		public List<ValueTuple`2<String, Object>> menuStack; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <EnsureCorrectWorldScene>d__57(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadInGame>d__52 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadInGame>d__52(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadMainMenu>d__54 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public bool loadPrevMenuStackHistory; //Field offset: 0x28
		private bool <requiresUnload>5__2; //Field offset: 0x29
		private string <trackName>5__3; //Field offset: 0x30
		private string <menuNameToOpen>5__4; //Field offset: 0x38
		private object <menuDataToOpen>5__5; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadMainMenu>d__54(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadSceneAsync>d__49 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public string sceneName; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadSceneAsync>d__49(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadWorldScene>d__60 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public string newWorldScene; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadWorldScene>d__60(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <Open>d__68 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string menuName; //Field offset: 0x20
		public MenuManager <>4__this; //Field offset: 0x28
		public object menuData; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Open>d__68(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <OpenLoadingScreen>d__61 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public bool isLegendsMode; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <OpenLoadingScreen>d__61(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <OpenMenuInternal>d__67 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public string menuName; //Field offset: 0x28
		public object menuData; //Field offset: 0x30
		private <>c__DisplayClass67_0 <>8__1; //Field offset: 0x38

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <OpenMenuInternal>d__67(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ReOpen>d__73 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string menuName; //Field offset: 0x20
		public MenuManager <>4__this; //Field offset: 0x28
		public object menuData; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ReOpen>d__73(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <RunIfNoMenuIsOpening>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MenuManager <>4__this; //Field offset: 0x28
		public Func<Task> openMenuTask; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <UnloadAllDontUnloads>d__76 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public String[] ignores; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <UnloadAllDontUnloads>d__76(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <UnloadInGame>d__53 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <UnloadInGame>d__53(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <UnloadMainMenu>d__51 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		private bool <requiresUnload>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <UnloadMainMenu>d__51(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <UnloadSceneAsync>d__50 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MenuManager <>4__this; //Field offset: 0x20
		public string sceneName; //Field offset: 0x28
		public bool suppressError; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <UnloadSceneAsync>d__50(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private enum MenuStatus
	{
		nonExistant = 0,
		loading = 1,
		unloading = 2,
		ready = 3,
		hidden = 4,
	}

	internal sealed class OnMenuEvent : MulticastDelegate
	{

		public OnMenuEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnPreMainMenuOpening : MulticastDelegate
	{

		public OnPreMainMenuOpening(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class TransitioningDelegate : MulticastDelegate
	{

		public TransitioningDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool transitioning, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool transitioning) { }

	}

	[CompilerGenerated]
	private static MenuManager <instance>k__BackingField; //Field offset: 0x0
	public AudioClip buttonClickSound; //Field offset: 0x20
	public AudioClip buttonClick2Sound; //Field offset: 0x28
	public AudioClip buttonClick3Sound; //Field offset: 0x30
	public AudioClip returnSound; //Field offset: 0x38
	public AudioClip return2Sound; //Field offset: 0x40
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menuData"}])]
	private readonly List<ValueTuple`2<String, Object>> menuStack; //Field offset: 0x48
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menuData"}])]
	private readonly List<ValueTuple`2<String, Object>> menuQueue; //Field offset: 0x50
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menuData"}])]
	private readonly List<ValueTuple`2<String, Object>> menuStackHistory; //Field offset: 0x58
	private readonly List<String> dontUnload; //Field offset: 0x60
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menu", "menuStatus"}])]
	private ValueTuple<String, GameMenu, MenuStatus> currMenu; //Field offset: 0x68
	private bool isIngame; //Field offset: 0x80
	[CompilerGenerated]
	private string <CurrentWorldScene>k__BackingField; //Field offset: 0x88
	public bool hasInitialLoadingFinished; //Field offset: 0x90
	[CompilerGenerated]
	private TransitioningDelegate OnTransitioningChanged; //Field offset: 0x98
	private int transitionLockCount; //Field offset: 0xA0
	private bool isClosingOrOpeningMenu; //Field offset: 0xA4
	private readonly HashSet<String> closeMenuRequests; //Field offset: 0xA8
	private readonly Dictionary<String, OnMenuEvent> onMenusOpened; //Field offset: 0xB0
	private readonly Dictionary<String, OnMenuEvent> onMenusClosed; //Field offset: 0xB8
	private readonly Dictionary<String, AsyncOperationHandle`1<SceneInstance>> sceneInstanceDict; //Field offset: 0xC0
	private Task openingMenuTask; //Field offset: 0xC8
	private UnityEvent temporaryBackEvent; //Field offset: 0xD0
	private bool tempBackEventBound; //Field offset: 0xD8
	private bool canUseLoadingScreenDebug; //Field offset: 0xD9
	private AnimatedSceneLoader<LoadingScreen> loadingScreen; //Field offset: 0xE0
	private bool hasSeenMaintenanceMode; //Field offset: 0xE8

	public event TransitioningDelegate OnTransitioningChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public string CurrentScene
	{
		 get { } //Length: 129
	}

	public private string CurrentWorldScene
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private static MenuManager instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	public private bool IsClosingOrOpeningMenu
	{
		 get { } //Length: 8
		private set { } //Length: 59
	}

	public static bool IsIngame
	{
		 get { } //Length: 191
	}

	public bool IsTransitioning
	{
		 get { } //Length: 23
	}

	public MenuManager() { }

	[CompilerGenerated]
	private bool <GoToMainMenu>b__104_0(ValueTuple<String, Object> x) { }

	[CompilerGenerated]
	public void add_OnTransitioningChanged(TransitioningDelegate value) { }

	public void AddOnMenuClosedEvent(string menuName, OnMenuEvent callback) { }

	public void AddOnMenuOpenedEvent(string menuName, OnMenuEvent callback) { }

	public bool AreOnlyMainMenusOpen() { }

	private void Awake() { }

	public void Back() { }

	public void CloseAllMenus() { }

	public void CloseCurrentMenu() { }

	[IteratorStateMachine(typeof(<CloseCurrentMenuIfPossible>d__71))]
	private IEnumerator CloseCurrentMenuIfPossible(string menuToClose) { }

	[IteratorStateMachine(typeof(<CloseCurrentMenuInternal>d__72))]
	private IEnumerator CloseCurrentMenuInternal(string menuToClose) { }

	[IteratorStateMachine(typeof(<CloseLoadingScreen>d__62))]
	public IEnumerator CloseLoadingScreen() { }

	public void DontUnloadWhileOnStack(string menuName, bool remove = false) { }

	[IteratorStateMachine(typeof(<EnsureCorrectWorldScene>d__57))]
	private IEnumerator EnsureCorrectWorldScene(List<ValueTuple`2<String, Object>> menuStack) { }

	public void FadeOutMusic() { }

	public void ForceCloseMenu(string menuName, bool closeSubMenus = false) { }

	public string get_CurrentScene() { }

	[CompilerGenerated]
	public string get_CurrentWorldScene() { }

	[CompilerGenerated]
	public static MenuManager get_instance() { }

	public bool get_IsClosingOrOpeningMenu() { }

	public static bool get_IsIngame() { }

	public bool get_IsTransitioning() { }

	private T GetComponentInScene(Scene scene) { }

	public GameMenu GetCurrentMenu() { }

	public string GetCurrentMenuName() { }

	public object GetMenuData(string menuName) { }

	public List<ValueTuple`2<String, Object>> GetMenuStack() { }

	public List<ValueTuple`2<String, Object>> GetMenuStackHistory() { }

	public string GetPreviousMenuName() { }

	public void GoToMainMenu() { }

	private static bool HasLoadingSceneOverride(string menuName) { }

	private static bool HasWorldOverride(string menuName) { }

	public bool IsAnyMenuOpen() { }

	public bool IsAnyMenuOrPopupShowing(bool excludeMainMenu = false) { }

	public bool IsCurrentMenu(string menuName) { }

	public bool IsMenuInstanceActive(string sceneName) { }

	public bool IsMenuOnQueue(string menuName) { }

	public bool IsMenuOnStack(string menuName) { }

	public bool IsMenuOpenOrOpening(String[] menuNames) { }

	private bool IsOnlyContestedTerritoryMainMenuOpen() { }

	private bool IsOnlyMainMenuOpen() { }

	[IteratorStateMachine(typeof(<LoadInGame>d__52))]
	public IEnumerator LoadInGame() { }

	[IteratorStateMachine(typeof(<LoadMainMenu>d__54))]
	public IEnumerator LoadMainMenu(bool loadPrevMenuStackHistory) { }

	[IteratorStateMachine(typeof(<LoadSceneAsync>d__49))]
	private IEnumerator LoadSceneAsync(string sceneName) { }

	[IteratorStateMachine(typeof(<LoadWorldScene>d__60))]
	private IEnumerator LoadWorldScene(string newWorldScene) { }

	public void Lock(bool lockState) { }

	[IteratorStateMachine(typeof(<Open>d__68))]
	private IEnumerator Open(string menuName, object menuData) { }

	[IteratorStateMachine(typeof(<OpenLoadingScreen>d__61))]
	public IEnumerator OpenLoadingScreen(bool isLegendsMode = false) { }

	public void OpenMenu(string menuName, object menuData = null) { }

	[IteratorStateMachine(typeof(<OpenMenuInternal>d__67))]
	private IEnumerator OpenMenuInternal(string menuName, object menuData = null) { }

	public void OpenPauseMenu() { }

	public void OpenStore(StoreCategoryFilter storeCategory, string selectedProductId = null) { }

	public void PlayBGM(string track) { }

	public void PopMenuStack() { }

	private void PrevMenuCloseComplete(string menuToUnload) { }

	public void PrevMenuReCloseComplete(string menuToUnload, bool suppressError = false) { }

	private void ProcessEscape() { }

	public void QueueMenu(string menuName, object menuData = null) { }

	private void QuitGame() { }

	[CompilerGenerated]
	public void remove_OnTransitioningChanged(TransitioningDelegate value) { }

	public void RemoveMenuFromStack(string menuName) { }

	public void RemoveOnMenuClosedEvent(string menuName, OnMenuEvent callback) { }

	public void RemoveOnMenuOpenedEvent(string menuName, OnMenuEvent callback) { }

	public void RemoveTemporaryBackBind() { }

	[IteratorStateMachine(typeof(<ReOpen>d__73))]
	private IEnumerator ReOpen(string menuName, object menuData) { }

	[AsyncStateMachine(typeof(<RunIfNoMenuIsOpening>d__64))]
	public void RunIfNoMenuIsOpening(Func<Task> openMenuTask) { }

	[CompilerGenerated]
	private void set_CurrentWorldScene(string value) { }

	[CompilerGenerated]
	private static void set_instance(MenuManager value) { }

	private void set_IsClosingOrOpeningMenu(bool value) { }

	private void SetCanvasGroupInteractable(GameObject gameObject, bool interactable) { }

	public void SetMenuData(string menuName, object menuData) { }

	public void ShowQuit() { }

	public void TemporaryBackBind(UnityAction call) { }

	[IteratorStateMachine(typeof(<UnloadAllDontUnloads>d__76))]
	private IEnumerator UnloadAllDontUnloads(String[] ignores) { }

	[IteratorStateMachine(typeof(<UnloadInGame>d__53))]
	public IEnumerator UnloadInGame() { }

	public void UnloadLegendsMenu() { }

	[IteratorStateMachine(typeof(<UnloadMainMenu>d__51))]
	public IEnumerator UnloadMainMenu() { }

	[IteratorStateMachine(typeof(<UnloadSceneAsync>d__50))]
	private IEnumerator UnloadSceneAsync(string sceneName, bool suppressError = false) { }

	public void Update() { }

}

