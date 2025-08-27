namespace NinjaKiwi.Common.ResourceUtils;

[AttributeUsage(AttributeTargets::Field (256))]
public class AssetReferenceAttribute : PropertyAttribute
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Type> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__2_0(Type t) { }

	}

	public Type[] objTypes; //Field offset: 0x18

	public AssetReferenceAttribute() { }

	public AssetReferenceAttribute(Type[] objTypes) { }

}

