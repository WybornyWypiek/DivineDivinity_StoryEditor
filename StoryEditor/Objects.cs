using System;

namespace StoryEditor
{
    public class Objects
    {
        public string name = "";
        public int type;
        public int ID;
        public Objects(string name, string type, string ID)
        {
            this.name = name;
            this.type = Int32.Parse(type);
            this.ID = Int32.Parse(ID);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            Objects other = (Objects)obj;
            return (ID == other.ID) && (type == other.type);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, type);
        }
    }
}