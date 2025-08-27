namespace NinjaKiwi.Common.ResourceUtils;

public struct PrefabReference : IAssetReference, IAssetReference<GameObject>, IEquatable<PrefabReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(GameObject)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public PrefabReference(string guid) { }

	public override bool Equals(PrefabReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PrefabReference lhs, PrefabReference rhs) { }

	public static bool op_Inequality(PrefabReference lhs, PrefabReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

