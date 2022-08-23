using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StringConversion
{
    public  class StringSplitter
    {
        public void SplitString()
        {
            ArrayList settingsArrayList = new ArrayList();

            // string authors = "Mahesh Chand, Henry He, Chris Love, Raj Beniwal, Praveen Kumar";
            string authors = "Team,User,,,",countries="ban,aus,sa";
            string[] authorsList = authors.Split(' ', ',');
            string[] countriesList = countries.Split(' ', ',');

            settingsArrayList.Add(authorsList);
            settingsArrayList.Add(countriesList);

            foreach (string[] settings in settingsArrayList)
            {
                foreach (string country in settings)
                {
                    Console.WriteLine(country);
                    //if (country.Equals("user", StringComparison.CurrentCultureIgnoreCase))
                    //{
                    //    Console.WriteLine("Got it!");
                    //}
                }
                //Console.WriteLine(country);

            }
        }
    }
}
