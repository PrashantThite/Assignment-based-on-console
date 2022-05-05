using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class Voter
    {
        long voterId;
        string voterName;
        string voteGiven;

        public void SetvoterId(long vid)
        {
            voterId = vid;
        }
        public long getvoterId()
        {
            return voterId;
        }

        public void SetVoterName(string name)
        {
            voterName = name;
        }

        public string getvoterName()
        {
            return voterName;
        }

        public void setvoteGiven(string vGiven)
        {
            voteGiven =vGiven;
        }

        public string getvoteGiven()
        {
            return voteGiven;
        }
    }

    class Vote
    {
        static void Main(string[] args)
        {
            Voter a = new Voter();
            a.SetvoterId(5551236545);
            a.SetVoterName("Prashant");
            a.setvoteGiven("bjp");

            long vid = a.getvoterId();
            Console.WriteLine("voter Id="+vid);
            string Name = a.getvoterName();
            Console.WriteLine("voter Name="+Name);
            string voted = a.getvoteGiven();
            Console.WriteLine("voted to= "+voted);

        }
    }

}
