namespace NinjaKiwi.Common.ResourceUtils;

public struct TextureReference : IAssetReference, IAssetReference<Texture>, IEquatable<TextureReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Texture)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public TextureReference(string guid) { }

	public override bool Equals(TextureReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TextureReference lhs, TextureReference rhs) { }

	public static bool op_Inequality(TextureReference lhs, TextureReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

