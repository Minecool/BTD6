namespace NinjaKiwi.Common.ResourceUtils;

public struct SpriteShapeReference : IAssetReference, IAssetReference<SpriteShape>, IEquatable<SpriteShapeReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(SpriteShape)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public SpriteShapeReference(string guid) { }

	public override bool Equals(SpriteShapeReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SpriteShapeReference lhs, SpriteShapeReference rhs) { }

	public static bool op_Inequality(SpriteShapeReference lhs, SpriteShapeReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

