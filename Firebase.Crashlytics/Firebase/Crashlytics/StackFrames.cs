namespace Firebase.Crashlytics;

[DefaultMember("Item")]
internal class StackFrames : IDisposable, IEnumerable, IEnumerable<FirebaseCrashlyticsFrame>
{
	internal sealed class StackFramesEnumerator : IEnumerator, IEnumerator<FirebaseCrashlyticsFrame>, IDisposable
	{
		private StackFrames collectionRef; //Field offset: 0x10
		private int currentIndex; //Field offset: 0x18
		private object currentObject; //Field offset: 0x20
		private int currentSize; //Field offset: 0x28

		public override FirebaseCrashlyticsFrame Current
		{
			 get { } //Length: 352
		}

		private override object global::System.Collections.IEnumerator.Current
		{
			private get { } //Length: 352
		}

		public StackFramesEnumerator(StackFrames collection) { }

		public override void Dispose() { }

		public override FirebaseCrashlyticsFrame get_Current() { }

		private override object global::System.Collections.IEnumerator.get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private HandleRef swigCPtr; //Field offset: 0x10
	protected bool swigCMemOwn; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 291
	}

	public FirebaseCrashlyticsFrame Item
	{
		 get { } //Length: 383
	}

	internal StackFrames(IntPtr cPtr, bool cMemoryOwn) { }

	public StackFrames() { }

	public void Add(FirebaseCrashlyticsFrame x) { }

	public override void Dispose() { }

	public override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public int get_Count() { }

	public FirebaseCrashlyticsFrame get_Item(int index) { }

	internal static HandleRef getCPtr(StackFrames obj) { }

	private FirebaseCrashlyticsFrame getitem(int index) { }

	private override IEnumerator<FirebaseCrashlyticsFrame> global::System.Collections.Generic.IEnumerable<Firebase.Crashlytics.FirebaseCrashlyticsFrame>.GetEnumerator() { }

	private override IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	private uint size() { }

}

