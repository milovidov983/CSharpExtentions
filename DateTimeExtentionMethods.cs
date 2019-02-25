namespace UsefulExtentions {
	using System;
	public static class DateTimeExtentionMethods {
		public static int GetMonthDifference(this DateTime oneDate, DateTime twoDate) {
			if (oneDate == default(DateTime) || twoDate == default(DateTime)) {
				throw new ArgumentException("One or both arguments are not initialized.");
			}

			if (oneDate > twoDate) {
				var swap = oneDate;
				oneDate = twoDate;
				twoDate = swap;
			}

			int monthsApart = 12 * (oneDate.Year - twoDate.Year) + oneDate.Month - twoDate.Month;
			return Math.Abs(monthsApart);
		}
	}
}
