namespace NinjaKiwi.Common.ResourceUtils;

public struct TMP_FontAssetReference : IAssetReference, IAssetReference<TMP_FontAsset>, IEquatable<TMP_FontAssetReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(TMP_FontAsset)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public TMP_FontAssetReference(string guid) { }

	public override bool Equals(TMP_FontAssetReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TMP_FontAssetReference lhs, TMP_FontAssetReference rhs) { }

	public static bool op_Inequality(TMP_FontAssetReference lhs, TMP_FontAssetReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

