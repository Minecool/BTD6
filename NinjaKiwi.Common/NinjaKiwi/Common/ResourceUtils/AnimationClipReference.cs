namespace NinjaKiwi.Common.ResourceUtils;

public struct AnimationClipReference : IAssetReference, IAssetReference<AnimationClip>, IEquatable<AnimationClipReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AnimationClip)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public AnimationClipReference(string guid) { }

	public override bool Equals(AnimationClipReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(AnimationClipReference lhs, AnimationClipReference rhs) { }

	public static bool op_Inequality(AnimationClipReference lhs, AnimationClipReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

