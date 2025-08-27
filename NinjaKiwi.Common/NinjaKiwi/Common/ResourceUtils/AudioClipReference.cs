namespace NinjaKiwi.Common.ResourceUtils;

public struct AudioClipReference : IAssetReference, IAssetReference<AudioClip>, IEquatable<AudioClipReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AudioClip)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public AudioClipReference(string guid) { }

	public override bool Equals(AudioClipReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(AudioClipReference lhs, AudioClipReference rhs) { }

	public static bool op_Inequality(AudioClipReference lhs, AudioClipReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

