using System;
using System.Collections.Generic;
using System.Text;

namespace ZachotPls
{
    class Child
    {
        public Human child;
        public List<int> childAchievments = new List<int>();

        public Child(Human human)
        {
            child = human;
        }
    }
}
