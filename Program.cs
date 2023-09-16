using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowDotNetAPI.Models;
using WowDotNetAPI;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WowExplorer explorer = new WowExplorer(WowDotNetAPI.Region.EU, Locale.en_GB, "#########################");
            IEnumerable<Realm> enRealm = explorer.GetRealms();

            WowDotNetAPI.Models.CharacterItem wow = new CharacterItem();
            string user = "SindreMA";
            string Realm = "Aggramar";
            Character item = explorer.GetCharacter(Realm, user, CharacterOptions.GetEverything);

            Realm realm = enRealm.First();
            string res = realm.ToString();
            string iShoulders = item.Items.Shoulder.ToString();
            string iTrinket1 = item.Items.Trinket1.ToString();
            string iTrinket2 = item.Items.Trinket2.ToString();
            string iNeck = item.Items.Neck.ToString();
            string iHands = item.Items.Hands.ToString();
            foreach (var re1alm in enRealm)
            {
                Console.WriteLine(re1alm.Name);
            }
            Console.WriteLine(iShoulders);
            Console.ReadLine();
        }
    }
}
