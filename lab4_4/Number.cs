// Number.cs
namespace lab4_4 {
	public abstract class Number {
		protected double value;

		public abstract Number Add(Number number);
		public abstract Number Substaction(Number number);
		public abstract Number Multiplication(Number number);
		public abstract Number Division(Number number);
	}
}
