using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ordering
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myFirstGenericList = new List<string>();
            Console.WriteLine("the list has " + myFirstGenericList.Count() + "items");
            do
            {
                Console.WriteLine("Please enter item");
                var item = Console.ReadLine();
                myFirstGenericList.Add(item);
            } while (myFirstGenericList.Count() < 10);

            var i = myFirstGenericList[0];

            var mySecondGenList = new Collection<string>();
            mySecondGenList.Remove(i);
            var uiUpdate = new Collection<string>();
            foreach (var item in mySecondGenList)
            {
                uiUpdate.Add(item);
            }
            mySecondGenList = new Collection<string>(uiUpdate);
            var myObservableCollection = new ObservableCollection<string>();
            myObservableCollection.Remove(i);
            myObservableCollection.Add(i);

            

            Console.WriteLine("your list has " + myFirstGenericList.Count() + "items");
            Console.ReadKey();

        }
    }
}
