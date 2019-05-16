using System;

namespace gitHubTest.Models
{
    public class Cat
    {
        private int age;
        private string status;

        public Cat(int age, String status)
        {
            this.age = age;
            this.status = status;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public Cat(){}

        public override bool Equals(object obj)
        {
            var cat = obj as Cat;
            return cat != null &&
                   age == cat.age &&
                   status == cat.status;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(age, status);
        }
    }
}