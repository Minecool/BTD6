namespace NinjaKiwi.Common.ResourceUtils;

public struct SpriteReference : IAssetReference, IAssetReference<Sprite>, IEquatable<SpriteReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Sprite)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public SpriteReference(string guid) { }

	public override bool Equals(SpriteReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SpriteReference lhs, SpriteReference rhs) { }

	public static bool op_Inequality(SpriteReference lhs, SpriteReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

