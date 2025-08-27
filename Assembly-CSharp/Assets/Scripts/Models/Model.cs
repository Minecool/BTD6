namespace Assets.Scripts.Models;

public abstract class Model
{
	[CompilerGenerated]
	private sealed class <GetDescendants>d__21 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public Model <>4__this; //Field offset: 0x0
		private DescendantsSearchEnumerable<T> <_descendants>5__2; //Field offset: 0x0
		private DescendantsSearchEnumerator<T> <>7__wrap2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetDescendants>d__21`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct ChildSearchEnumerable
	{
		private readonly List<Model> models; //Field offset: 0x0

		public bool IsValid
		{
			 get { } //Length: 8
		}

		public ChildSearchEnumerable`1(List<Model> models) { }

		public bool get_IsValid() { }

		public ChildSearchEnumerator<T> GetEnumerator() { }

	}

	internal struct ChildSearchEnumerator
	{
		private readonly List<Model> models; //Field offset: 0x0
		private readonly int count; //Field offset: 0x0
		private int index; //Field offset: 0x0
		private T found; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 5
		}

		public ChildSearchEnumerator`1(List<Model> models) { }

		public T get_Current() { }

		public bool MoveNext() { }

	}

	internal struct DescendantsSearchEnumerable : IDisposable
	{
		private readonly List<Model> models; //Field offset: 0x0
		private readonly int enumeratorCount; //Field offset: 0x0

		public DescendantsSearchEnumerable`1(List<Model> models) { }

		public override void Dispose() { }

		public DescendantsSearchEnumerator<T> GetEnumerator() { }

	}

	internal struct DescendantsSearchEnumerator
	{
		private readonly List<Model> children; //Field offset: 0x0
		private readonly int childCount; //Field offset: 0x0
		private T found; //Field offset: 0x0
		private int childIndex; //Field offset: 0x0
		private int pass; //Field offset: 0x0
		private int enumeratorId; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 5
		}

		public DescendantsSearchEnumerator`1(List<Model> children, int childCount) { }

		public T get_Current() { }

		public bool MoveNext() { }

		private bool MoveNextPass1() { }

		private bool MoveNextPass2() { }

		private void SetupChild() { }

	}

	private static class DescendantsSearchEnumeratorStack
	{
		public static readonly List<DescendantsSearchEnumerator`1<T>> enumerators; //Field offset: 0x0

		private static DescendantsSearchEnumeratorStack`1() { }

	}

	private static readonly Dictionary<Type, String> typePrefix; //Field offset: 0x0
	[DataMember]
	private string _name; //Field offset: 0x10
	private bool checkedImplementationType; //Field offset: 0x18
	private Type implementationType; //Field offset: 0x20
	[DataMember]
	protected List<Model> childDependants; //Field offset: 0x28

	public Type ImplementationType
	{
		 get { } //Length: 414
	}

	public string name
	{
		 get { } //Length: 34
		 set { } //Length: 51
	}

	private static Model() { }

	protected Model(string name) { }

	public void AddChild(ICollection<T> toAdd) { }

	public void AddChildDependant(T toAdd) { }

	public override void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public override Model[] BehaviorModels() { }

	public abstract Model Clone() { }

	public static T[] CloneModels(T[] behaviors) { }

	public Type get_ImplementationType() { }

	public string get_name() { }

	public T GetChild() { }

	public ChildSearchEnumerable<T> GetChildren() { }

	public T GetDescendant() { }

	[IteratorStateMachine(typeof(<GetDescendants>d__21`1))]
	public IEnumerable<T> GetDescendants() { }

	public DescendantsSearchEnumerable<T> GetDescendantsFast() { }

	public bool IsEqual(Model to) { }

	protected abstract bool IsEqualAfterReferenceCheck(Model to) { }

	public void RemoveChild(ICollection<T> toRemove) { }

	public void RemoveChildDependant(T toRemove) { }

	public void set_name(string value) { }

	public override void SetBehaviorModels(Model[] behaviors) { }

	public void StripChildDependants() { }

}

