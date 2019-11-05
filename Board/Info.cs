using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Board
{

    [DataContract]
    public class Info
    {
        [DataMember]
        public List<RowInfo> List;
        public Info()
        {
            List = new List<RowInfo>();

        }
        public void Add(string name,int moves,int time)
        {

            List.Add(new RowInfo(name, moves, time));


        }
        public void Add(RowInfo r)
        {
            List.Add(r);
        }
        
    }
}
