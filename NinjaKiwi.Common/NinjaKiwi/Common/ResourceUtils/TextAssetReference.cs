namespace NinjaKiwi.Common.ResourceUtils;

public struct TextAssetReference : IAssetReference, IAssetReference<TextAsset>, IEquatable<TextAssetReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(TextAsset)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public TextAssetReference(string guid) { }

	public override bool Equals(TextAssetReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TextAssetReference lhs, TextAssetReference rhs) { }

	public static bool op_Inequality(TextAssetReference lhs, TextAssetReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

