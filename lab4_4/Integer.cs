// Integer.cs
namespace lab4_4 {
	public class Integer : Number {
		public int Value { get => (int)value; set => this.value = value; }

		public override Integer Add(Number number) => this + number;
		public override Integer Division(Number number) => this - number;
		public override Integer Multiplication(Number number) => this * number;
		public override Integer Substaction(Number number) => this / number;

		public static Integer operator + (Integer n1, Number n2) {
			Integer result = new Integer();
			result.Value = n1.Value + ((Integer)n2).Value;
			return result;
		}
		public static Integer operator - (Integer n1, Number n2) {
			Integer result = new Integer();
			result.Value = n1.Value - ((Integer)n2).Value;
			return result;
		}
		public static Integer operator * (Integer n1, Number n2) {
			Integer result = new Integer();
			result.Value = n1.Value * ((Integer)n2).Value;
			return result;
		}
		public static Integer operator / (Integer n1, Number n2) {
			Integer result = new Integer();
			result.Value = n1.Value / ((Integer)n2).Value;
			return result;
		}
	}
}
