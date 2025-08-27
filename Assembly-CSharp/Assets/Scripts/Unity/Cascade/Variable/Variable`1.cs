namespace Assets.Scripts.Unity.Cascade.Variable;

public abstract class Variable : CascadingItemProxy, GenericVariable
{
	private List<CascadingItem> attatchedTo; //Field offset: 0x0
	private Cache<GenericVariable[]> mods; //Field offset: 0x0
	public string expValue; //Field offset: 0x0
	[FormerlyExpressedAs("expValue")]
	public T value; //Field offset: 0x0

	public override GenericCascadingExpression Expression
	{
		 get { } //Length: 8
	}

	public virtual string Id
	{
		 get { } //Length: 23
		 set { } //Length: 688
	}

	public virtual Model Model
	{
		 get { } //Length: 3
	}

	public override Cache<GenericVariable[]> Mods
	{
		 get { } //Length: 204
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	protected Variable`1() { }

	[CompilerGenerated]
	private GenericCascadingExpression <AttatchExpressionListeners>b__9_0() { }

	[CompilerGenerated]
	private GenericCascadingExpression <AttatchToCascadeItem>b__10_0() { }

	protected virtual void AttatchExpressionListeners() { }

	public override void AttatchToCascadeItem(CascadingItem cascadeItem) { }

	protected virtual void Destroy() { }

	public override GenericCascadingExpression get_Expression() { }

	public virtual string get_Id() { }

	public virtual Model get_Model() { }

	public override Cache<GenericVariable[]> get_Mods() { }

	public override string get_Name() { }

	public GenericVariable[] GetTransformers() { }

	private void InvalidateUseInMutators() { }

	public override void RemoveFromCascadeItem(CascadingItem cascadeItem) { }

	public virtual void set_Id(string value) { }

}

