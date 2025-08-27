namespace Assets.Scripts.Unity.Cascade;

[ExecuteInEditMode]
public abstract class CascadingItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__45_0; //Field offset: 0x8
		public static Func<Type, Boolean> <>9__48_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetExpressions>b__45_0(Type x) { }

		internal bool <GetObjects>b__48_0(Type x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public string label; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal bool <GetExpression>b__0(ExpressionInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public ExpressionInfo expInfo; //Field offset: 0x10
		public FieldInfo actualField; //Field offset: 0x18
		public FieldInfo localField; //Field offset: 0x20
		public CascadingItem <>4__this; //Field offset: 0x28

		public <>c__DisplayClass45_0() { }

		internal void <GetExpressions>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public string label; //Field offset: 0x10

		public <>c__DisplayClass47_0() { }

		internal bool <GetObject>b__0(ObjectReferenceInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public FieldInfo field; //Field offset: 0x10
		public FieldInfo actualField; //Field offset: 0x18
		public ObjectReferenceInfo expInfo; //Field offset: 0x20
		public CascadingItem <>4__this; //Field offset: 0x28

		public <>c__DisplayClass48_0() { }

		internal void <GetObjects>b__1(object o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public FieldInfo formerField; //Field offset: 0x10
		public GenericCascadingExpression expression; //Field offset: 0x18
		public CascadingItem <>4__this; //Field offset: 0x20

		public <>c__DisplayClass49_0() { }

		internal void <CreateExpressionsForLegacyMethod>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public ObjectReferenceInfo innerField; //Field offset: 0x10

		public <>c__DisplayClass50_0() { }

		internal void <AttatchExpressionListeners>b__0(CascadingItem parent) { }

		internal void <AttatchExpressionListeners>b__1(CascadingItem parent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_1
	{
		public ExpressionInfo innerField; //Field offset: 0x10
		public CascadingItem <>4__this; //Field offset: 0x18

		public <>c__DisplayClass50_1() { }

		internal GenericCascadingExpression <AttatchExpressionListeners>b__2() { }

		internal GenericCascadingExpression <AttatchExpressionListeners>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <GetExpressionlessFields>d__43 : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private FieldInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CascadingItem <>4__this; //Field offset: 0x28
		private IEnumerator<FieldInfo> <>7__wrap1; //Field offset: 0x30

		private override FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.Current
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
		public <GetExpressionlessFields>d__43(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetExpressions>d__45 : IEnumerable<ExpressionInfo>, IEnumerable, IEnumerator<ExpressionInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ExpressionInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CascadingItem <>4__this; //Field offset: 0x28
		private Type <type>5__2; //Field offset: 0x30
		private IEnumerator<FieldInfo> <>7__wrap2; //Field offset: 0x38

		private override ExpressionInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Cascade.CascadingItem.ExpressionInfo>.Current
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
		public <GetExpressions>d__45(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ExpressionInfo> System.Collections.Generic.IEnumerable<Assets.Scripts.Unity.Cascade.CascadingItem.ExpressionInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override ExpressionInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Cascade.CascadingItem.ExpressionInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetObjects>d__48 : IEnumerable<ObjectReferenceInfo>, IEnumerable, IEnumerator<ObjectReferenceInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ObjectReferenceInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CascadingItem <>4__this; //Field offset: 0x28
		private Type <type>5__2; //Field offset: 0x30
		private IEnumerator<FieldInfo> <>7__wrap2; //Field offset: 0x38

		private override ObjectReferenceInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Cascade.CascadingItem.ObjectReferenceInfo>.Current
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
		public <GetObjects>d__48(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ObjectReferenceInfo> System.Collections.Generic.IEnumerable<Assets.Scripts.Unity.Cascade.CascadingItem.ObjectReferenceInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override ObjectReferenceInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Cascade.CascadingItem.ObjectReferenceInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetSerielizedFields>d__42 : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private FieldInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CascadingItem <>4__this; //Field offset: 0x28
		private FieldInfo[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.Current
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
		public <GetSerielizedFields>d__42(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class ExpressionInfo
	{
		public string label; //Field offset: 0x10
		public FieldInfo field; //Field offset: 0x18
		public GenericCascadingExpression expression; //Field offset: 0x20

		public ExpressionInfo() { }

	}

	internal class ObjectReferenceInfo
	{
		public string label; //Field offset: 0x10
		public FieldInfo field; //Field offset: 0x18
		public GenericObjectReference obj; //Field offset: 0x20

		public ObjectReferenceInfo() { }

	}

	public static string legacyExpressionPrefix; //Field offset: 0x0
	public static string parentFieldName; //Field offset: 0x8
	public string id; //Field offset: 0x20
	private GameObject heirarchyParent; //Field offset: 0x28
	private Dictionary<String, ExpressionInfo> tmpExpressions; //Field offset: 0x30
	private Dictionary<String, ObjectReferenceInfo> tmpObjects; //Field offset: 0x38
	private LockList<CascadingItem> children; //Field offset: 0x40
	private bool expressionsInitialised; //Field offset: 0x48
	private bool readyingEditView; //Field offset: 0x49
	private Cache<CascadingItem> parent; //Field offset: 0x50
	private Cache<CascadingItem> _base; //Field offset: 0x58
	private Cache<IEnumerable`1<FieldInfo>> serielizedFields; //Field offset: 0x60
	private Cache<IEnumerable`1<FieldInfo>> expressionlessFields; //Field offset: 0x68
	private Cache<IEnumerable`1<ExpressionInfo>> expressions; //Field offset: 0x70
	private Cache<IEnumerable`1<ObjectReferenceInfo>> objects; //Field offset: 0x78

	public Cache<CascadingItem> Base
	{
		 get { } //Length: 224
	}

	public Cache<IEnumerable`1<FieldInfo>> ExpressionlessFields
	{
		 get { } //Length: 192
	}

	public Cache<IEnumerable`1<ExpressionInfo>> Expressions
	{
		 get { } //Length: 192
	}

	public override string Id
	{
		 get { } //Length: 5
		 set { } //Length: 71
	}

	public abstract Model Model
	{
		 get { } //Length: 0
	}

	public Cache<IEnumerable`1<ObjectReferenceInfo>> Objects
	{
		 get { } //Length: 192
	}

	public Cache<CascadingItem> Parent
	{
		 get { } //Length: 773
	}

	public Cache<IEnumerable`1<FieldInfo>> SerielizedFields
	{
		 get { } //Length: 192
	}

	private static CascadingItem() { }

	protected CascadingItem() { }

	[CompilerGenerated]
	private IEnumerable<FieldInfo> <get_ExpressionlessFields>b__25_0() { }

	[CompilerGenerated]
	private IEnumerable<ExpressionInfo> <get_Expressions>b__28_0() { }

	[CompilerGenerated]
	private IEnumerable<ObjectReferenceInfo> <get_Objects>b__31_0() { }

	[CompilerGenerated]
	private void <get_Parent>b__16_0(CascadingItem parent) { }

	[CompilerGenerated]
	private void <get_Parent>b__16_1(CascadingItem parent) { }

	[CompilerGenerated]
	private void <get_Parent>b__16_2() { }

	[CompilerGenerated]
	private IEnumerable<FieldInfo> <get_SerielizedFields>b__22_0() { }

	protected override void AddVariablesToExpression(string label, GenericCascadingExpression expression) { }

	protected override void AttatchExpressionListeners() { }

	public void CreateExpressionsForLegacyMethod() { }

	protected override void Destroy() { }

	public static void ForceUpdateAll() { }

	public Cache<CascadingItem> get_Base() { }

	public Cache<IEnumerable`1<FieldInfo>> get_ExpressionlessFields() { }

	public Cache<IEnumerable`1<ExpressionInfo>> get_Expressions() { }

	public override string get_Id() { }

	public abstract Model get_Model() { }

	public Cache<IEnumerable`1<ObjectReferenceInfo>> get_Objects() { }

	public Cache<CascadingItem> get_Parent() { }

	public Cache<IEnumerable`1<FieldInfo>> get_SerielizedFields() { }

	public static string GetActualFieldName(string name) { }

	public override CascadingItem GetBase() { }

	public T GetComponentInImediateChildren() { }

	public T[] GetComponentsInImediateChildren() { }

	public ExpressionInfo GetExpression(string label) { }

	[IteratorStateMachine(typeof(<GetExpressionlessFields>d__43))]
	private IEnumerable<FieldInfo> GetExpressionlessFields() { }

	[IteratorStateMachine(typeof(<GetExpressions>d__45))]
	private IEnumerable<ExpressionInfo> GetExpressions() { }

	public ObjectReferenceInfo GetObject(string label) { }

	[IteratorStateMachine(typeof(<GetObjects>d__48))]
	private IEnumerable<ObjectReferenceInfo> GetObjects() { }

	protected override CascadingItem GetParent() { }

	[IteratorStateMachine(typeof(<GetSerielizedFields>d__42))]
	private IEnumerable<FieldInfo> GetSerielizedFields() { }

	protected void InvalidateAllLinks() { }

	protected void InvalidateAllWithId(string id) { }

	private void OnDestroy() { }

	protected override void OnHierarchyParentChanged() { }

	private void OnTransformParentChanged() { }

	public override void ReadyEditView() { }

	public override void set_Id(string value) { }

	public void SetDirty() { }

}

