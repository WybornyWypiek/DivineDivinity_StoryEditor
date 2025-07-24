using System;
using System.Collections.Generic;

namespace StoryEditor
{
    public class Goal
    {
        public List<int> parent = new List<int>();
        public List<int> child = new List<int>();
        public int ID;
        public string NAME = "";
        public List<string> INIT = new List<string>();
        public List<string> KB = new List<string>();
        public List<string> EXIT = new List<string>();
        public Goal(int id, string name)
        {
            ID = id;
            NAME = name;
        }
        public Goal(int id, string name, List<string> init, List<string> kb, List<string> exit)
        {
            ID = id;
            NAME = name;
            INIT = init;
            KB = kb;
            EXIT = exit;
        }
        public void ClearParentAndChild()
        {
            parent.Clear();
            child.Clear();
        }
    }
}