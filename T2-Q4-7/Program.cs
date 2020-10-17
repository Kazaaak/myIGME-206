using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{

    public abstract class Phone
    {
        private string phoneNumber;
        public string PhoneNumber;
        public string address;

        public abstract int Connect();
        public abstract int Disconnect();
    }

    public interface PhoneInterface
    {

        public void Answer();

        public void MakeCall();

        public void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {

        public override int Connect()
        {
            return 0;
        }

        public override int Disconnect()
        {
            return 0;
        }

        void PhoneInterface.Answer()
        {

        }

        void PhoneInterface.MakeCall()
        {

        }

        void PhoneInterface.HangUp()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;

        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho;

        public string FemaleSideKick
        {
            get;
        }

        public void TimeTravel()
        {

        }

        public static bool operator ==(Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho == t2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho != t2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho == t2.WhichDrWho)
            {
                return false;
            }
            if (t2.WhichDrWho == 10)
            {
                return true;
            }
            if (t1.WhichDrWho == 10)
            {
                return false;
            }
            return (t1.WhichDrWho < t2.WhichDrWho);
        }

        public static bool operator >(Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho == t2.WhichDrWho)
            {
                return false;
            }
            if (t2.WhichDrWho == 10)
            {
                return false;
            }
            if (t1.WhichDrWho == 10)
            {
                return true;
            }
            return (t1.WhichDrWho > t2.WhichDrWho);
        }

        public static bool operator <=(Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho == t2.WhichDrWho)
            {
                return true;
            }
            if (t2.WhichDrWho == 10)
            {
                return true;
            }
            if (t1.WhichDrWho == 10)
            {
                return false;
            }
            return (t1.WhichDrWho < t2.WhichDrWho);
        }

        public static bool operator >=(Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho == t2.WhichDrWho)
            {
                return true;
            }
            if (t2.WhichDrWho == 10)
            {
                return false;
            }
            if (t1.WhichDrWho == 10)
            {
                return true;
            }
            return (t1.WhichDrWho > t2.WhichDrWho);
        }

    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public override int Connect()
        {
            return 0;
        }

        public override int Disconnect()
        {
            return 0;
        }

        void PhoneInterface.Answer()
        {

        }

        void PhoneInterface.MakeCall()
        {

        }

        void PhoneInterface.HangUp()
        {

        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            UsePhone(tardis);

            PhoneBooth phoneBooth = new PhoneBooth();
            UsePhone(phoneBooth);

        }

        static void UsePhone(object phoneObject)
        {
            PhoneInterface phoneInterface = (PhoneInterface)phoneObject;
            phoneInterface.MakeCall();

            if (phoneObject is PhoneBooth)
            {
                PhoneBooth boothObj = (PhoneBooth)phoneObject;
                boothObj.OpenDoor();
            }

            if (phoneObject is Tardis)
            {
                Tardis tardisObj = (Tardis)phoneObject;
                tardisObj.TimeTravel();
            }
        }
    }

}
