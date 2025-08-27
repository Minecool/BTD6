namespace NinjaKiwi.Common.ResourceUtils;

public struct MaterialReference : IAssetReference, IAssetReference<Material>, IEquatable<MaterialReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Material)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public MaterialReference(string guid) { }

	public override bool Equals(MaterialReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(MaterialReference lhs, MaterialReference rhs) { }

	public static bool op_Inequality(MaterialReference lhs, MaterialReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

