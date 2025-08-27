namespace Unity.Burst;

[AttributeUsage(77)]
public class BurstCompileAttribute : Attribute
{
	[CompilerGenerated]
	private FloatMode <FloatMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private FloatPrecision <FloatPrecision>k__BackingField; //Field offset: 0x14
	internal Nullable<Boolean> _compileSynchronously; //Field offset: 0x18
	internal Nullable<Boolean> _disableSafetyChecks; //Field offset: 0x1A
	[CompilerGenerated]
	private OptimizeFor <OptimizeFor>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private String[] <Options>k__BackingField; //Field offset: 0x20

	public bool CompileSynchronously
	{
		 set { } //Length: 91
	}

	public bool DisableSafetyChecks
	{
		 set { } //Length: 91
	}

	public FloatMode FloatMode
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public FloatPrecision FloatPrecision
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public OptimizeFor OptimizeFor
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal String[] Options
	{
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public BurstCompileAttribute() { }

	public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode) { }

	public void set_CompileSynchronously(bool value) { }

	public void set_DisableSafetyChecks(bool value) { }

	[CompilerGenerated]
	public void set_FloatMode(FloatMode value) { }

	[CompilerGenerated]
	public void set_FloatPrecision(FloatPrecision value) { }

	[CompilerGenerated]
	public void set_OptimizeFor(OptimizeFor value) { }

	[CompilerGenerated]
	internal void set_Options(String[] value) { }

}

