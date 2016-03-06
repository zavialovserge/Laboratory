using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp_Net_module1_4_3_lab
{
    // 12) change methods of sorting to properties

    // 1) implement interface IComparable
    public class Animal:IComparable<Animal>
    {
        // 2) declare properties and parameter constructor
        public string name{get;set;}
        public int weight { get; set; }
        public Animal(string _name,int _weight)
        {
            name = _name;
            weight = _weight;
        }

        // 3) implement method ComareTo()
        // it comares Genus of type string - return result of method String.Compare 
        // for this.genus and argument object
        // don't forget to cast object to Animal

        public int CompareTo(Animal other)
        {
            return name.CompareTo(other.name);
        }
        // 4) declare methods SortWeightAscending(), SortGenusDescending()
        // they are static and return IComparer
        // return type is custed from constructor of classes SortWeightAscendingHelper, 
        // SortGenusDescendingHelper calling 
        public static IComparer SortGenusDescending
        {
            get 
            { 
                return (IComparer)new SortGenusDescendingHelper(); 
            }
        }
        public static IComparer SortWeightAscending
        {
            get 
            { 
                return (IComparer)new SortWeightAscendingHelper(); 
            }
        }
        // 5) declare 2 nested private classes SortWeightAscendingHelper, SortGenusDescendingHelper 
        // they implement interface IComparer
        // every nested class has implemented method Comare with 2 parameters of object and return int
        // class SortWeightAscendingHelper sort weight by ascending
        // class SortGenusDescendingHelper sort genus by descending
        private class SortWeightAscendingHelper:IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                Animal a1 = obj1 as Animal;
                Animal a2 = obj2 as Animal;
                if (a1 != null && a2 != null)
                {
                    return a1.weight.CompareTo(a2.weight);
                }
                else
                    throw new ArgumentException("This is not Animal");
              
            }
        }
        private class SortGenusDescendingHelper:IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                Animal a1 = obj1 as Animal;
                Animal a2 = obj2 as Animal;
                if (a1 != null && a2 != null)
                {
                    return string.Compare(a2.name, a1.name);
                }
                else
                    throw new ArgumentException("This is not Animal"); 
            }
        }
    }



 
}
