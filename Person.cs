namespace RazorWithComponent
{
	public class Person
	{
		public int Id { get; set; }	
		public string Name { get; set; } = string.Empty;
		public string Designation { get; set; } = string.Empty;
		public DateOnly DOJ { get; set; }
		public bool IsActive { get; set; }
	}
}
