using System;
using Xunit;
using HashTables.Classes;
using System.Collections.Generic;
using LeftJoin;

namespace LeftJoinTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1withNull()
        {
            Hashtables tableOne = new Hashtables();
            tableOne.Add("fond", "enamored");
            tableOne.Add("wrath", "anger");


            Hashtables tableTwo = new Hashtables();
            tableTwo.Add("fond", "averse");
            tableTwo.Add("differnt", "delight");


            List<string> expected = new List<string>() { "fond", "enamored", "averse", "wrath", "anger", null  };

            Assert.Equal(expected, Program.LeftJoin(tableOne, tableTwo));
        }

        [Fact]
        public void Test2AllMatch()
        {
            Hashtables tableOne = new Hashtables();
            tableOne.Add("fond", "enamored");
            tableOne.Add("wrath", "anger");


            Hashtables tableTwo = new Hashtables();
            tableTwo.Add("fond", "averse");
            tableTwo.Add("wrath", "delight");


            List<string> expected = new List<string>() { "fond", "enamored", "averse", "wrath", "anger", "delight" };

            Assert.Equal(expected, Program.LeftJoin(tableOne, tableTwo));
        }

        [Fact]
        public void Test3()
        {
            Hashtables tableOne = new Hashtables();
            tableOne.Add("fond", "enamored");
            tableOne.Add("wrath", "anger");


            Hashtables tableTwo = new Hashtables();
            tableTwo.Add("fond", "averse");
            tableTwo.Add("wrath", "delight");


            List<string> expected = new List<string>() { "fond", "enamored", "averse", "wrath", "anger", "delight" };

            Assert.Equal(expected, Program.LeftJoin(tableOne, tableTwo));
        }
    }
}
