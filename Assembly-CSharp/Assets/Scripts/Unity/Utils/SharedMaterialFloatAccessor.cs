namespace Assets.Scripts.Unity.Utils;

public class SharedMaterialFloatAccessor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <UpdateProperty>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Material mat; //Field offset: 0x20
		public int propertyId; //Field offset: 0x28
		public SharedMaterialFloatAccessor <>4__this; //Field offset: 0x30

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
		public <UpdateProperty>d__4(int <>1__state) { }

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

	[SerializeField]
	private Renderer[] references; //Field offset: 0x20
	[SerializeField]
	private string propertyName; //Field offset: 0x28
	[SerializeField]
	private float propertyValue; //Field offset: 0x30

	public SharedMaterialFloatAccessor() { }

	private void OnEnable() { }

	[IteratorStateMachine(typeof(<UpdateProperty>d__4))]
	private IEnumerator UpdateProperty(Material mat, int propertyId) { }

}

