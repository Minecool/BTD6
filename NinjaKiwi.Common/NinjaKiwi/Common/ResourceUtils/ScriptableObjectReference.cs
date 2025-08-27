namespace NinjaKiwi.Common.ResourceUtils;

public struct ScriptableObjectReference : IAssetReference, IAssetReference<ScriptableObject>, IEquatable<ScriptableObjectReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(ScriptableObject)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public ScriptableObjectReference(string guid) { }

	public override bool Equals(ScriptableObjectReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ScriptableObjectReference lhs, ScriptableObjectReference rhs) { }

	public static bool op_Inequality(ScriptableObjectReference lhs, ScriptableObjectReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

