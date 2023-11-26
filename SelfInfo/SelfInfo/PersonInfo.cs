using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfInfo
{
    struct AddressFormat
    {
        private ushort houseNo;
        private ushort roadNo;
        private string dristic;

        public AddressFormat(ushort houseNo, ushort roadno, string dristic)
        {
            this.houseNo = houseNo;
            this.roadNo = roadno;
            this.dristic = dristic;
        }

        public ushort GetHouseNo()
        {
            return houseNo;
        }
        public void SetHouseNo(ushort houseNo)
        {
            this.houseNo = houseNo;
        }

        public ushort GetRoadNo()
        {
            return roadNo;
        }

        public string GetDristic()
        {
            return dristic;
        }
        public void SetDristic(string dristic)
        {
            this.dristic = dristic;
        }

        public void  showAddress()
        {
            Console.WriteLine("House No: {0}",this.GetHouseNo());
            Console.WriteLine("Road No: {0}",this.GetRoadNo());
            Console.WriteLine("Dristic: {0}",this.GetDristic());

        }
    }
    internal class PersonInfo
    {
        public int nid;
        public string name;
        public byte age;
        public string bloodGroup;
        AddressFormat address;

        public PersonInfo()
        {

        }

        public PersonInfo(int nid, string name, byte age, string bloodGroup,AddressFormat address)
        {
            this.nid = nid;
            this.name = name;
            this.age = age;
            this.bloodGroup = bloodGroup;
            this.address = address;
        }

        public int GetNid()
        {
            return nid;
        }
        public void SetNid(int nid)
        {
            this.nid = nid;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public byte GetAge()
        {
            return age;
        }
        public void SetAge(byte age)
        {
            this.age = age; 
        }
        public string GetBloodGroup()
        {
            return bloodGroup;
        }
        public void SetBloodGroup(string bloodGroup)
        {
            this.bloodGroup= bloodGroup;
        }

        public AddressFormat GetAddress()
        {
            return address; 
        }
        public void SetAddress(AddressFormat address)
        {
            this.address=address;
        }
        public void showPersonInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Nid No: {0}",this.GetNid());
            Console.WriteLine("Name: {0}",this.GetName());
            Console.WriteLine("Age: {0}",this.GetAge());
            Console.WriteLine("Blood Group: {0}",this.GetBloodGroup());
            this.address.showAddress();
        }
    }
}
