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
   public class RowInfo
    {
        [DataMember]
        public int Moves { set; get; }
        [DataMember]
        public string Name { set; get; }
        [DataMember]
        public int Time { set; get; }


        public RowInfo(string name,int moves,int time)
        {
            Name = name;
            Moves = moves;
            Time = time;

        }
    }
}
