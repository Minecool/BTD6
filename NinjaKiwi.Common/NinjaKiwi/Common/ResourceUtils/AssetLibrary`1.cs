namespace NinjaKiwi.Common.ResourceUtils;

public abstract class AssetLibrary : ScriptableObjectSingleton<AssetLibrary`1<T>>, IAssetLibrary
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<Entry<T>, String> <>9__16_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal string <EnsureReverseLookupTable>b__16_0(Entry<T> e) { }

	}

	[CompilerGenerated]
	private sealed class <AllEntries>d__15 : IEnumerable<Entry<T>>, IEnumerable, IEnumerator<Entry<T>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private Entry<T> <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public AssetLibrary<T> <>4__this; //Field offset: 0x0
		private Enumerator<Group<T>> <>7__wrap1; //Field offset: 0x0
		private Entry<T>[] <>7__wrap2; //Field offset: 0x0
		private int <>7__wrap3; //Field offset: 0x0

		private override Entry<T> System.Collections.Generic.IEnumerator<NinjaKiwi.Common.ResourceUtils.AssetLibrary<T>.Entry>.Current
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
		public <AllEntries>d__15(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Entry<T>> System.Collections.Generic.IEnumerable<NinjaKiwi.Common.ResourceUtils.AssetLibrary<T>.Entry>.GetEnumerator() { }

		[DebuggerHidden]
		private override Entry<T> System.Collections.Generic.IEnumerator<NinjaKiwi.Common.ResourceUtils.AssetLibrary<T>.Entry>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class Entry : IEntry, ITreeViewItem<T>, ISerializationCallbackReceiver, IAssetReference, IEquatable<IAssetReference>
	{
		[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(GameObject), typeof(Sprite), typeof(AudioClip)}])]
		[SerializeField]
		private string guidRef; //Field offset: 0x0
		[SerializeField]
		private AssetType type; //Field offset: 0x0
		[EnumFlags]
		[SerializeField]
		private T flags; //Field offset: 0x0
		[SerializeField]
		private int id; //Field offset: 0x0
		[SerializeField]
		private SpriteReference thumbnail; //Field offset: 0x0
		[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Sprite)}])]
		[SerializeField]
		private string thumbnailOverride; //Field offset: 0x0

		public AudioClipReference AsAudioClip
		{
			 get { } //Length: 122
		}

		public PrefabReference AsPrefab
		{
			 get { } //Length: 122
		}

		public override string AssetGUID
		{
			 get { } //Length: 5
		}

		public SpriteReference AsSprite
		{
			 get { } //Length: 122
		}

		public T Flags
		{
			 get { } //Length: 4
		}

		public int Id
		{
			 get { } //Length: 4
		}

		public SpriteReference Thumbnail
		{
			 get { } //Length: 5
		}

		public AssetType Type
		{
			 get { } //Length: 4
		}

		public Entry() { }

		public override bool Equals(IAssetReference rhs) { }

		public AudioClipReference get_AsAudioClip() { }

		public PrefabReference get_AsPrefab() { }

		public override string get_AssetGUID() { }

		public SpriteReference get_AsSprite() { }

		public T get_Flags() { }

		public int get_Id() { }

		public SpriteReference get_Thumbnail() { }

		public AssetType get_Type() { }

		public override bool RuntimeKeyIsValid() { }

		private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

		private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	}

	internal class Group : IGroup, ITreeViewItem<T>
	{
		[SerializeField]
		private string name; //Field offset: 0x0
		[SerializeField]
		private Entry<T>[] entries; //Field offset: 0x0

		public Entry<T>[] Entries
		{
			 get { } //Length: 5
		}

		public Group() { }

		public Entry<T>[] get_Entries() { }

	}

	private interface ITreeViewItem
	{

	}

	[SerializeField]
	private List<Group<T>> groups; //Field offset: 0x0
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(SpriteAtlas)}])]
	[SerializeField]
	private string atlas; //Field offset: 0x0
	[SerializeField]
	private Vector3 thumbnailCamForward; //Field offset: 0x0
	[SerializeField]
	private Vector2 thumbnailWidthAndHeight; //Field offset: 0x0
	[SerializeField]
	private float thumbnailCamFOV; //Field offset: 0x0
	private Dictionary<String, Entry<T>> reverseLookupTable; //Field offset: 0x0

	public Vector3 ThumbnailCamForward
	{
		 get { } //Length: 19
	}

	public float ThumbnailCamFOV
	{
		 get { } //Length: 6
	}

	protected AssetLibrary`1() { }

	[IteratorStateMachine(typeof(<AllEntries>d__15))]
	public IEnumerable<Entry<T>> AllEntries() { }

	private void EnsureReverseLookupTable() { }

	public bool FindEntry(IAssetReference reference, out Entry<T> entry) { }

	public Vector3 get_ThumbnailCamForward() { }

	public float get_ThumbnailCamFOV() { }

	private void OnEnable() { }

}

