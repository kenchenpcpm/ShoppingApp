using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ShoppingCart
{
    public delegate void ListAddedDelegate(object sender, EventArgs args);

    public class NameObject
    {
        public NameObject(string member)
        {
            Member = member;
        }

        public string Member { get; set; }
    }

    public interface IEList
    {
        void ListAdd(string name);
        string Member { get; }
        event ListAddedDelegate ListAdded;
    }
    
    public abstract class List : NameObject, IEList
    {
        string IEList.Member => throw new NotImplementedException();

        public List(string name) : base(name)
        {
        }

        event ListAddedDelegate IEList.ListAdded
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public abstract event ListAddedDelegate ListAdded;
        public abstract void ListAdd(string member);
        
    }

    public class DiskList : List
    {
        public DiskList(string member) : base(member)
        {
        }
        public override event ListAddedDelegate ListAdded;

        public override void ListAdd(string name)
        {
            using (var writer = File.AppendText($"{Member}.txt"))
            {
                writer.WriteLine(name);
                if(ListAdded != null)
                {
                    ListAdded(this, new EventArgs());
                }
            }
        }

        public class InMemoryList : List
        {
            public InMemoryList(string member) : base(member)
            {
                List<string> Items = new List<string>();
                Member = member;
            }

            public override event ListAddedDelegate ListAdded;

            public override void ListAdd(string member)
            {
                throw new NotImplementedException();
            }
        }
    }
}
