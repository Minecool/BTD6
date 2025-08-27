namespace Assets.Scripts.Simulation.Objects;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class RootObjectLockList : LockList<T>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Predicate<T> <>9__0_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__0_0(T t) { }

	}


	public RootObjectLockList`1() { }

	public RootObjectLockList`1(IEnumerable<T> items) { }

}

