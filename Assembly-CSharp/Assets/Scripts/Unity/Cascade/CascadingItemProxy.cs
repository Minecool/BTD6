namespace Assets.Scripts.Unity.Cascade;

[ExecuteInEditMode]
public abstract class CascadingItemProxy : CascadingItem
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public CascadingItemProxy <>4__this; //Field offset: 0x10
		public string label; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal GenericCascadingExpression <AddVariablesToExpression>b__0() { }

	}

	internal class ProxyPath
	{
		public CascadingItem cascadingItem; //Field offset: 0x10
		public String[] path; //Field offset: 0x18

		public ProxyPath() { }

	}

	private Cache<ProxyPath> proxy; //Field offset: 0x80

	public Cache<ProxyPath> Proxy
	{
		 get { } //Length: 259
	}

	protected CascadingItemProxy() { }

	protected virtual void AddVariablesToExpression(string label, GenericCascadingExpression expression) { }

	public Cache<ProxyPath> get_Proxy() { }

	public CascadingItem GetFromPath(CascadingItem anchor, String[] path) { }

	protected virtual CascadingItem GetParent() { }

	public PrefabReference GetPrefabReference(GameObject source, PrefabReference provided) { }

	public ProxyPath GetProxy() { }

	public CascadingItem GetProxyAnchor(GameObject with) { }

	protected virtual void OnHierarchyParentChanged() { }

}

