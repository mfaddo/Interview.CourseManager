﻿namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class Academy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Academy()
        {

        }
        public Academy( string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name can not be empty");
            Name = name;
        }
    }
}
