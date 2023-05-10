namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class Stadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Stadium()
        {

        }
        public Stadium(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name can not be empty");
            Name = name;
        }
    }
}
